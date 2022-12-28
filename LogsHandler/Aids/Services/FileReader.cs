using LogsHandler.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Net.Http.Headers;

namespace LogsHandler.Aids.Services
{
    public class FileReader
    {
        private string _fileLocation;
        private string[] _validExtensions;

        public event EventHandler<FileContentEventArgs> OnFileRead;

        public FileReader(AppOptions options)
        {
            _fileLocation = string.Empty;
            _validExtensions = options.FILE_EXTENSIONS;
        }

        public void ReadFile(object? sender, FilePathEventArgs e)
        {
            Read(e.FilePath);
        }

        public void Read(string fileLocation)
        {
            IEnumerable<string> fileContentLines;

            if (string.IsNullOrEmpty(fileLocation))
            {
                throw new ArgumentException($"'{nameof(fileLocation)}' cannot be null or empty.", nameof(fileLocation));
            }

            if (File.Exists(fileLocation) == false)
            {
                throw new Exception($"{fileLocation} doesn't exist");
            }

            if (CheckFileExtension(fileLocation) == false)
            {
                throw new Exception($"{fileLocation} has invalid extension");
            }

            _fileLocation = fileLocation;

            fileContentLines = ReadImpl();

            Emit_OnFileRead(fileContentLines, fileLocation);
        }

        private void Emit_OnFileRead(IEnumerable<string> fileContentLines, string fileLocation)
        {
            var handler = OnFileRead;

            if (handler != null)
            {
                FileContentEventArgs args = new FileContentEventArgs(fileContentLines.ToImmutableArray(), fileLocation);
                handler.Invoke(this, args);
            }
        }

        private bool CheckFileExtension(string fileLocation)
        {
            var extensionIsValid = false;
            var extension = Path.GetExtension(fileLocation);

            if (extension == null) return false;

            foreach (var validExtension in _validExtensions)
            {
                extensionIsValid = extension.Equals(validExtension);

                if (extensionIsValid) return true;
            }

            return extensionIsValid;
        }

        private IEnumerable<string> ReadImpl()
        {
            List<string> fileContent = new List<string>();

            using (FileStream fileStream = new FileStream(_fileLocation, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;

                    while ((line = reader.ReadLine()!) != null)
                    {
                        fileContent.Add(line);
                    }

                    if (fileContent.Count == 0)
                    {
                        throw new Exception($"{_fileLocation} is empty");
                    }
                }
            }

            return fileContent;
        }
    }

    public class FileContentEventArgs : EventArgs
    {
        public string FilePath { get; }
        public ImmutableArray<string> ContentLines { get; }
        public FileContentEventArgs(ImmutableArray<string> contentLines, string filePath)
        {
            ContentLines = contentLines;
            FilePath = filePath;
        }
    }
}
