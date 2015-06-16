namespace Framework.GUI.Forms.Conversations
{
   partial class ConfirmNewLinkForm
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
         this.parentReplyGroupBox = new System.Windows.Forms.GroupBox();
         this.childReplyGroupBox = new System.Windows.Forms.GroupBox();
         this.cancelButton = new System.Windows.Forms.Button();
         this.createLinkButton = new System.Windows.Forms.Button();
         this.parentAuthorLabel = new System.Windows.Forms.Label();
         this.parentTextLabel = new System.Windows.Forms.Label();
         this.parentAuthorTextBox = new System.Windows.Forms.TextBox();
         this.parentTextRichTextBox = new System.Windows.Forms.RichTextBox();
         this.childTextRichTextBox = new System.Windows.Forms.RichTextBox();
         this.childAuthorTextBox = new System.Windows.Forms.TextBox();
         this.childTextLabel = new System.Windows.Forms.Label();
         this.childAuthorLabel = new System.Windows.Forms.Label();
         this.parentReplyGroupBox.SuspendLayout();
         this.childReplyGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // parentReplyGroupBox
         // 
         this.parentReplyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.parentReplyGroupBox.Controls.Add(this.parentTextRichTextBox);
         this.parentReplyGroupBox.Controls.Add(this.parentAuthorTextBox);
         this.parentReplyGroupBox.Controls.Add(this.parentTextLabel);
         this.parentReplyGroupBox.Controls.Add(this.parentAuthorLabel);
         this.parentReplyGroupBox.Location = new System.Drawing.Point(12, 12);
         this.parentReplyGroupBox.Name = "parentReplyGroupBox";
         this.parentReplyGroupBox.Size = new System.Drawing.Size(513, 205);
         this.parentReplyGroupBox.TabIndex = 0;
         this.parentReplyGroupBox.TabStop = false;
         this.parentReplyGroupBox.Text = "Parent";
         // 
         // childReplyGroupBox
         // 
         this.childReplyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.childReplyGroupBox.Controls.Add(this.childTextRichTextBox);
         this.childReplyGroupBox.Controls.Add(this.childAuthorTextBox);
         this.childReplyGroupBox.Controls.Add(this.childTextLabel);
         this.childReplyGroupBox.Controls.Add(this.childAuthorLabel);
         this.childReplyGroupBox.Location = new System.Drawing.Point(12, 223);
         this.childReplyGroupBox.Name = "childReplyGroupBox";
         this.childReplyGroupBox.Size = new System.Drawing.Size(513, 205);
         this.childReplyGroupBox.TabIndex = 1;
         this.childReplyGroupBox.TabStop = false;
         this.childReplyGroupBox.Text = "Child";
         // 
         // cancelButton
         // 
         this.cancelButton.Location = new System.Drawing.Point(450, 434);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 2;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // createLinkButton
         // 
         this.createLinkButton.Location = new System.Drawing.Point(369, 434);
         this.createLinkButton.Name = "createLinkButton";
         this.createLinkButton.Size = new System.Drawing.Size(75, 23);
         this.createLinkButton.TabIndex = 3;
         this.createLinkButton.Text = "Create";
         this.createLinkButton.UseVisualStyleBackColor = true;
         this.createLinkButton.Click += new System.EventHandler(this.createLinkButton_Click);
         // 
         // parentAuthorLabel
         // 
         this.parentAuthorLabel.AutoSize = true;
         this.parentAuthorLabel.Location = new System.Drawing.Point(6, 29);
         this.parentAuthorLabel.Name = "parentAuthorLabel";
         this.parentAuthorLabel.Size = new System.Drawing.Size(41, 13);
         this.parentAuthorLabel.TabIndex = 0;
         this.parentAuthorLabel.Text = "Author:";
         // 
         // parentTextLabel
         // 
         this.parentTextLabel.AutoSize = true;
         this.parentTextLabel.Location = new System.Drawing.Point(6, 55);
         this.parentTextLabel.Name = "parentTextLabel";
         this.parentTextLabel.Size = new System.Drawing.Size(31, 13);
         this.parentTextLabel.TabIndex = 1;
         this.parentTextLabel.Text = "Text:";
         // 
         // parentAuthorTextBox
         // 
         this.parentAuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.parentAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.parentAuthorTextBox.Location = new System.Drawing.Point(53, 26);
         this.parentAuthorTextBox.Name = "parentAuthorTextBox";
         this.parentAuthorTextBox.ReadOnly = true;
         this.parentAuthorTextBox.Size = new System.Drawing.Size(194, 20);
         this.parentAuthorTextBox.TabIndex = 2;
         // 
         // parentTextRichTextBox
         // 
         this.parentTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.parentTextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.parentTextRichTextBox.Location = new System.Drawing.Point(53, 52);
         this.parentTextRichTextBox.Name = "parentTextRichTextBox";
         this.parentTextRichTextBox.ReadOnly = true;
         this.parentTextRichTextBox.Size = new System.Drawing.Size(454, 147);
         this.parentTextRichTextBox.TabIndex = 3;
         this.parentTextRichTextBox.Text = "";
         // 
         // childTextRichTextBox
         // 
         this.childTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.childTextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.childTextRichTextBox.Location = new System.Drawing.Point(53, 42);
         this.childTextRichTextBox.Name = "childTextRichTextBox";
         this.childTextRichTextBox.ReadOnly = true;
         this.childTextRichTextBox.Size = new System.Drawing.Size(454, 157);
         this.childTextRichTextBox.TabIndex = 7;
         this.childTextRichTextBox.Text = "";
         // 
         // childAuthorTextBox
         // 
         this.childAuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.childAuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.childAuthorTextBox.Location = new System.Drawing.Point(53, 16);
         this.childAuthorTextBox.Name = "childAuthorTextBox";
         this.childAuthorTextBox.ReadOnly = true;
         this.childAuthorTextBox.Size = new System.Drawing.Size(194, 20);
         this.childAuthorTextBox.TabIndex = 6;
         // 
         // childTextLabel
         // 
         this.childTextLabel.AutoSize = true;
         this.childTextLabel.Location = new System.Drawing.Point(6, 45);
         this.childTextLabel.Name = "childTextLabel";
         this.childTextLabel.Size = new System.Drawing.Size(31, 13);
         this.childTextLabel.TabIndex = 5;
         this.childTextLabel.Text = "Text:";
         // 
         // childAuthorLabel
         // 
         this.childAuthorLabel.AutoSize = true;
         this.childAuthorLabel.Location = new System.Drawing.Point(6, 19);
         this.childAuthorLabel.Name = "childAuthorLabel";
         this.childAuthorLabel.Size = new System.Drawing.Size(41, 13);
         this.childAuthorLabel.TabIndex = 4;
         this.childAuthorLabel.Text = "Author:";
         // 
         // ConfirmNewLinkForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(537, 463);
         this.Controls.Add(this.createLinkButton);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.childReplyGroupBox);
         this.Controls.Add(this.parentReplyGroupBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "ConfirmNewLinkForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Confirm";
         this.parentReplyGroupBox.ResumeLayout(false);
         this.parentReplyGroupBox.PerformLayout();
         this.childReplyGroupBox.ResumeLayout(false);
         this.childReplyGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox parentReplyGroupBox;
      private System.Windows.Forms.GroupBox childReplyGroupBox;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.Button createLinkButton;
      private System.Windows.Forms.Label parentTextLabel;
      private System.Windows.Forms.Label parentAuthorLabel;
      private System.Windows.Forms.RichTextBox parentTextRichTextBox;
      private System.Windows.Forms.TextBox parentAuthorTextBox;
      private System.Windows.Forms.RichTextBox childTextRichTextBox;
      private System.Windows.Forms.TextBox childAuthorTextBox;
      private System.Windows.Forms.Label childTextLabel;
      private System.Windows.Forms.Label childAuthorLabel;
   }
}