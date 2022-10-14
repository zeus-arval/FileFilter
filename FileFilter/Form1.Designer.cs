namespace FileFilter
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileExplorerButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileContentTextBox = new System.Windows.Forms.TextBox();
            this.configureFilterButton = new System.Windows.Forms.Button();
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
            // fileContentTextBox
            // 
            this.fileContentTextBox.AcceptsReturn = true;
            this.fileContentTextBox.AcceptsTab = true;
            this.fileContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentTextBox.BackColor = System.Drawing.Color.White;
            this.fileContentTextBox.Location = new System.Drawing.Point(14, 73);
            this.fileContentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileContentTextBox.Multiline = true;
            this.fileContentTextBox.Name = "fileContentTextBox";
            this.fileContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileContentTextBox.Size = new System.Drawing.Size(886, 509);
            this.fileContentTextBox.TabIndex = 2;
            this.fileContentTextBox.WordWrap = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.configureFilterButton);
            this.Controls.Add(this.fileContentTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openFileExplorerButton);
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
        private TextBox fileContent;
        private Button configureFilterButton;
        private TextBox fileContentTextBox;
    }
}