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
        public ListBox.ObjectCollection PatternsObjectCollection => patternsListBox.Items;
        public FilterConfigurationForm()
        {
            InitializeComponent();
        }

        private void addLinePatternButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(linePatternTextBox.Text)) return;

            var pattern = linePatternTextBox.Text;
            patternsListBox.Items.Add(pattern);
            linePatternTextBox.Clear();
        }
    }
}
