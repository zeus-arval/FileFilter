using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogsHandler.MVVM
{
    /// <summary>
    /// Interaction logic for FileContentUserControl.xaml
    /// </summary>
    public partial class FileContentUserControl : UserControl
    {
        //public ObservableCollection ContentLines => FileContentViewModel.FilteredContent;
        public FileContentViewModel FileContentViewModel => (DataContext as FileContentViewModel)!;

        public FileContentUserControl()
        {
            InitializeComponent();
            Loaded += (sender, args) =>
            {
                //filteredContentItemsControl.ItemsSource
                FileContentViewModel.FileContentModel.FileteredLinesAreUpdated += FileContentModel_FileteredLinesAreUpdated;
            };
        }

        private void FileContentModel_FileteredLinesAreUpdated(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                filteredContentItemsControl.Items.Refresh();
            });
        }
    }
}
