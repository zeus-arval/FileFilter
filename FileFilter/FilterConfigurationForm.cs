using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter
{
    public partial class FilterConfigurationForm : Form
    {
        public event EventHandler<ListBox.ObjectCollection>? OnAddedPatternsEvent;
        public ListBox.ObjectCollection PatternsObjectCollection => patternsListBox.Items;
        public FilterConfigurationForm()
        {
            InitializeComponent();
        }

        public FilterConfigurationForm(ListBox.ObjectCollection objectCollection) : this()
        {
            if (objectCollection.Count == 0) return;

            patternsListBox.Items.AddRange(objectCollection);
        }

        private void addLinePatternButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(linePatternTextBox.Text)) return;

            var pattern = linePatternTextBox.Text;
            patternsListBox.Items.Add(pattern);
            linePatternTextBox.Clear();
            OnAddedPatternsEvent?.Invoke(this, patternsListBox.Items);
        }

        private void removePatternLinesButton_Click(object sender, EventArgs e)
        {
            if (patternsListBox.SelectedItems.Count != 0)
            {
                var patterns = patternsListBox.SelectedItems;

                for (int i = 0; i < patterns.Count; i++)
                {
                    var pattern = patterns[i];
                    patternsListBox.Items.Remove(pattern);
                }

                OnAddedPatternsEvent?.Invoke(this, patternsListBox.Items);
            }
        }
    }
}
