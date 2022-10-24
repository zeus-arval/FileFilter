﻿namespace FileFilter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileExplorerButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.configureFilterButton = new System.Windows.Forms.Button();
            this.fileContentListBox = new System.Windows.Forms.ListBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFileExplorerButton
            // 
            this.openFileExplorerButton.Location = new System.Drawing.Point(14, 16);
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
            this.fileNameLabel.Location = new System.Drawing.Point(165, 21);
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
            // fileContentListBox
            // 
            this.fileContentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentListBox.FormattingEnabled = true;
            this.fileContentListBox.ItemHeight = 20;
            this.fileContentListBox.Location = new System.Drawing.Point(14, 68);
            this.fileContentListBox.Name = "fileContentListBox";
            this.fileContentListBox.ScrollAlwaysVisible = true;
            this.fileContentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileContentListBox.Size = new System.Drawing.Size(889, 524);
            this.fileContentListBox.TabIndex = 4;
            this.fileContentListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileContentListBox_KeyDown);
            this.fileContentListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileContentListBox_MouseDown);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(737, 21);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(123, 31);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.fileContentListBox);
            this.Controls.Add(this.configureFilterButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openFileExplorerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "FilterProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button openFileExplorerButton;
        private Label fileNameLabel;
        private Button configureFilterButton;
        private ListBox fileContentListBox;
        private Button filterButton;
    }
}