namespace Framework.GUI.Controls.Conversations
{
    partial class BasicInformationControl
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
            this.replyText = new System.Windows.Forms.RichTextBox();
            this.replyLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.timestampPicker = new System.Windows.Forms.DateTimePicker();
            this.timestampLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replyText
            // 
            this.replyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.replyText.Location = new System.Drawing.Point(76, 29);
            this.replyText.Name = "replyText";
            this.replyText.Size = new System.Drawing.Size(439, 296);
            this.replyText.TabIndex = 11;
            this.replyText.Text = "";
            this.replyText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // replyLabel
            // 
            this.replyLabel.AutoSize = true;
            this.replyLabel.Location = new System.Drawing.Point(3, 32);
            this.replyLabel.Name = "replyLabel";
            this.replyLabel.Size = new System.Drawing.Size(43, 13);
            this.replyLabel.TabIndex = 10;
            this.replyLabel.Text = "Reply : ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(338, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(177, 20);
            this.usernameTextBox.TabIndex = 9;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(268, 6);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(47, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author : ";
            // 
            // timestampPicker
            // 
            this.timestampPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timestampPicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.timestampPicker.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.timestampPicker.Location = new System.Drawing.Point(76, 3);
            this.timestampPicker.Name = "timestampPicker";
            this.timestampPicker.Size = new System.Drawing.Size(186, 20);
            this.timestampPicker.TabIndex = 7;
            // 
            // timestampLabel
            // 
            this.timestampLabel.AutoSize = true;
            this.timestampLabel.Location = new System.Drawing.Point(3, 7);
            this.timestampLabel.Name = "timestampLabel";
            this.timestampLabel.Size = new System.Drawing.Size(67, 13);
            this.timestampLabel.TabIndex = 6;
            this.timestampLabel.Text = "Timestamp : ";
            // 
            // BasicInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.replyText);
            this.Controls.Add(this.replyLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.timestampPicker);
            this.Controls.Add(this.timestampLabel);
            this.MinimumSize = new System.Drawing.Size(525, 334);
            this.Name = "BasicInformationControl";
            this.Size = new System.Drawing.Size(525, 334);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox replyText;
        private System.Windows.Forms.Label replyLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.DateTimePicker timestampPicker;
        private System.Windows.Forms.Label timestampLabel;
    }
}
