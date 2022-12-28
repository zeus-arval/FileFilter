using FileFilter.Highlights;
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
    public partial class HighlightsConfigurationForm : Form
    {
        internal HighlightModel[] HighlightedWords { get; private set; }

        public HighlightsConfigurationForm()
        {
            InitializeComponent();
            InitializeColorDialogs();

            HighlightedWords = Array.Empty<HighlightModel>();
        }

        private void InitializeColorDialogs()
        {
            foregroundColorDialog.FullOpen = true;
            foregroundColorDialog.Color = Color.Black;

            backgroundColorDialog.FullOpen = true;
            backgroundColorDialog.Color = Color.Gray;
        }

        private void addHilghlightButton_Click(object sender, EventArgs e)
        {
            
        }


        private void addHighlightButton_Click_1(object sender, EventArgs e)
        {
            if (highlightingWordTextBox.Text != string.Empty)
            {
                Color foregroungColor = foregroundColorDialog.Color;
                Color backgroundColor = backgroundColorDialog.Color;

                highlightingWordsListView.Items.Add(highlightingWordTextBox.Text);
                var item = highlightingWordsListView.Items[highlightingWordsListView.Items.Count - 1];
                item.BackColor = backgroundColor;
                item.ForeColor = foregroungColor;
            }
        }

        private void openBackgroundColorDialogButton_Click(object sender, EventArgs e)
        {
            backgroundColorDialog.ShowDialog();
        }
        private void openColorDialogButton_Click(object sender, EventArgs e)
        {
            foregroundColorDialog.ShowDialog();
        }
    }
}
