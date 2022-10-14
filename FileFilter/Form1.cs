using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileFilter
{
    public partial class Form1 : Form
    {
        private const string INITIAL_FILE_NAME = @"C:\";
        private FilterConfigurationForm _filterConfiguration;
        private ListBox.ObjectCollection PatternsObjectCollection => _filterConfiguration.PatternsObjectCollection;
        public Form1()
        {
            InitializeComponent();
            InitializeFileDialog();

            _filterConfiguration = new FilterConfigurationForm();
            fileNameLabel.Text = INITIAL_FILE_NAME;
        }

        private void InitializeFileDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = INITIAL_FILE_NAME;
            openFileDialog.Title = "Choose a file to filter";
            openFileDialog.FileOk += (sender, a) =>
            {
                string name = openFileDialog.FileName;
                fileNameLabel.Text = name;

                FillFileContent();
            };
        }

        private void FillFileContent()
        {
            fileContentTextBox.ForeColor = Color.Black;

            ReadFile();
        }

        private async void ReadFile()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileNameLabel.Text))
                    {
                        string pattern = CreatePattern();
                        Regex regex = new (pattern);
                        string fileContent = string.Empty;
                        string? line = string.Empty;
                        int num = 0;

                        if (pattern != string.Empty)
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (regex.IsMatch(line))
                                {
                                    fileContent += string.Format("{0}. {1}{2}", num++, line, Environment.NewLine);
                                }
                            }
                        }
                        else
                        {
                            while((line = reader.ReadLine()) != null)
                            {
                                
                                fileContent += string.Format("{0}. {1}{2}", num++, line, Environment.NewLine);
                            }
                        }

                        Invoke(() =>
                        {
                            fileContentTextBox.Text = fileContent;
                        });
                    }
                }
                catch (Exception ex)
                {
                    fileContent.ForeColor = Color.Red;
                    fileContent.Text = ex.Message;
                }
            });
        }

        private string CreatePattern()
        {
            var patterns = ReadPatterns();

            return string.Join('|', patterns);
        }

        private IEnumerable<string> ReadPatterns()
        {
            if (PatternsObjectCollection is null) yield return string.Empty;
            const string regexPattern = @"^(?=.* {0}).*";

            foreach (var pattern in PatternsObjectCollection!)
            {
                yield return string.Format(regexPattern, pattern?.ToString()) ?? String.Empty;
            }
        }

        private void openFileExplorerButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void configureFilterButton_Click(object sender, EventArgs e)
        {
            _filterConfiguration = new FilterConfigurationForm();
            _filterConfiguration.patternsListBox.Items.AddRange(PatternsObjectCollection);
            _filterConfiguration.Show();
        }
    }
}