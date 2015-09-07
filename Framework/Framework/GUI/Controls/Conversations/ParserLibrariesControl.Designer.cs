namespace Framework.GUI.Controls.Conversations
{
   partial class ParserLibrariesControl
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
         this.parsersGroupBox = new System.Windows.Forms.GroupBox();
         this.parserListView = new System.Windows.Forms.ListView();
         this.parserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.parserLibrary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.addParserLibraryButton = new System.Windows.Forms.ToolStripButton();
         this.editParserLibraryButton = new System.Windows.Forms.ToolStripButton();
         this.deleteParserLibraryButton = new System.Windows.Forms.ToolStripButton();
         this.browseParserLibrary = new System.Windows.Forms.OpenFileDialog();
         this.parsersGroupBox.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // parsersGroupBox
         // 
         this.parsersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.parsersGroupBox.Controls.Add(this.parserListView);
         this.parsersGroupBox.Controls.Add(this.toolStrip1);
         this.parsersGroupBox.Location = new System.Drawing.Point(3, 3);
         this.parsersGroupBox.Name = "parsersGroupBox";
         this.parsersGroupBox.Size = new System.Drawing.Size(437, 300);
         this.parsersGroupBox.TabIndex = 0;
         this.parsersGroupBox.TabStop = false;
         this.parsersGroupBox.Text = "Parsers";
         // 
         // parserListView
         // 
         this.parserListView.BackColor = System.Drawing.SystemColors.Info;
         this.parserListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.parserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parserName,
            this.parserLibrary});
         this.parserListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.parserListView.FullRowSelect = true;
         this.parserListView.GridLines = true;
         this.parserListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.parserListView.HideSelection = false;
         this.parserListView.Location = new System.Drawing.Point(3, 41);
         this.parserListView.Name = "parserListView";
         this.parserListView.Size = new System.Drawing.Size(431, 256);
         this.parserListView.TabIndex = 1;
         this.parserListView.UseCompatibleStateImageBehavior = false;
         this.parserListView.View = System.Windows.Forms.View.Details;
         // 
         // parserName
         // 
         this.parserName.Text = "Name";
         this.parserName.Width = 299;
         // 
         // parserLibrary
         // 
         this.parserLibrary.Text = "Library";
         this.parserLibrary.Width = 103;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParserLibraryButton,
            this.editParserLibraryButton,
            this.deleteParserLibraryButton});
         this.toolStrip1.Location = new System.Drawing.Point(3, 16);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(431, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // addParserLibraryButton
         // 
         this.addParserLibraryButton.Image = global::Framework.Properties.Resources.Add;
         this.addParserLibraryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.addParserLibraryButton.Name = "addParserLibraryButton";
         this.addParserLibraryButton.Size = new System.Drawing.Size(49, 22);
         this.addParserLibraryButton.Text = "Add";
         this.addParserLibraryButton.Click += new System.EventHandler(this.addParserLibraryButton_Click);
         // 
         // editParserLibraryButton
         // 
         this.editParserLibraryButton.Enabled = false;
         this.editParserLibraryButton.Image = global::Framework.Properties.Resources.Edit;
         this.editParserLibraryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.editParserLibraryButton.Name = "editParserLibraryButton";
         this.editParserLibraryButton.Size = new System.Drawing.Size(47, 22);
         this.editParserLibraryButton.Text = "Edit";
         this.editParserLibraryButton.Visible = false;
         // 
         // deleteParserLibraryButton
         // 
         this.deleteParserLibraryButton.Enabled = false;
         this.deleteParserLibraryButton.Image = global::Framework.Properties.Resources.Delete;
         this.deleteParserLibraryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.deleteParserLibraryButton.Name = "deleteParserLibraryButton";
         this.deleteParserLibraryButton.Size = new System.Drawing.Size(60, 22);
         this.deleteParserLibraryButton.Text = "Delete";
         this.deleteParserLibraryButton.Visible = false;
         // 
         // browseParserLibrary
         // 
         this.browseParserLibrary.Filter = "Parser libraries files|*.dll";
         this.browseParserLibrary.Title = "Import parser library";
         // 
         // ParserLibrariesControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.parsersGroupBox);
         this.Name = "ParserLibrariesControl";
         this.Size = new System.Drawing.Size(443, 306);
         this.parsersGroupBox.ResumeLayout(false);
         this.parsersGroupBox.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox parsersGroupBox;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton addParserLibraryButton;
      private System.Windows.Forms.ToolStripButton editParserLibraryButton;
      private System.Windows.Forms.ToolStripButton deleteParserLibraryButton;
      private System.Windows.Forms.ListView parserListView;
      private System.Windows.Forms.ColumnHeader parserName;
      private System.Windows.Forms.ColumnHeader parserLibrary;
      private System.Windows.Forms.OpenFileDialog browseParserLibrary;
   }
}
