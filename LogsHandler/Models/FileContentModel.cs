using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using LogsHandler.Aids.Services;

namespace LogsHandler.MVVM
{
    public class FileContentModel : BaseUpdatebleModel
    {
        public ImmutableArray<string> FileContentLines { get; private set; }
        public string FilePath { get; private set; }

        private ObservableCollection<FileContentFilteredLine> _filteredContent;
        public ObservableCollection<FileContentFilteredLine> FilteredContent
        {
            get => _filteredContent;
            set
            {
                _filteredContent = value;
                OnPropertyChanged();
                FileteredLinesAreUpdated?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler FileteredLinesAreUpdated;
        public FileContentModel(FileReader fileReader)
        {
            FilePath = string.Empty;
            _filteredContent = new ObservableCollection<FileContentFilteredLine>();
            fileReader.OnFileRead += FileReader_OnFileRead;
        }

        private void FileReader_OnFileRead(object? sender, FileContentEventArgs e)
        {
            FilePath = e.FilePath;
            FileContentLines = e.ContentLines;
            FilteredContent = new ObservableCollection<FileContentFilteredLine>(FileContentLines.Select(x => new FileContentFilteredLine(x)));
        }

        public void FilterLines(string pattern)
        {
            if (pattern == string.Empty)
            {
                FilteredContent = new ObservableCollection<FileContentFilteredLine>(FileContentLines.Select(x => new FileContentFilteredLine(x)));
            }

            //FilteredContent = FileContentLinesFilter.Filter(FileContentLines, pattern);
        }
    }
}
