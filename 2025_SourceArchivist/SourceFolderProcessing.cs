using System.IO.Compression;

namespace SourceArchivist
{
    internal class SourceFolderProcessing
    {
        readonly Func<int, bool> _stepSize = (stepCounter) => stepCounter % 50 == 0;
        readonly Func<int, int, DateTime, string> _writeStep = (count, total, timeofsuccess) => $"{count}/{total} : {(DateTime.Now - timeofsuccess).TotalMilliseconds:N2}ms";
        readonly Func<int, int, string, DateTime, string> _writeSuccess = (count, total, target, timeofsuccess) => $"{count}/{total} file(s) to {target}: {(DateTime.Now - timeofsuccess).TotalMilliseconds:N2} ms";
        static readonly Action<string> Write = Console.WriteLine;

        private readonly CommandLineOptions _commandLineOptions;

        public SourceFolderProcessing(CommandLineOptions commandLineOptions)
        {
            this._commandLineOptions = commandLineOptions;
        }

        public async Task<bool> Run()
        {
            Write($"scanning {_commandLineOptions.SourceFolder}");
            List<string> paths = await DirSearch(_commandLineOptions.SourceFolder!).ConfigureAwait(false);

            var result = _commandLineOptions.CreateZipFile ?
                await CreateZipArchive(paths).ConfigureAwait(false) :
                await CreateArchiveCopies(paths).ConfigureAwait(false);

            return true;
        }

        private Task<string> CheckAndCreateTargetPath()
        {
            string? archiveTargetFolder = _commandLineOptions.TargetFolder;

            DateTime dateTime = DateTime.Now;

            bool targetExists = Directory.Exists(archiveTargetFolder);

            Write($"target path exists:\t {targetExists}");

            if (string.IsNullOrWhiteSpace(archiveTargetFolder))
            {
                archiveTargetFolder = string.Join("", _commandLineOptions?.SourceFolder, "_archive");
            }

            if (targetExists)
            {
                archiveTargetFolder = string.Join("", _commandLineOptions?.TargetFolder, "_archive");

                if (Directory.Exists(archiveTargetFolder))
                {
                    archiveTargetFolder = string.Join("", _commandLineOptions?.TargetFolder, DateTime.Now.Ticks);
                }

                Write($"target path already exists, copying archive to {archiveTargetFolder}");
            }

            if (_commandLineOptions?.DateExcluded == false)
            {
                archiveTargetFolder = string.Join("", archiveTargetFolder, $"_{dateTime.Year}{dateTime.Month:00}{dateTime.Day:00}_{dateTime.Hour:00}{dateTime.Minute:00}{dateTime.Second:00}");

                Write($"adding datetime to target path, new target path is: {archiveTargetFolder}");
            }

            Write($"creating target folder:\t {archiveTargetFolder}");

            if (_commandLineOptions?.CreateZipFile == true)
            {
                return Task.FromResult(archiveTargetFolder);
            }

            try
            {
                var result = Directory.CreateDirectory(archiveTargetFolder);

                Write($"{result.FullName} created on {dateTime}");
            }
            catch (System.IO.IOException ex)
            {
                Write($"an error occured:\t {ex.Message}");

                Environment.Exit(1);
            }

            return Task.FromResult(archiveTargetFolder);
        }

        private async Task<bool> CreateArchiveCopies(List<string> paths)
        {
            string archiveTargetFolder = await CheckAndCreateTargetPath().ConfigureAwait(false);

            Write($"\ncopying {paths.Count} file(s) to {archiveTargetFolder}");

            string working = "..";
            int counter = 0;
            DateTime dateTime = DateTime.Now;

            foreach (string filename in paths)
            {
                counter++;

                CreateFileAndFolderCopy(archiveTargetFolder, filename);

                if (_stepSize(counter))
                {
                    Write(_writeStep(counter, paths.Count, dateTime));

                    continue;
                }

                Console.Write(working);
            }

            Write($"\ncopied {_writeSuccess(counter, paths.Count, archiveTargetFolder, dateTime)}");

            return false;
        }

        private void CreateFileAndFolderCopy(string archiveTargetFolder, string filename)
        {
            FileInfo f = new FileInfo(filename);

            string dir = f.DirectoryName!;

            string targetDir = dir.Replace(_commandLineOptions.SourceFolder!, archiveTargetFolder, StringComparison.Ordinal);

            string targetpath = filename.Replace(_commandLineOptions.SourceFolder!, archiveTargetFolder, StringComparison.Ordinal);

            Directory.CreateDirectory(targetDir);

            File.Copy(filename, targetpath); // hinweis: wenn die dateien bereits existieren, bricht copy ab.
        }

