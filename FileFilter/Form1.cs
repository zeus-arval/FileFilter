using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileFilter
{
    public partial class Form1 : Form
    {
        private const string INITIAL_FILE_NAME = @"C:\";

        private FilterConfigurationForm _filterConfigurationForm;
        private ListBox.ObjectCollection PatternsObjectCollection { get; set; }
        public List<string> FileContent { get; set; }


        public Form1()
        {
            InitializeComponent();
            InitializeFileDialog();
            InitializeFilterConfigurationForm();

            PatternsObjectCollection = new ListBox.ObjectCollection(_filterConfigurationForm!.patternsListBox);

            fileNameLabel.Text = INITIAL_FILE_NAME;
            FileContent = new List<string>();
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
            fileContentListBox.ForeColor = Color.Black;

            ReadFile();
        }

        private async void ReadFile()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (FileStream file = new FileStream(fileNameLabel.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            FileContent = new();
                            FilterContent((loopCallback) =>
                            {
                                string pattern = CreatePattern();
                                Regex regex = new(pattern);
                                string? line = string.Empty;

                                if (pattern != string.Empty)
                                {
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        loopCallback(line);
                                    }
                                }
                                else
                                {
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        FileContent.Add(string.Format("{0}{1}", line, Environment.NewLine));
                                    }
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Invoke(() =>
                    {
                        fileContentListBox.ForeColor = Color.Red;
                        fileContentListBox.Items.Add(ex.Message);
                    });
                }
            });
        }

        private void FilterContent(Action<Action<string>> loopCallback)
        {
            string pattern = CreatePattern();
            Regex regex = new(pattern);
            string? line = string.Empty;

            loopCallback(line =>
            {
                if (regex.IsMatch(line))
                {
                    FileContent.Add(string.Format("{0}{1}", line, Environment.NewLine));
                }
            });

            Invoke(() =>
            {
                var collection = new ListBox.ObjectCollection(fileContentListBox, FileContent.ToArray());
                fileContentListBox.Items.Clear();
                fileContentListBox.Items.AddRange(collection);
            });
        }

        private string CreatePattern()
        {
            var patterns = ReadPatterns();
            if (patterns is null) return string.Empty;

            return string.Join('|', patterns);
        }

        private IEnumerable<string> ReadPatterns()
        {
            if (PatternsObjectCollection is null) yield return string.Empty;
            const string regexPattern = @"^(?=.*{0}).*";

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
            InitializeFilterConfigurationForm();
            _filterConfigurationForm.Show();
        }

        private void InitializeFilterConfigurationForm()
        {
            _filterConfigurationForm = new FilterConfigurationForm(PatternsObjectCollection ?? new ListBox.ObjectCollection(new ListBox()));
            _filterConfigurationForm.OnAddedPatternsEvent += (sender, patterns) =>
            {
                PatternsObjectCollection = patterns;
            };

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (FileContent.Count == 0) return;

            List<string> nonFilteredFileContent = FileContent;
            FileContent = new List<string>();
            string pattern = CreatePattern();
            if (pattern is null) return;

            FilterContent((loopCallback) =>
            {
                Regex regex = new(pattern);

                foreach(string line in nonFilteredFileContent)
                {
                    loopCallback(line);
                }
            });
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                fileContentListBox.SelectedItems.Clear();
            }

            return base.ProcessDialogKey(keyData);
        }

        private void fileContentListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                string s = string.Empty;

                foreach(var line in fileContentListBox.SelectedItems)
                {
                    s += line.ToString();
                }

                if (s != string.Empty)
                {
                    Clipboard.SetText(s);
                    fileContentListBox.SelectedItems.Clear();
                }
            }
        }

        private void fileContentListBox_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}