using System.Windows.Controls;

namespace LogsHandler.MVVM
{
    /// <summary>
    /// Interaction logic for ButtonsRowPanelUserControl.xaml
    /// </summary>
    public partial class ButtonsRowPanelUserControl : UserControl
    {
        public RowButtonsViewModel RowButtonsViewModel => (DataContext as RowButtonsViewModel)!;

        public ButtonsRowPanelUserControl()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            RowButtonsViewModel.OpenFileCommand.Execute(null);
        }
    }
}