        private async Task<bool> CreateZipArchive(List<string> paths)
        {
            string archiveTargetFolder = await CheckAndCreateTargetPath().ConfigureAwait(false);

            string zipArchive = string.Join('.', archiveTargetFolder.Remove(archiveTargetFolder.Length - 1, 1), "zip");

            Write($"\ncreating zip archive {zipArchive}");

            string working = "..";
            int counter = 0;
            DateTime dateTime = DateTime.Now;

            using (ZipArchive archive = ZipFile.Open(zipArchive, ZipArchiveMode.Create))
            {
                foreach (string file in paths)
                {
                    counter++;

                    CreateZipEntry(archive, file);

                    if (_stepSize(counter))
                    {
                        Write(_writeStep(counter, paths.Count, dateTime));

                        continue;
                    }

                    Console.Write(working);
                }

                Write($"\narchived {_writeSuccess(counter, paths.Count, archiveTargetFolder, dateTime)}");
            }

            return false;
        }

        private void CreateZipEntry(ZipArchive archive, string file)
        {
            FileInfo f = new FileInfo(file);

            string zipFolderStructurePath = f.DirectoryName!.Replace(_commandLineOptions.SourceFolder! + "\\", "", StringComparison.Ordinal);

            string zipFilePath = string.Concat(zipFolderStructurePath.Replace("\\", "/", StringComparison.Ordinal), "/", f.Name);

            _ = archive.CreateEntryFromFile(
                file,
                zipFilePath,
                CompressionLevel.Optimal);
        }

        private async Task<List<string>> DirSearch(string sDir)
        {
            List<string> files = new List<string>();

            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    var skip = IgnoreThisFile(f);

                    if (skip)
                    {
                        continue;
                    }

                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    var skip = IgnoreThisFolder(d);

                    if (skip)
                    {
                        continue;
                    }

                    files.AddRange(await DirSearch(d).ConfigureAwait(false));
                }
            }
            catch (System.IO.IOException excpt)
            {
                Write(excpt.Message);
            }
            catch (System.InvalidOperationException excpt)
            {
                Write(excpt.Message);
            }

            return files;
        }

        private bool IgnoreThisFile(string filepath)
        {
            FileInfo fileInfo = new FileInfo(filepath);

            var fileName = fileInfo.Name;
            var dirName = fileInfo.Directory?.Name;

            // für archiv folgende Dateien nicht kopieren, je nach option
            // .gitattributes
            // .editorconfig
            // FOLDERNAME.sln
            // FOLDERNAME.csproj
            // FOLDERNAME.csproj.user
            // appsettings.Development.json
            // appsettings.json
            // AssemblyInfo.cs

            return (
                (fileName.Equals($".gitattributes", StringComparison.Ordinal) && _commandLineOptions.GitExcluded == false)
                ||
                (fileName.Equals($".editorconfig", StringComparison.Ordinal)
                || fileName.Equals($"{dirName}.csproj", StringComparison.Ordinal)
                || fileName.Equals($"{dirName}.csproj.user", StringComparison.Ordinal)
                || fileName.Equals($"{dirName}.sln", StringComparison.Ordinal)
                || fileName.Equals($"appsettings.Development.json", StringComparison.Ordinal)
                || fileName.Equals($"appsettings.json", StringComparison.Ordinal)
                || fileName.Equals($"AssemblyInfo.cs", StringComparison.Ordinal)
                )
                && _commandLineOptions.VsExcluded == false);
        }

        private bool IgnoreThisFolder(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            var dirName = directoryInfo.Name;

            // ordner je nach option prüfen auf \bin \obj \.vs \.git
            // unterhalb nicht weiter suchen für ignore, ggf. für delete, falls clean feature eingebaut wird

            return (
                (dirName.Equals("bin", StringComparison.Ordinal) && _commandLineOptions.BinExcluded == false) ||
                (dirName.Equals("obj", StringComparison.Ordinal) && _commandLineOptions.ObjExcluded == false) ||
                (dirName.Equals(".git", StringComparison.Ordinal) && _commandLineOptions.GitExcluded == false) ||
                (dirName.Equals(".vs", StringComparison.Ordinal) && _commandLineOptions.VsExcluded == false)
                );
        }
    }
}
