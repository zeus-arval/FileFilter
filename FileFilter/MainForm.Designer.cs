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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Anna");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Artur");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileExplorerButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.configureFilterButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.removeFiltersButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.highlightsButton = new System.Windows.Forms.Button();
            this.fileContentListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFileExplorerButton
            // 
            this.openFileExplorerButton.Location = new System.Drawing.Point(14, 21);
            this.openFileExplorerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openFileExplorerButton.MaximumSize = new System.Drawing.Size(145, 31);
            this.openFileExplorerButton.MinimumSize = new System.Drawing.Size(145, 31);
            this.openFileExplorerButton.Name = "openFileExplorerButton";
            this.openFileExplorerButton.Size = new System.Drawing.Size(145, 31);
            this.openFileExplorerButton.TabIndex = 0;
            this.openFileExplorerButton.Text = "Open File Exporer";
            this.openFileExplorerButton.UseVisualStyleBackColor = true;
            this.openFileExplorerButton.Click += new System.EventHandler(this.openFileExplorerButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(165, 27);
            this.fileNameLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(150, 20);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "C:/Program files/";
            // 
            // configureFilterButton
            // 
            this.configureFilterButton.Location = new System.Drawing.Point(592, 21);
            this.configureFilterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.configureFilterButton.Name = "configureFilterButton";
            this.configureFilterButton.Size = new System.Drawing.Size(123, 31);
            this.configureFilterButton.TabIndex = 3;
            this.configureFilterButton.Text = "Configure filter";
            this.configureFilterButton.UseVisualStyleBackColor = true;
            this.configureFilterButton.Click += new System.EventHandler(this.configureFilterButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(722, 21);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(53, 31);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // removeFiltersButton
            // 
            this.removeFiltersButton.Location = new System.Drawing.Point(782, 21);
            this.removeFiltersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeFiltersButton.Name = "removeFiltersButton";
            this.removeFiltersButton.Size = new System.Drawing.Size(119, 31);
            this.removeFiltersButton.TabIndex = 6;
            this.removeFiltersButton.Text = "Remove Filters";
            this.removeFiltersButton.UseVisualStyleBackColor = true;
            this.removeFiltersButton.Click += new System.EventHandler(this.removeFiltersButton_Click);
            // 
            // highlightsButton
            // 
            this.highlightsButton.Location = new System.Drawing.Point(477, 21);
            this.highlightsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.highlightsButton.Name = "highlightsButton";
            this.highlightsButton.Size = new System.Drawing.Size(109, 31);
            this.highlightsButton.TabIndex = 7;
            this.highlightsButton.Text = "Highlighting";
            this.highlightsButton.UseVisualStyleBackColor = true;
            this.highlightsButton.Click += new System.EventHandler(this.highlightsButton_Click);
            // 
            // fileContentListView
            // 
            this.fileContentListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fileContentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentListView.AutoArrange = false;
            this.fileContentListView.FullRowSelect = true;
            this.fileContentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.fileContentListView.Location = new System.Drawing.Point(15, 72);
            this.fileContentListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileContentListView.Name = "fileContentListView";
            this.fileContentListView.Size = new System.Drawing.Size(885, 511);
            this.fileContentListView.TabIndex = 8;
            this.fileContentListView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.fileContentListView);
            this.Controls.Add(this.highlightsButton);
            this.Controls.Add(this.removeFiltersButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.configureFilterButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openFileExplorerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "FilterProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ListView fileContentListView;
    }
}