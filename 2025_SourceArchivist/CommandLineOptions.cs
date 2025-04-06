using CommandLine;

namespace SourceArchivist
{
    internal class CommandLineOptions
    {
        [Option('s', "source", Required = false, HelpText = "The folder path that should be archived.")]
        public string? SourceFolder { get; set; }

        [Option('t', "target", Required = false, HelpText = "The target storage folder path. I left empty, a default path will be created.")]
        public string? TargetFolder { get; set; }

        [Option('d', "date", Required = false, Default = false, HelpText = "Append current date time to target folder.")]
        public bool DateExcluded { get; set; }

        [Option('c', "clean", Required = false, Default = false, HelpText = "Cleans the source folder according to configuration.")]
        public bool CleanSourceFolder { get; set; }

        [Option('z', "zip", Required = false, Default = false, HelpText = "Creates a zip archive using target folder name as filename.")]
        public bool CreateZipFile { get; set; }

        [Option('b', "bin", Required = false, Default = false, HelpText = "Excludes the bin folder from processing.")]
        public bool BinExcluded { get; set; }

        [Option('o', "obj", Required = false, Default = false, HelpText = "Excludes the obj folder from processing.")]
        public bool ObjExcluded { get; set; }

        [Option('g', "git", Required = false, Default = false, HelpText = "Excludes .git folder and .gitattributes file from processing.")]
        public bool GitExcluded { get; set; }

        [Option('v', "vs", Required = false, Default = false, HelpText = "Exclude .vs folder and non-source VS files from processing.")]
        public bool VsExcluded { get; set; }
    }
}
