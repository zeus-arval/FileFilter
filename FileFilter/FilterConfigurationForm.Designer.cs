namespace FileFilter
{
    partial class FilterConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addLinePatternButton = new System.Windows.Forms.Button();
            this.linePatternTextBox = new System.Windows.Forms.TextBox();
            this.patternsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addLinePatternButton
            // 
            this.addLinePatternButton.Location = new System.Drawing.Point(14, 16);
            this.addLinePatternButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addLinePatternButton.Name = "addLinePatternButton";
            this.addLinePatternButton.Size = new System.Drawing.Size(129, 31);
            this.addLinePatternButton.TabIndex = 0;
            this.addLinePatternButton.Text = "Add Line Pattern";
            this.addLinePatternButton.UseVisualStyleBackColor = true;
            this.addLinePatternButton.Click += new System.EventHandler(this.addLinePatternButton_Click);
            // 
            // linePatternTextBox
            // 
            this.linePatternTextBox.Location = new System.Drawing.Point(18, 67);
            this.linePatternTextBox.Name = "linePatternTextBox";
            this.linePatternTextBox.Size = new System.Drawing.Size(125, 27);
            this.linePatternTextBox.TabIndex = 2;
            // 
            // patternsListBox
            // 
            this.patternsListBox.FormattingEnabled = true;
            this.patternsListBox.ItemHeight = 20;
            this.patternsListBox.Location = new System.Drawing.Point(173, 12);
            this.patternsListBox.Name = "patternsListBox";
            this.patternsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.patternsListBox.Size = new System.Drawing.Size(412, 264);
            this.patternsListBox.TabIndex = 3;
            // 
            // FilterConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 297);
            this.Controls.Add(this.patternsListBox);
            this.Controls.Add(this.linePatternTextBox);
            this.Controls.Add(this.addLinePatternButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(615, 344);
            this.MinimumSize = new System.Drawing.Size(615, 344);
            this.Name = "FilterConfigurationForm";
            this.Text = "FilterConfigurationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addLinePatternButton;
        private TextBox linePatternTextBox;
        internal ListBox patternsListBox;
    }
}