using LogsHandler.Common;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsHandler.Aids.Services
{
    public class FileHelper
    {
        private readonly string INITIAL_FILE_PATH = @"C:\";
        private const string TITLE = "Choose a file";
        private OpenFileDialog _openFileDialog;
        public event EventHandler<FilePathEventArgs> OnFileChoosen;

        public FileHelper(AppOptions options)
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = INITIAL_FILE_PATH;
            _openFileDialog.Title = TITLE;
            _openFileDialog.FileOk += (sender, args) =>
            {
                string fullPath = _openFileDialog.FileName;

                options.FilePath = fullPath;
                OnFileChoosen?.Invoke(this, new FilePathEventArgs(fullPath));
            };
        }

        public void OpenFileDialog()
        {
            _openFileDialog.ShowDialog();
        }
    }
    
    public class FilePathEventArgs : EventArgs
    {
        public string FilePath { get; init; }
        public FilePathEventArgs(string fullPath)
        {
            FilePath = fullPath;
        }
    }
}
