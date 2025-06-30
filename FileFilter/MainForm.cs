using FileFilter.Aids;
using System;
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.ListBox;

namespace FileFilter
{
    public partial class MainForm : Form
    {
        private const string INITIAL_FILE_NAME = @"C:\";

        private FilterConfigurationForm _filterConfigurationForm;
        private HighlightsConfigurationForm _highlightsConfigurationForm;
        private ListBox.ObjectCollection PatternsObjectCollection { get; set; }
        public List<string> FileContent { get; set; }
        public List<string> FilteredContent { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeFileDialog();
            InitializeFilterConfigurationForm();
            InitializeHighlitingForm();

            PatternsObjectCollection = new ListBox.ObjectCollection(_filterConfigurationForm!.patternsListBox);

            fileNameLabel.Text = INITIAL_FILE_NAME;
            FileContent = new List<string>();
            FilteredContent = new List<string>();
        }

        private void InitializeHighlitingForm()
        {
            _highlightsConfigurationForm = new HighlightsConfigurationForm();
        }

        private void InitializeFileDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = INITIAL_FILE_NAME;
            openFileDialog.Title = "Choose a file to filter";
            openFileDialog.FileOk += async (sender, a) =>
            {
                string name = openFileDialog.FileName;
                fileNameLabel.Text = name;

                await FillFileContent();
            };
        }

        private async Task FillFileContent()
        {
            linesListBox.ForeColor = Color.Black;

            await ReadFile();
            linesListBox.BeginUpdate();
            linesListBox.Items.Clear();
            (FilteredContent.Count > 0 ? FilteredContent : FileContent).ForEach(x => linesListBox.Items.Add(x));
            linesListBox.EndUpdate();
            //var listBoxCollection = new ListBox.ObjectCollection(linesListBox);
            //listBoxCollection.Clear();
            //listBoxCollection.AddRange((FilteredContent.Count > 0 ? FilteredContent : FileContent).ToArray());
            //linesListBox.Items.AddRange(listBoxCollection);
        }

        private async Task ReadFile()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (FileStream file = new FileStream(fileNameLabel.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            Safety.Run(() =>
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
                                            FileContent.Add(string.Format("{0}{1}", line, Environment.NewLine));
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
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Invoke(() =>
                    {
                        linesListBox.ForeColor = Color.Red;
                        linesListBox.Items.Add(ex.Message);
                    });
                }
            });
        }

        private void FilterContent(Action<Action<string>> loopCallback)
        {
            string pattern = CreatePattern();
            Regex regex = new(pattern);
            string? line = string.Empty;
            FilteredContent = new List<string>();

            loopCallback(line =>
            {
                if (regex.IsMatch(line))
                {
                    FilteredContent.Add(string.Format("{0}{1}", line, Environment.NewLine));
                }
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
            //InitializeFilterConfigurationForm();
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
            Task.Run(() =>
            {
                Safety.Run(() =>
                {
                    if (FileContent.Count == 0) return;

                    List<string> nonFilteredFileContent = FileContent;
                    FilteredContent = new List<string>();
                    string pattern = CreatePattern();
                    if (pattern is null) return;

                    FilterContent((loopCallback) =>
                    {
                        Regex regex = new(pattern);

                        foreach (string line in nonFilteredFileContent)
                        {
                            loopCallback(line);
                        }
                    });

                    Invoke(() => 
                    {
                        linesListBox.BeginUpdate();
                        linesListBox.Items.Clear();
                        (FilteredContent.Count > 0 ? FilteredContent : FileContent).ForEach(x => linesListBox.Items.Add(x));
                        linesListBox.EndUpdate();
                    });
                });
            });
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                linesListBox.SelectedItems.Clear();
            }

            return base.ProcessDialogKey(keyData);
        }

        private void linesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Invoke(() =>
                {
                    string s = string.Empty;
                    var selected = new SelectedObjectCollection(linesListBox);

                    foreach (var line in selected)
                    {
                        s += line.ToString();
                    }

                    if (s != string.Empty)
                    {
                        Clipboard.SetText(s);
                        linesListBox.ClearSelected();
                    }
                });
            }
        }

        private void removeFiltersButton_Click(object sender, EventArgs e)
        {
            Safety.Run(() =>
            {
                if (FileContent.Count == 0) return;

                linesListBox.BeginUpdate();
                (FileContent).ForEach(x => linesListBox.Items.Add(x));
                linesListBox.EndUpdate();
            });
        }

        private void highlightsButton_Click(object sender, EventArgs e)
        {
            _highlightsConfigurationForm.Visible = true;
        }
    }
}