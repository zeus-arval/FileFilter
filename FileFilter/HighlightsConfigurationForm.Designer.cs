namespace FileFilter
{
    partial class HighlightsConfigurationForm
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
            this.addHighlightButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.foregroundComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foregroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.openForegroundColorDialogButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundComboBox = new System.Windows.Forms.ComboBox();
            this.openBackgroundColorDialogButton = new System.Windows.Forms.Button();
            this.highlightingWordTextLabel = new System.Windows.Forms.Label();
            this.highlightingWordTextBox = new System.Windows.Forms.TextBox();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.highlightingWordsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addHighlightButton
            // 
            this.addHighlightButton.Location = new System.Drawing.Point(14, 365);
            this.addHighlightButton.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.addHighlightButton.Name = "addHighlightButton";
            this.addHighlightButton.Size = new System.Drawing.Size(85, 37);
            this.addHighlightButton.TabIndex = 1;
            this.addHighlightButton.Text = "Add ";
            this.addHighlightButton.UseVisualStyleBackColor = true;
            this.addHighlightButton.Click += new System.EventHandler(this.addHighlightButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(121, 365);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 37);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(229, 365);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(85, 37);
            this.moveUpButton.TabIndex = 3;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(336, 365);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(91, 37);
            this.moveDownButton.TabIndex = 4;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            // 
            // foregroundComboBox
            // 
            this.foregroundComboBox.FormattingEnabled = true;
            this.foregroundComboBox.Items.AddRange(new object[] {
            "Grey1",
            "Grey2",
            "Grey3",
            "Grey4",
            "Cyan",
            "Yellow"});
            this.foregroundComboBox.Location = new System.Drawing.Point(14, 433);
            this.foregroundComboBox.Name = "foregroundComboBox";
            this.foregroundComboBox.Size = new System.Drawing.Size(151, 28);
            this.foregroundComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Foreground Color:";
            // 
            // openForegroundColorDialogButton
            // 
            this.openForegroundColorDialogButton.BackColor = System.Drawing.SystemColors.Control;
            this.openForegroundColorDialogButton.BackgroundImage = global::FileFilter.Properties.Resources.colorsIcon;
            this.openForegroundColorDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openForegroundColorDialogButton.Location = new System.Drawing.Point(171, 430);
            this.openForegroundColorDialogButton.Name = "openForegroundColorDialogButton";
            this.openForegroundColorDialogButton.Size = new System.Drawing.Size(33, 33);
            this.openForegroundColorDialogButton.TabIndex = 7;
            this.openForegroundColorDialogButton.UseVisualStyleBackColor = false;
            this.openForegroundColorDialogButton.Click += new System.EventHandler(this.openColorDialogButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background Color:";
            // 
            // backgroundComboBox
            // 
            this.backgroundComboBox.FormattingEnabled = true;
            this.backgroundComboBox.Items.AddRange(new object[] {
            "Grey1",
            "Grey2",
            "Grey3",
            "Grey4",
            "Cyan",
            "Yellow"});
            this.backgroundComboBox.Location = new System.Drawing.Point(237, 433);
            this.backgroundComboBox.Name = "backgroundComboBox";
            this.backgroundComboBox.Size = new System.Drawing.Size(151, 28);
            this.backgroundComboBox.TabIndex = 9;
            // 
            // openBackgroundColorDialogButton
            // 
            this.openBackgroundColorDialogButton.BackColor = System.Drawing.SystemColors.Control;
            this.openBackgroundColorDialogButton.BackgroundImage = global::FileFilter.Properties.Resources.colorsIcon;
            this.openBackgroundColorDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openBackgroundColorDialogButton.Location = new System.Drawing.Point(394, 430);
            this.openBackgroundColorDialogButton.Name = "openBackgroundColorDialogButton";
            this.openBackgroundColorDialogButton.Size = new System.Drawing.Size(33, 33);
            this.openBackgroundColorDialogButton.TabIndex = 10;
            this.openBackgroundColorDialogButton.UseVisualStyleBackColor = false;
            this.openBackgroundColorDialogButton.Click += new System.EventHandler(this.openBackgroundColorDialogButton_Click);
            // 
            // highlightingWordTextLabel
            // 
            this.highlightingWordTextLabel.AutoSize = true;
            this.highlightingWordTextLabel.Location = new System.Drawing.Point(14, 479);
            this.highlightingWordTextLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.highlightingWordTextLabel.Name = "highlightingWordTextLabel";
            this.highlightingWordTextLabel.Size = new System.Drawing.Size(39, 20);
            this.highlightingWordTextLabel.TabIndex = 11;
            this.highlightingWordTextLabel.Text = "Text:";
            // 
            // highlightingWordTextBox
            // 
            this.highlightingWordTextBox.Location = new System.Drawing.Point(14, 502);
            this.highlightingWordTextBox.Name = "highlightingWordTextBox";
            this.highlightingWordTextBox.Size = new System.Drawing.Size(413, 27);
            this.highlightingWordTextBox.TabIndex = 12;
            // 
            // highlightingWordsListView
            // 
            this.highlightingWordsListView.FullRowSelect = true;
            this.highlightingWordsListView.GridLines = true;
            this.highlightingWordsListView.Location = new System.Drawing.Point(12, 12);
            this.highlightingWordsListView.Name = "highlightingWordsListView";
            this.highlightingWordsListView.Size = new System.Drawing.Size(417, 347);
            this.highlightingWordsListView.TabIndex = 13;
            this.highlightingWordsListView.UseCompatibleStateImageBehavior = false;
            this.highlightingWordsListView.View = System.Windows.Forms.View.List;
            // 
            // HighlightsConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 583);
            this.Controls.Add(this.highlightingWordsListView);
            this.Controls.Add(this.highlightingWordTextBox);
            this.Controls.Add(this.highlightingWordTextLabel);
            this.Controls.Add(this.openBackgroundColorDialogButton);
            this.Controls.Add(this.backgroundComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openForegroundColorDialogButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foregroundComboBox);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addHighlightButton);
            this.Name = "HighlightsConfigurationForm";
            this.Text = "Highlights Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addHighlightButton;
        private Button deleteButton;
        private Button moveUpButton;
        private Button moveDownButton;
        private ComboBox foregroundComboBox;
        private Label label1;
        private ColorDialog foregroundColorDialog;
        private Button openForegroundColorDialogButton;
        private Label label2;
        private ComboBox backgroundComboBox;
        private Button openBackgroundColorDialogButton;
        private Label highlightingWordTextLabel;
        private TextBox highlightingWordTextBox;
        private ColorDialog backgroundColorDialog;
        private ListView highlightingWordsListView;
    }
}