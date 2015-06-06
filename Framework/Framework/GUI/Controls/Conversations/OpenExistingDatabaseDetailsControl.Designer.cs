namespace Framework.GUI.Controls.Conversations
{
   partial class OpenExistingDatabaseDetailsControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenExistingDatabaseDetailsControl));
         this.existingGroupBox = new System.Windows.Forms.GroupBox();
         this.savedDataList = new System.Windows.Forms.ListView();
         this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.renameButton = new System.Windows.Forms.ToolStripButton();
         this.newName = new System.Windows.Forms.ToolStripTextBox();
         this.finishRenamingButton = new System.Windows.Forms.ToolStripButton();
         this.deleteButton = new System.Windows.Forms.ToolStripButton();
         this.existingGroupBox.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // existingGroupBox
         // 
         this.existingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.existingGroupBox.Controls.Add(this.savedDataList);
         this.existingGroupBox.Controls.Add(this.toolStrip1);
         this.existingGroupBox.Location = new System.Drawing.Point(3, 3);
         this.existingGroupBox.Name = "existingGroupBox";
         this.existingGroupBox.Size = new System.Drawing.Size(542, 279);
         this.existingGroupBox.TabIndex = 0;
         this.existingGroupBox.TabStop = false;
         this.existingGroupBox.Text = "Existing";
         // 
         // savedDataList
         // 
         this.savedDataList.BackColor = System.Drawing.SystemColors.Info;
         this.savedDataList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.savedDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.sizeHeader});
         this.savedDataList.Dock = System.Windows.Forms.DockStyle.Fill;
         this.savedDataList.FullRowSelect = true;
         this.savedDataList.GridLines = true;
         this.savedDataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.savedDataList.HideSelection = false;
         this.savedDataList.Location = new System.Drawing.Point(3, 41);
         this.savedDataList.Name = "savedDataList";
         this.savedDataList.Size = new System.Drawing.Size(536, 235);
         this.savedDataList.TabIndex = 1;
         this.savedDataList.UseCompatibleStateImageBehavior = false;
         this.savedDataList.View = System.Windows.Forms.View.Details;
         // 
         // nameHeader
         // 
         this.nameHeader.Text = "Name";
         this.nameHeader.Width = 400;
         // 
         // sizeHeader
         // 
         this.sizeHeader.Text = "Size";
         this.sizeHeader.Width = 115;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameButton,
            this.newName,
            this.finishRenamingButton,
            this.deleteButton});
         this.toolStrip1.Location = new System.Drawing.Point(3, 16);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(536, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // renameButton
         // 
         this.renameButton.Enabled = false;
         this.renameButton.Image = ((System.Drawing.Image)(resources.GetObject("renameButton.Image")));
         this.renameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.renameButton.Name = "renameButton";
         this.renameButton.Size = new System.Drawing.Size(70, 22);
         this.renameButton.Text = "Rename";
         // 
         // newName
         // 
         this.newName.Name = "newName";
         this.newName.Size = new System.Drawing.Size(100, 25);
         this.newName.Visible = false;
         // 
         // finishRenamingButton
         // 
         this.finishRenamingButton.Enabled = false;
         this.finishRenamingButton.Image = ((System.Drawing.Image)(resources.GetObject("finishRenamingButton.Image")));
         this.finishRenamingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.finishRenamingButton.Name = "finishRenamingButton";
         this.finishRenamingButton.Size = new System.Drawing.Size(55, 22);
         this.finishRenamingButton.Text = "Done";
         this.finishRenamingButton.Visible = false;
         // 
         // deleteButton
         // 
         this.deleteButton.Enabled = false;
         this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
         this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.deleteButton.Name = "deleteButton";
         this.deleteButton.Size = new System.Drawing.Size(60, 22);
         this.deleteButton.Text = "Delete";
         // 
         // OpenExistingDatabaseDetailsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.existingGroupBox);
         this.Name = "OpenExistingDatabaseDetailsControl";
         this.Size = new System.Drawing.Size(548, 285);
         this.existingGroupBox.ResumeLayout(false);
         this.existingGroupBox.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox existingGroupBox;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton renameButton;
      private System.Windows.Forms.ToolStripButton deleteButton;
      private System.Windows.Forms.ToolStripTextBox newName;
      private System.Windows.Forms.ToolStripButton finishRenamingButton;
      private System.Windows.Forms.ListView savedDataList;
      private System.Windows.Forms.ColumnHeader nameHeader;
      private System.Windows.Forms.ColumnHeader sizeHeader;
   }
}
