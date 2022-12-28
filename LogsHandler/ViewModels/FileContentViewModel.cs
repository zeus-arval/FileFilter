using LogsHandler.Aids.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LogsHandler.MVVM
{
    public class FileContentViewModel : NotifiableViewModel
    {
        public FileContentModel FileContentModel { get; set; }

        public ObservableCollection<FileContentFilteredLine> FilteredContent
        {
            get => FileContentModel.FilteredContent;
            set
            {
                FileContentModel.FilteredContent = value;
                OnPropertyChanged(nameof(FilteredContent));
            }
        }

        public event EventHandler FileteredLinesAreUpdated;
        public FileContentViewModel(FileReader fileReader)
        {
            FileContentModel = new FileContentModel(fileReader);

            FilteredContent = new ObservableCollection<FileContentFilteredLine>();
        }
    }
}
