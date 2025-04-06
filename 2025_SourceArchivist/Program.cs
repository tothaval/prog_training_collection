using CommandLine;

namespace SourceArchivist
{
    internal class Program
    {
        //        SourceArchivist: zur Entfernung des obj und optional bin folders
        //        aus einem vs Projekt, sowie der anschließenden Erstellung einer Kopie,
        //        sowie verzippung (und Transfer an einen backupserver)
        //
        //      TODO  Argumente -c clean -> nur bin und obj löschen, keine kopie erstellen

        //      -s String -> kopie wie übergebenen String nennen
        //      -r String -> rechte des Ordners festlegen(read, write and read)

        static readonly Action<string> Write = Console.WriteLine;

        static CommandLineOptions? s_CliOptionsDto;

        static void Main(string[] args)
        {
            Write("\nProcessing your input...\n");

            Parser.Default.ParseArguments<CommandLineOptions>(args)
                    .WithParsed<CommandLineOptions>(o =>
                    {
                        s_CliOptionsDto = o;
                        // ggf. CreateZipFile umgekehrt nutzen, also z deaktiviert das feature
                    });

            Write($"args:\t\t\t {string.Join(" ", args)}");

            if (args.Length == 0)
            {
                s_CliOptionsDto = new CommandLineOptions()
                {
                    BinExcluded = false,
                    ObjExcluded = false,
                    DateExcluded = false,
                    GitExcluded = false,
                    VsExcluded = false,
                    CleanSourceFolder = false,
                    CreateZipFile = false, // ggf. standard auf true setzen und per z arg deaktivieren
                };
            }

            if (string.IsNullOrWhiteSpace(s_CliOptionsDto!.SourceFolder))
            {
                s_CliOptionsDto.SourceFolder = Environment.CurrentDirectory;
            }

            Write($"source folder:\t\t {s_CliOptionsDto?.SourceFolder}");

            Write($"archive target:\t\t {s_CliOptionsDto?.TargetFolder ?? "default, source directory"}");

            Write($"clean source:\t\t {s_CliOptionsDto?.CleanSourceFolder}");

            Write($"create zip:\t\t {s_CliOptionsDto?.CreateZipFile}");

            Write($"exclude date:\t\t {s_CliOptionsDto?.DateExcluded}");

            Write($"exclude \\bin:\t\t {s_CliOptionsDto?.BinExcluded}");

            Write($"exclude \\obj:\t\t {s_CliOptionsDto?.ObjExcluded}");

            Write($"exclude git:\t\t {s_CliOptionsDto?.GitExcluded}");

            Write($"exclude VS:\t\t {s_CliOptionsDto?.VsExcluded}");

            Task.Run(CheckSourceFolderTerminateOnFail);

            if (string.IsNullOrWhiteSpace(s_CliOptionsDto?.TargetFolder))
            {
                Write($"target path exists:\t {PathExists(s_CliOptionsDto?.SourceFolder)}");
            }

            Task.WaitAny([RunSourceFolderProcessing()]);
        }

        private static async Task<bool> RunSourceFolderProcessing()
        {
            SourceFolderProcessing folderProcessing = new SourceFolderProcessing(s_CliOptionsDto!);

            var result = await folderProcessing.Run().ConfigureAwait(false);

            return result;
        }

        private static bool PathExists(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            return Directory.Exists(path);
        }

        private static Task CheckSourceFolderTerminateOnFail()
        {
            bool sourceExists = PathExists(s_CliOptionsDto?.SourceFolder);

            Write($"source path exists:\t {sourceExists}");

            if (!sourceExists)
            {
                Write($"source path {s_CliOptionsDto?.SourceFolder} does not exist. application closes.");

                Environment.Exit(1);
            }

            return Task.CompletedTask;
        }
    }
}
