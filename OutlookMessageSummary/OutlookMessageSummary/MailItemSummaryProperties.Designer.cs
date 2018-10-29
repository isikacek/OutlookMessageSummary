namespace OutlookMessageSummary
{
    partial class MailItemSummaryProperties
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TemplateTextBox = new System.Windows.Forms.TextBox();
            this.ClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.HTTPCheckBox = new System.Windows.Forms.CheckBox();
            this.MsgDialogCheckBox = new System.Windows.Forms.CheckBox();
            this.AppendCheckBox = new System.Windows.Forms.CheckBox();
            this.DLLCheckBox = new System.Windows.Forms.CheckBox();
            this.HTTPHeadersTextBox = new System.Windows.Forms.TextBox();
            this.HTTPURLTextBox = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.AppendButton = new System.Windows.Forms.Button();
            this.AppendLabel = new System.Windows.Forms.Label();
            this.DLLButton = new System.Windows.Forms.Button();
            this.DLLLabel = new System.Windows.Forms.Label();
            this.FileDialogCheckBox = new System.Windows.Forms.CheckBox();
            this.HTTPBodyCheckBox = new System.Windows.Forms.CheckBox();
            this.DLLProcTextBox = new System.Windows.Forms.TextBox();
            this.HTTPVerbTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TemplateTextBox
            // 
            this.TemplateTextBox.AcceptsReturn = true;
            this.TemplateTextBox.AcceptsTab = true;
            this.TemplateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateTextBox.Location = new System.Drawing.Point(5, 3);
            this.TemplateTextBox.Multiline = true;
            this.TemplateTextBox.Name = "TemplateTextBox";
            this.TemplateTextBox.Size = new System.Drawing.Size(330, 20);
            this.TemplateTextBox.TabIndex = 0;
            this.TemplateTextBox.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // ClipboardCheckBox
            // 
            this.ClipboardCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClipboardCheckBox.AutoSize = true;
            this.ClipboardCheckBox.Location = new System.Drawing.Point(5, 29);
            this.ClipboardCheckBox.Name = "ClipboardCheckBox";
            this.ClipboardCheckBox.Size = new System.Drawing.Size(70, 17);
            this.ClipboardCheckBox.TabIndex = 1;
            this.ClipboardCheckBox.Text = "Clipboard";
            this.ClipboardCheckBox.UseVisualStyleBackColor = true;
            this.ClipboardCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // HTTPCheckBox
            // 
            this.HTTPCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HTTPCheckBox.AutoSize = true;
            this.HTTPCheckBox.Location = new System.Drawing.Point(5, 121);
            this.HTTPCheckBox.Name = "HTTPCheckBox";
            this.HTTPCheckBox.Size = new System.Drawing.Size(55, 17);
            this.HTTPCheckBox.TabIndex = 2;
            this.HTTPCheckBox.Text = "HTTP";
            this.HTTPCheckBox.UseVisualStyleBackColor = true;
            this.HTTPCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // MsgDialogCheckBox
            // 
            this.MsgDialogCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MsgDialogCheckBox.AutoSize = true;
            this.MsgDialogCheckBox.Location = new System.Drawing.Point(5, 52);
            this.MsgDialogCheckBox.Name = "MsgDialogCheckBox";
            this.MsgDialogCheckBox.Size = new System.Drawing.Size(100, 17);
            this.MsgDialogCheckBox.TabIndex = 3;
            this.MsgDialogCheckBox.Text = "Message dialog";
            this.MsgDialogCheckBox.UseVisualStyleBackColor = true;
            this.MsgDialogCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // AppendCheckBox
            // 
            this.AppendCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppendCheckBox.AutoSize = true;
            this.AppendCheckBox.Location = new System.Drawing.Point(5, 98);
            this.AppendCheckBox.Name = "AppendCheckBox";
            this.AppendCheckBox.Size = new System.Drawing.Size(78, 17);
            this.AppendCheckBox.TabIndex = 4;
            this.AppendCheckBox.Text = "Append to:";
            this.AppendCheckBox.UseVisualStyleBackColor = true;
            this.AppendCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // DLLCheckBox
            // 
            this.DLLCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DLLCheckBox.AutoSize = true;
            this.DLLCheckBox.Location = new System.Drawing.Point(5, 245);
            this.DLLCheckBox.Name = "DLLCheckBox";
            this.DLLCheckBox.Size = new System.Drawing.Size(66, 17);
            this.DLLCheckBox.TabIndex = 5;
            this.DLLCheckBox.Text = "CallDLL:";
            this.DLLCheckBox.UseVisualStyleBackColor = true;
            this.DLLCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // HTTPHeadersTextBox
            // 
            this.HTTPHeadersTextBox.AcceptsReturn = true;
            this.HTTPHeadersTextBox.AcceptsTab = true;
            this.HTTPHeadersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HTTPHeadersTextBox.Location = new System.Drawing.Point(25, 172);
            this.HTTPHeadersTextBox.Multiline = true;
            this.HTTPHeadersTextBox.Name = "HTTPHeadersTextBox";
            this.HTTPHeadersTextBox.Size = new System.Drawing.Size(310, 67);
            this.HTTPHeadersTextBox.TabIndex = 6;
            this.HTTPHeadersTextBox.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // HTTPURLTextBox
            // 
            this.HTTPURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HTTPURLTextBox.Location = new System.Drawing.Point(67, 146);
            this.HTTPURLTextBox.Name = "HTTPURLTextBox";
            this.HTTPURLTextBox.Size = new System.Drawing.Size(268, 20);
            this.HTTPURLTextBox.TabIndex = 7;
            this.HTTPURLTextBox.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // URLLabel
            // 
            this.URLLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(22, 149);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(32, 13);
            this.URLLabel.TabIndex = 9;
            this.URLLabel.Text = "URL:";
            // 
            // AppendButton
            // 
            this.AppendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AppendButton.Location = new System.Drawing.Point(311, 94);
            this.AppendButton.Name = "AppendButton";
            this.AppendButton.Size = new System.Drawing.Size(24, 23);
            this.AppendButton.TabIndex = 10;
            this.AppendButton.Text = "...";
            this.AppendButton.UseVisualStyleBackColor = true;
            this.AppendButton.Click += new System.EventHandler(this.AppendButton_Click);
            // 
            // AppendLabel
            // 
            this.AppendLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppendLabel.Location = new System.Drawing.Point(82, 94);
            this.AppendLabel.Name = "AppendLabel";
            this.AppendLabel.Size = new System.Drawing.Size(223, 16);
            this.AppendLabel.TabIndex = 11;
            // 
            // DLLButton
            // 
            this.DLLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DLLButton.Location = new System.Drawing.Point(311, 241);
            this.DLLButton.Name = "DLLButton";
            this.DLLButton.Size = new System.Drawing.Size(24, 23);
            this.DLLButton.TabIndex = 12;
            this.DLLButton.Text = "...";
            this.DLLButton.UseVisualStyleBackColor = true;
            this.DLLButton.Click += new System.EventHandler(this.DLLButton_Click);
            // 
            // DLLLabel
            // 
            this.DLLLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DLLLabel.Location = new System.Drawing.Point(67, 241);
            this.DLLLabel.Name = "DLLLabel";
            this.DLLLabel.Size = new System.Drawing.Size(239, 16);
            this.DLLLabel.TabIndex = 13;
            // 
            // FileDialogCheckBox
            // 
            this.FileDialogCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileDialogCheckBox.AutoSize = true;
            this.FileDialogCheckBox.Location = new System.Drawing.Point(5, 75);
            this.FileDialogCheckBox.Name = "FileDialogCheckBox";
            this.FileDialogCheckBox.Size = new System.Drawing.Size(73, 17);
            this.FileDialogCheckBox.TabIndex = 14;
            this.FileDialogCheckBox.Text = "File dialog";
            this.FileDialogCheckBox.UseVisualStyleBackColor = true;
            this.FileDialogCheckBox.CheckedChanged += new System.EventHandler(this.CheckboxChanged);
            // 
            // HTTPBodyCheckBox
            // 
            this.HTTPBodyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HTTPBodyCheckBox.AutoSize = true;
            this.HTTPBodyCheckBox.Location = new System.Drawing.Point(140, 121);
            this.HTTPBodyCheckBox.Name = "HTTPBodyCheckBox";
            this.HTTPBodyCheckBox.Size = new System.Drawing.Size(77, 17);
            this.HTTPBodyCheckBox.TabIndex = 15;
            this.HTTPBodyCheckBox.Text = "Send body";
            this.HTTPBodyCheckBox.UseVisualStyleBackColor = true;
            // 
            // DLLProcTextBox
            // 
            this.DLLProcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DLLProcTextBox.Location = new System.Drawing.Point(25, 268);
            this.DLLProcTextBox.Name = "DLLProcTextBox";
            this.DLLProcTextBox.Size = new System.Drawing.Size(310, 20);
            this.DLLProcTextBox.TabIndex = 16;
            // 
            // HTTPVerbTextBox
            // 
            this.HTTPVerbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HTTPVerbTextBox.Location = new System.Drawing.Point(67, 118);
            this.HTTPVerbTextBox.Name = "HTTPVerbTextBox";
            this.HTTPVerbTextBox.Size = new System.Drawing.Size(67, 20);
            this.HTTPVerbTextBox.TabIndex = 17;
            // 
            // MailItemSummaryProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HTTPVerbTextBox);
            this.Controls.Add(this.DLLProcTextBox);
            this.Controls.Add(this.HTTPBodyCheckBox);
            this.Controls.Add(this.FileDialogCheckBox);
            this.Controls.Add(this.DLLLabel);
            this.Controls.Add(this.DLLButton);
            this.Controls.Add(this.AppendLabel);
            this.Controls.Add(this.AppendButton);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.HTTPURLTextBox);
            this.Controls.Add(this.HTTPHeadersTextBox);
            this.Controls.Add(this.DLLCheckBox);
            this.Controls.Add(this.AppendCheckBox);
            this.Controls.Add(this.MsgDialogCheckBox);
            this.Controls.Add(this.HTTPCheckBox);
            this.Controls.Add(this.ClipboardCheckBox);
            this.Controls.Add(this.TemplateTextBox);
            this.Name = "MailItemSummaryProperties";
            this.Size = new System.Drawing.Size(340, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TemplateTextBox;
        private System.Windows.Forms.CheckBox ClipboardCheckBox;
        private System.Windows.Forms.CheckBox HTTPCheckBox;
        private System.Windows.Forms.CheckBox MsgDialogCheckBox;
        private System.Windows.Forms.CheckBox AppendCheckBox;
        private System.Windows.Forms.CheckBox DLLCheckBox;
        private System.Windows.Forms.TextBox HTTPHeadersTextBox;
        private System.Windows.Forms.TextBox HTTPURLTextBox;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Button AppendButton;
        private System.Windows.Forms.Label AppendLabel;
        private System.Windows.Forms.Button DLLButton;
        private System.Windows.Forms.Label DLLLabel;
        private System.Windows.Forms.CheckBox FileDialogCheckBox;
        private System.Windows.Forms.CheckBox HTTPBodyCheckBox;
        private System.Windows.Forms.TextBox DLLProcTextBox;
        private System.Windows.Forms.TextBox HTTPVerbTextBox;
    }
}
