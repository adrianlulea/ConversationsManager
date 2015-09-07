namespace Framework.GUI.Controls.Conversations
{
   partial class LayoutAlgorithmsControl
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
         this.algorithmsGroupBox = new System.Windows.Forms.GroupBox();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.addAlgorithmButton = new System.Windows.Forms.ToolStripButton();
         this.editAlgorithmButton = new System.Windows.Forms.ToolStripButton();
         this.deleteAlgorithmButton = new System.Windows.Forms.ToolStripButton();
         this.algorithmListView = new System.Windows.Forms.ListView();
         this.algorithmNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.algorithmLibraryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.browseAlgorithmLibrary = new System.Windows.Forms.OpenFileDialog();
         this.algorithmsGroupBox.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // algorithmsGroupBox
         // 
         this.algorithmsGroupBox.Controls.Add(this.algorithmListView);
         this.algorithmsGroupBox.Controls.Add(this.toolStrip1);
         this.algorithmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.algorithmsGroupBox.Location = new System.Drawing.Point(0, 0);
         this.algorithmsGroupBox.Name = "algorithmsGroupBox";
         this.algorithmsGroupBox.Size = new System.Drawing.Size(675, 281);
         this.algorithmsGroupBox.TabIndex = 0;
         this.algorithmsGroupBox.TabStop = false;
         this.algorithmsGroupBox.Text = "Algorithms";
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlgorithmButton,
            this.editAlgorithmButton,
            this.deleteAlgorithmButton});
         this.toolStrip1.Location = new System.Drawing.Point(3, 16);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(669, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // addAlgorithmButton
         // 
         this.addAlgorithmButton.Image = global::Framework.Properties.Resources.Add;
         this.addAlgorithmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.addAlgorithmButton.Name = "addAlgorithmButton";
         this.addAlgorithmButton.Size = new System.Drawing.Size(49, 22);
         this.addAlgorithmButton.Text = "Add";
         this.addAlgorithmButton.Click += new System.EventHandler(this.addAlgorithmButton_Click);
         // 
         // editAlgorithmButton
         // 
         this.editAlgorithmButton.Enabled = false;
         this.editAlgorithmButton.Image = global::Framework.Properties.Resources.Edit;
         this.editAlgorithmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.editAlgorithmButton.Name = "editAlgorithmButton";
         this.editAlgorithmButton.Size = new System.Drawing.Size(47, 22);
         this.editAlgorithmButton.Text = "Edit";
         this.editAlgorithmButton.Visible = false;
         // 
         // deleteAlgorithmButton
         // 
         this.deleteAlgorithmButton.Enabled = false;
         this.deleteAlgorithmButton.Image = global::Framework.Properties.Resources.Delete;
         this.deleteAlgorithmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.deleteAlgorithmButton.Name = "deleteAlgorithmButton";
         this.deleteAlgorithmButton.Size = new System.Drawing.Size(60, 22);
         this.deleteAlgorithmButton.Text = "Delete";
         this.deleteAlgorithmButton.Visible = false;
         // 
         // algorithmListView
         // 
         this.algorithmListView.BackColor = System.Drawing.SystemColors.Info;
         this.algorithmListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.algorithmNameColumnHeader,
            this.algorithmLibraryColumnHeader});
         this.algorithmListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.algorithmListView.FullRowSelect = true;
         this.algorithmListView.GridLines = true;
         this.algorithmListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.algorithmListView.HideSelection = false;
         this.algorithmListView.Location = new System.Drawing.Point(3, 41);
         this.algorithmListView.MultiSelect = false;
         this.algorithmListView.Name = "algorithmListView";
         this.algorithmListView.Size = new System.Drawing.Size(669, 237);
         this.algorithmListView.TabIndex = 1;
         this.algorithmListView.UseCompatibleStateImageBehavior = false;
         this.algorithmListView.View = System.Windows.Forms.View.Details;
         this.algorithmListView.SelectedIndexChanged += new System.EventHandler(this.algorithmListView_SelectedIndexChanged);
         // 
         // algorithmNameColumnHeader
         // 
         this.algorithmNameColumnHeader.Text = "Name";
         this.algorithmNameColumnHeader.Width = 516;
         // 
         // algorithmLibraryColumnHeader
         // 
         this.algorithmLibraryColumnHeader.Text = "Library";
         this.algorithmLibraryColumnHeader.Width = 105;
         // 
         // browseAlgorithmLibrary
         // 
         this.browseAlgorithmLibrary.Filter = "Algorithm libraries files|*.dll";
         this.browseAlgorithmLibrary.Title = "Import algorithm library";
         // 
         // LayoutAlgorithmsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.algorithmsGroupBox);
         this.Name = "LayoutAlgorithmsControl";
         this.Size = new System.Drawing.Size(675, 281);
         this.algorithmsGroupBox.ResumeLayout(false);
         this.algorithmsGroupBox.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox algorithmsGroupBox;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton addAlgorithmButton;
      private System.Windows.Forms.ToolStripButton editAlgorithmButton;
      private System.Windows.Forms.ToolStripButton deleteAlgorithmButton;
      private System.Windows.Forms.ListView algorithmListView;
      private System.Windows.Forms.ColumnHeader algorithmNameColumnHeader;
      private System.Windows.Forms.ColumnHeader algorithmLibraryColumnHeader;
      private System.Windows.Forms.OpenFileDialog browseAlgorithmLibrary;
   }
}
