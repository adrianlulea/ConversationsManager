namespace Framework.GUI.Controls.Conversations
{
   partial class CreateNewDatabaseDetailsControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewDatabaseDetailsControl));
         this.importFromFileCheckBox = new System.Windows.Forms.CheckBox();
         this.browseFileToImportButton = new System.Windows.Forms.Button();
         this.parserGroupBox = new System.Windows.Forms.GroupBox();
         this.parserList = new System.Windows.Forms.ListView();
         this.parserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.libraryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.editAvailableParsersButton = new System.Windows.Forms.ToolStripButton();
         this.detailsButton = new System.Windows.Forms.ToolStripButton();
         this.conversationImportFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.parserGroupBox.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // importFromFileCheckBox
         // 
         this.importFromFileCheckBox.AutoSize = true;
         this.importFromFileCheckBox.Location = new System.Drawing.Point(306, 3);
         this.importFromFileCheckBox.Name = "importFromFileCheckBox";
         this.importFromFileCheckBox.Size = new System.Drawing.Size(158, 17);
         this.importFromFileCheckBox.TabIndex = 0;
         this.importFromFileCheckBox.Text = "Import conversation from file";
         this.importFromFileCheckBox.UseVisualStyleBackColor = true;
         this.importFromFileCheckBox.CheckedChanged += new System.EventHandler(this.importFromFileCheckBox_CheckedChanged);
         // 
         // browseFileToImportButton
         // 
         this.browseFileToImportButton.Enabled = false;
         this.browseFileToImportButton.Location = new System.Drawing.Point(470, -1);
         this.browseFileToImportButton.Name = "browseFileToImportButton";
         this.browseFileToImportButton.Size = new System.Drawing.Size(75, 23);
         this.browseFileToImportButton.TabIndex = 1;
         this.browseFileToImportButton.Text = "Browse";
         this.browseFileToImportButton.UseVisualStyleBackColor = true;
         this.browseFileToImportButton.Click += new System.EventHandler(this.browseFileToImportButton_Click);
         // 
         // parserGroupBox
         // 
         this.parserGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.parserGroupBox.Controls.Add(this.parserList);
         this.parserGroupBox.Controls.Add(this.toolStrip1);
         this.parserGroupBox.Enabled = false;
         this.parserGroupBox.Location = new System.Drawing.Point(3, 26);
         this.parserGroupBox.Name = "parserGroupBox";
         this.parserGroupBox.Size = new System.Drawing.Size(542, 256);
         this.parserGroupBox.TabIndex = 3;
         this.parserGroupBox.TabStop = false;
         this.parserGroupBox.Text = "Parsers";
         // 
         // parserList
         // 
         this.parserList.BackColor = System.Drawing.SystemColors.Info;
         this.parserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.parserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parserName,
            this.libraryName});
         this.parserList.Dock = System.Windows.Forms.DockStyle.Fill;
         this.parserList.FullRowSelect = true;
         this.parserList.GridLines = true;
         this.parserList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.parserList.Location = new System.Drawing.Point(3, 41);
         this.parserList.Name = "parserList";
         this.parserList.Size = new System.Drawing.Size(536, 212);
         this.parserList.TabIndex = 1;
         this.parserList.UseCompatibleStateImageBehavior = false;
         this.parserList.View = System.Windows.Forms.View.Details;
         // 
         // parserName
         // 
         this.parserName.Text = "Name";
         this.parserName.Width = 378;
         // 
         // libraryName
         // 
         this.libraryName.Text = "Library";
         this.libraryName.Width = 121;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAvailableParsersButton,
            this.detailsButton});
         this.toolStrip1.Location = new System.Drawing.Point(3, 16);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(536, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // editAvailableParsersButton
         // 
         this.editAvailableParsersButton.Image = ((System.Drawing.Image)(resources.GetObject("editAvailableParsersButton.Image")));
         this.editAvailableParsersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.editAvailableParsersButton.Name = "editAvailableParsersButton";
         this.editAvailableParsersButton.Size = new System.Drawing.Size(138, 22);
         this.editAvailableParsersButton.Text = "Edit Available Parsers";
         // 
         // detailsButton
         // 
         this.detailsButton.Enabled = false;
         this.detailsButton.Image = ((System.Drawing.Image)(resources.GetObject("detailsButton.Image")));
         this.detailsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.detailsButton.Name = "detailsButton";
         this.detailsButton.Size = new System.Drawing.Size(62, 22);
         this.detailsButton.Text = "Details";
         // 
         // conversationImportFileDialog
         // 
         this.conversationImportFileDialog.FileName = "openFileDialog1";
         this.conversationImportFileDialog.Filter = "XML files|*.xml|All files|*.*";
         this.conversationImportFileDialog.Title = "Import conversation";
         // 
         // CreateNewDatabaseDetailsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.parserGroupBox);
         this.Controls.Add(this.browseFileToImportButton);
         this.Controls.Add(this.importFromFileCheckBox);
         this.Name = "CreateNewDatabaseDetailsControl";
         this.Size = new System.Drawing.Size(548, 285);
         this.parserGroupBox.ResumeLayout(false);
         this.parserGroupBox.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.CheckBox importFromFileCheckBox;
      private System.Windows.Forms.Button browseFileToImportButton;
      private System.Windows.Forms.GroupBox parserGroupBox;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton editAvailableParsersButton;
      private System.Windows.Forms.ToolStripButton detailsButton;
      private System.Windows.Forms.ListView parserList;
      private System.Windows.Forms.ColumnHeader parserName;
      private System.Windows.Forms.ColumnHeader libraryName;
      private System.Windows.Forms.OpenFileDialog conversationImportFileDialog;
   }
}
