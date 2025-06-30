namespace FileFilter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            openFileDialog = new OpenFileDialog();
            openFileExplorerButton = new Button();
            fileNameLabel = new Label();
            configureFilterButton = new Button();
            filterButton = new Button();
            removeFiltersButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            highlightsButton = new Button();
            linesListBox = new ListBox();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // openFileExplorerButton
            // 
            openFileExplorerButton.Location = new Point(12, 16);
            openFileExplorerButton.MaximumSize = new Size(127, 23);
            openFileExplorerButton.MinimumSize = new Size(127, 23);
            openFileExplorerButton.Name = "openFileExplorerButton";
            openFileExplorerButton.Size = new Size(127, 23);
            openFileExplorerButton.TabIndex = 0;
            openFileExplorerButton.Text = "Open File Exporer";
            openFileExplorerButton.UseVisualStyleBackColor = true;
            openFileExplorerButton.Click += openFileExplorerButton_Click;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(144, 20);
            fileNameLabel.MinimumSize = new Size(131, 0);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(131, 15);
            fileNameLabel.TabIndex = 1;
            fileNameLabel.Text = "C:/Program files/";
            // 
            // configureFilterButton
            // 
            configureFilterButton.Location = new Point(518, 16);
            configureFilterButton.Name = "configureFilterButton";
            configureFilterButton.Size = new Size(108, 23);
            configureFilterButton.TabIndex = 3;
            configureFilterButton.Text = "Configure filter";
            configureFilterButton.UseVisualStyleBackColor = true;
            configureFilterButton.Click += configureFilterButton_Click;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(632, 16);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(46, 23);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // removeFiltersButton
            // 
            removeFiltersButton.Location = new Point(684, 16);
            removeFiltersButton.Name = "removeFiltersButton";
            removeFiltersButton.Size = new Size(104, 23);
            removeFiltersButton.TabIndex = 6;
            removeFiltersButton.Text = "Remove Filters";
            removeFiltersButton.UseVisualStyleBackColor = true;
            removeFiltersButton.Click += removeFiltersButton_Click;
            // 
            // highlightsButton
            // 
            highlightsButton.Location = new Point(417, 16);
            highlightsButton.Name = "highlightsButton";
            highlightsButton.Size = new Size(95, 23);
            highlightsButton.TabIndex = 7;
            highlightsButton.Text = "Highlighting";
            highlightsButton.UseVisualStyleBackColor = true;
            highlightsButton.Click += highlightsButton_Click;
            // 
            // linesListBox
            // 
            linesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linesListBox.FormattingEnabled = true;
            linesListBox.ItemHeight = 15;
            linesListBox.Location = new Point(12, 55);
            linesListBox.Margin = new Padding(10);
            linesListBox.Name = "linesListBox";
            linesListBox.SelectionMode = SelectionMode.MultiExtended;
            linesListBox.Size = new Size(776, 379);
            linesListBox.TabIndex = 8;
            linesListBox.KeyDown += linesListBox_KeyDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linesListBox);
            Controls.Add(highlightsButton);
            Controls.Add(removeFiltersButton);
            Controls.Add(filterButton);
            Controls.Add(configureFilterButton);
            Controls.Add(fileNameLabel);
            Controls.Add(openFileExplorerButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            Text = "FilterProgram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button openFileExplorerButton;
        private Label fileNameLabel;
        private Button configureFilterButton;
        private Button filterButton;
        private Button removeFiltersButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button highlightsButton;
        private ListBox linesListBox;
    }
}