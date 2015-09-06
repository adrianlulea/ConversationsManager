namespace Framework.GUI.Controls.Conversations
{
   partial class GraphManagerHost
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
         this.selectedNodeOrLinkSplitContainer = new System.Windows.Forms.SplitContainer();
         this.graphLinksSplitContainer = new System.Windows.Forms.SplitContainer();
         this.graphHost = new System.Windows.Forms.Integration.ElementHost();
         this.parentsChildrenSplitContainer = new System.Windows.Forms.SplitContainer();
         this.selectedLinkSplitContainer = new System.Windows.Forms.SplitContainer();
         this.selectedNodeParentToolStrip = new System.Windows.Forms.ToolStrip();
         this.hideNodeParentMainButton = new System.Windows.Forms.ToolStripButton();
         this.saveChangesSelectedNodeParentButton = new System.Windows.Forms.ToolStripButton();
         this.showChildParentDetailsButton = new System.Windows.Forms.ToolStripButton();
         this.selectedNodeParentTextTextBox = new System.Windows.Forms.RichTextBox();
         this.selectedNodeParentTextLabel = new System.Windows.Forms.Label();
         this.selectedNodeParentAuthorTextBox = new System.Windows.Forms.TextBox();
         this.selectedNodeParentAuthorLabel = new System.Windows.Forms.Label();
         this.selectedNodeChildToolStrip = new System.Windows.Forms.ToolStrip();
         this.hideNodeChildOrHoveredButton = new System.Windows.Forms.ToolStripButton();
         this.saveChangesSelectedNodeChildButton = new System.Windows.Forms.ToolStripButton();
         this.selectedNodeChildTextTextBox = new System.Windows.Forms.RichTextBox();
         this.selectedNodeChildTextLabel = new System.Windows.Forms.Label();
         this.selectedNodeChildAuthorTextBox = new System.Windows.Forms.TextBox();
         this.selectedNodeChildAuthorLabel = new System.Windows.Forms.Label();
         this.graphInitializeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
         ((System.ComponentModel.ISupportInitialize)(this.selectedNodeOrLinkSplitContainer)).BeginInit();
         this.selectedNodeOrLinkSplitContainer.Panel1.SuspendLayout();
         this.selectedNodeOrLinkSplitContainer.Panel2.SuspendLayout();
         this.selectedNodeOrLinkSplitContainer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.graphLinksSplitContainer)).BeginInit();
         this.graphLinksSplitContainer.Panel1.SuspendLayout();
         this.graphLinksSplitContainer.Panel2.SuspendLayout();
         this.graphLinksSplitContainer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.parentsChildrenSplitContainer)).BeginInit();
         this.parentsChildrenSplitContainer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.selectedLinkSplitContainer)).BeginInit();
         this.selectedLinkSplitContainer.Panel1.SuspendLayout();
         this.selectedLinkSplitContainer.Panel2.SuspendLayout();
         this.selectedLinkSplitContainer.SuspendLayout();
         this.selectedNodeParentToolStrip.SuspendLayout();
         this.selectedNodeChildToolStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // selectedNodeOrLinkSplitContainer
         // 
         this.selectedNodeOrLinkSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.selectedNodeOrLinkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.selectedNodeOrLinkSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.selectedNodeOrLinkSplitContainer.Name = "selectedNodeOrLinkSplitContainer";
         this.selectedNodeOrLinkSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // selectedNodeOrLinkSplitContainer.Panel1
         // 
         this.selectedNodeOrLinkSplitContainer.Panel1.Controls.Add(this.graphLinksSplitContainer);
         // 
         // selectedNodeOrLinkSplitContainer.Panel2
         // 
         this.selectedNodeOrLinkSplitContainer.Panel2.Controls.Add(this.selectedLinkSplitContainer);
         this.selectedNodeOrLinkSplitContainer.Panel2Collapsed = true;
         this.selectedNodeOrLinkSplitContainer.Size = new System.Drawing.Size(1016, 692);
         this.selectedNodeOrLinkSplitContainer.SplitterDistance = 557;
         this.selectedNodeOrLinkSplitContainer.TabIndex = 0;
         // 
         // graphLinksSplitContainer
         // 
         this.graphLinksSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.graphLinksSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.graphLinksSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.graphLinksSplitContainer.Name = "graphLinksSplitContainer";
         // 
         // graphLinksSplitContainer.Panel1
         // 
         this.graphLinksSplitContainer.Panel1.Controls.Add(this.graphHost);
         // 
         // graphLinksSplitContainer.Panel2
         // 
         this.graphLinksSplitContainer.Panel2.Controls.Add(this.parentsChildrenSplitContainer);
         this.graphLinksSplitContainer.Size = new System.Drawing.Size(1016, 692);
         this.graphLinksSplitContainer.SplitterDistance = 679;
         this.graphLinksSplitContainer.TabIndex = 0;
         // 
         // graphHost
         // 
         this.graphHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.graphHost.Location = new System.Drawing.Point(0, 0);
         this.graphHost.Name = "graphHost";
         this.graphHost.Size = new System.Drawing.Size(677, 690);
         this.graphHost.TabIndex = 0;
         this.graphHost.Text = "elementHost1";
         this.graphHost.Child = null;
         // 
         // parentsChildrenSplitContainer
         // 
         this.parentsChildrenSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.parentsChildrenSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.parentsChildrenSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.parentsChildrenSplitContainer.Name = "parentsChildrenSplitContainer";
         this.parentsChildrenSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
         this.parentsChildrenSplitContainer.Size = new System.Drawing.Size(333, 692);
         this.parentsChildrenSplitContainer.SplitterDistance = 352;
         this.parentsChildrenSplitContainer.TabIndex = 0;
         // 
         // selectedLinkSplitContainer
         // 
         this.selectedLinkSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.selectedLinkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.selectedLinkSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.selectedLinkSplitContainer.Name = "selectedLinkSplitContainer";
         // 
         // selectedLinkSplitContainer.Panel1
         // 
         this.selectedLinkSplitContainer.Panel1.Controls.Add(this.selectedNodeParentToolStrip);
         this.selectedLinkSplitContainer.Panel1.Controls.Add(this.selectedNodeParentTextTextBox);
         this.selectedLinkSplitContainer.Panel1.Controls.Add(this.selectedNodeParentTextLabel);
         this.selectedLinkSplitContainer.Panel1.Controls.Add(this.selectedNodeParentAuthorTextBox);
         this.selectedLinkSplitContainer.Panel1.Controls.Add(this.selectedNodeParentAuthorLabel);
         // 
         // selectedLinkSplitContainer.Panel2
         // 
         this.selectedLinkSplitContainer.Panel2.Controls.Add(this.selectedNodeChildToolStrip);
         this.selectedLinkSplitContainer.Panel2.Controls.Add(this.selectedNodeChildTextTextBox);
         this.selectedLinkSplitContainer.Panel2.Controls.Add(this.selectedNodeChildTextLabel);
         this.selectedLinkSplitContainer.Panel2.Controls.Add(this.selectedNodeChildAuthorTextBox);
         this.selectedLinkSplitContainer.Panel2.Controls.Add(this.selectedNodeChildAuthorLabel);
         this.selectedLinkSplitContainer.Size = new System.Drawing.Size(1016, 131);
         this.selectedLinkSplitContainer.SplitterDistance = 508;
         this.selectedLinkSplitContainer.TabIndex = 0;
         // 
         // selectedNodeParentToolStrip
         // 
         this.selectedNodeParentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideNodeParentMainButton,
            this.saveChangesSelectedNodeParentButton,
            this.showChildParentDetailsButton});
         this.selectedNodeParentToolStrip.Location = new System.Drawing.Point(0, 0);
         this.selectedNodeParentToolStrip.Name = "selectedNodeParentToolStrip";
         this.selectedNodeParentToolStrip.Size = new System.Drawing.Size(506, 25);
         this.selectedNodeParentToolStrip.TabIndex = 4;
         this.selectedNodeParentToolStrip.Text = "toolStrip1";
         // 
         // hideNodeParentMainButton
         // 
         this.hideNodeParentMainButton.Image = global::Framework.Properties.Resources.Hide;
         this.hideNodeParentMainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.hideNodeParentMainButton.Name = "hideNodeParentMainButton";
         this.hideNodeParentMainButton.Size = new System.Drawing.Size(52, 22);
         this.hideNodeParentMainButton.Text = "Hide";
         this.hideNodeParentMainButton.Click += new System.EventHandler(this.hideNodeParentMainButton_Click);
         // 
         // saveChangesSelectedNodeParentButton
         // 
         this.saveChangesSelectedNodeParentButton.Enabled = false;
         this.saveChangesSelectedNodeParentButton.Image = global::Framework.Properties.Resources.Save;
         this.saveChangesSelectedNodeParentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveChangesSelectedNodeParentButton.Name = "saveChangesSelectedNodeParentButton";
         this.saveChangesSelectedNodeParentButton.Size = new System.Drawing.Size(98, 22);
         this.saveChangesSelectedNodeParentButton.Text = "Save changes";
         // 
         // showChildParentDetailsButton
         // 
         this.showChildParentDetailsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.showChildParentDetailsButton.Image = global::Framework.Properties.Resources.Undo;
         this.showChildParentDetailsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.showChildParentDetailsButton.Name = "showChildParentDetailsButton";
         this.showChildParentDetailsButton.Size = new System.Drawing.Size(56, 22);
         this.showChildParentDetailsButton.Text = "Show";
         this.showChildParentDetailsButton.Click += new System.EventHandler(this.showChildParentDetailsButton_Click);
         // 
         // selectedNodeParentTextTextBox
         // 
         this.selectedNodeParentTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.selectedNodeParentTextTextBox.Location = new System.Drawing.Point(50, 54);
         this.selectedNodeParentTextTextBox.Name = "selectedNodeParentTextTextBox";
         this.selectedNodeParentTextTextBox.Size = new System.Drawing.Size(453, 72);
         this.selectedNodeParentTextTextBox.TabIndex = 3;
         this.selectedNodeParentTextTextBox.Text = "";
         // 
         // selectedNodeParentTextLabel
         // 
         this.selectedNodeParentTextLabel.AutoSize = true;
         this.selectedNodeParentTextLabel.Location = new System.Drawing.Point(3, 57);
         this.selectedNodeParentTextLabel.Name = "selectedNodeParentTextLabel";
         this.selectedNodeParentTextLabel.Size = new System.Drawing.Size(31, 13);
         this.selectedNodeParentTextLabel.TabIndex = 2;
         this.selectedNodeParentTextLabel.Text = "Text:";
         // 
         // selectedNodeParentAuthorTextBox
         // 
         this.selectedNodeParentAuthorTextBox.Location = new System.Drawing.Point(50, 28);
         this.selectedNodeParentAuthorTextBox.Name = "selectedNodeParentAuthorTextBox";
         this.selectedNodeParentAuthorTextBox.Size = new System.Drawing.Size(138, 20);
         this.selectedNodeParentAuthorTextBox.TabIndex = 1;
         // 
         // selectedNodeParentAuthorLabel
         // 
         this.selectedNodeParentAuthorLabel.AutoSize = true;
         this.selectedNodeParentAuthorLabel.Location = new System.Drawing.Point(3, 31);
         this.selectedNodeParentAuthorLabel.Name = "selectedNodeParentAuthorLabel";
         this.selectedNodeParentAuthorLabel.Size = new System.Drawing.Size(41, 13);
         this.selectedNodeParentAuthorLabel.TabIndex = 0;
         this.selectedNodeParentAuthorLabel.Text = "Author:";
         // 
         // selectedNodeChildToolStrip
         // 
         this.selectedNodeChildToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideNodeChildOrHoveredButton,
            this.saveChangesSelectedNodeChildButton});
         this.selectedNodeChildToolStrip.Location = new System.Drawing.Point(0, 0);
         this.selectedNodeChildToolStrip.Name = "selectedNodeChildToolStrip";
         this.selectedNodeChildToolStrip.Size = new System.Drawing.Size(502, 25);
         this.selectedNodeChildToolStrip.TabIndex = 9;
         this.selectedNodeChildToolStrip.Text = "toolStrip1";
         // 
         // hideNodeChildOrHoveredButton
         // 
         this.hideNodeChildOrHoveredButton.Image = global::Framework.Properties.Resources.Redo;
         this.hideNodeChildOrHoveredButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.hideNodeChildOrHoveredButton.Name = "hideNodeChildOrHoveredButton";
         this.hideNodeChildOrHoveredButton.Size = new System.Drawing.Size(52, 22);
         this.hideNodeChildOrHoveredButton.Text = "Hide";
         this.hideNodeChildOrHoveredButton.Click += new System.EventHandler(this.hideNodeChildOrHoveredButton_Click);
         // 
         // saveChangesSelectedNodeChildButton
         // 
         this.saveChangesSelectedNodeChildButton.Enabled = false;
         this.saveChangesSelectedNodeChildButton.Image = global::Framework.Properties.Resources.Save;
         this.saveChangesSelectedNodeChildButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveChangesSelectedNodeChildButton.Name = "saveChangesSelectedNodeChildButton";
         this.saveChangesSelectedNodeChildButton.Size = new System.Drawing.Size(98, 22);
         this.saveChangesSelectedNodeChildButton.Text = "Save changes";
         // 
         // selectedNodeChildTextTextBox
         // 
         this.selectedNodeChildTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.selectedNodeChildTextTextBox.Location = new System.Drawing.Point(48, 55);
         this.selectedNodeChildTextTextBox.Name = "selectedNodeChildTextTextBox";
         this.selectedNodeChildTextTextBox.Size = new System.Drawing.Size(451, 71);
         this.selectedNodeChildTextTextBox.TabIndex = 8;
         this.selectedNodeChildTextTextBox.Text = "";
         // 
         // selectedNodeChildTextLabel
         // 
         this.selectedNodeChildTextLabel.AutoSize = true;
         this.selectedNodeChildTextLabel.Location = new System.Drawing.Point(1, 58);
         this.selectedNodeChildTextLabel.Name = "selectedNodeChildTextLabel";
         this.selectedNodeChildTextLabel.Size = new System.Drawing.Size(31, 13);
         this.selectedNodeChildTextLabel.TabIndex = 7;
         this.selectedNodeChildTextLabel.Text = "Text:";
         // 
         // selectedNodeChildAuthorTextBox
         // 
         this.selectedNodeChildAuthorTextBox.Location = new System.Drawing.Point(48, 29);
         this.selectedNodeChildAuthorTextBox.Name = "selectedNodeChildAuthorTextBox";
         this.selectedNodeChildAuthorTextBox.Size = new System.Drawing.Size(138, 20);
         this.selectedNodeChildAuthorTextBox.TabIndex = 6;
         // 
         // selectedNodeChildAuthorLabel
         // 
         this.selectedNodeChildAuthorLabel.AutoSize = true;
         this.selectedNodeChildAuthorLabel.Location = new System.Drawing.Point(1, 32);
         this.selectedNodeChildAuthorLabel.Name = "selectedNodeChildAuthorLabel";
         this.selectedNodeChildAuthorLabel.Size = new System.Drawing.Size(41, 13);
         this.selectedNodeChildAuthorLabel.TabIndex = 5;
         this.selectedNodeChildAuthorLabel.Text = "Author:";
         // 
         // graphInitializeBackgroundWorker
         // 
         this.graphInitializeBackgroundWorker.WorkerSupportsCancellation = true;
         // 
         // GraphManagerHost
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.selectedNodeOrLinkSplitContainer);
         this.Name = "GraphManagerHost";
         this.Size = new System.Drawing.Size(1016, 692);
         this.selectedNodeOrLinkSplitContainer.Panel1.ResumeLayout(false);
         this.selectedNodeOrLinkSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.selectedNodeOrLinkSplitContainer)).EndInit();
         this.selectedNodeOrLinkSplitContainer.ResumeLayout(false);
         this.graphLinksSplitContainer.Panel1.ResumeLayout(false);
         this.graphLinksSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.graphLinksSplitContainer)).EndInit();
         this.graphLinksSplitContainer.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.parentsChildrenSplitContainer)).EndInit();
         this.parentsChildrenSplitContainer.ResumeLayout(false);
         this.selectedLinkSplitContainer.Panel1.ResumeLayout(false);
         this.selectedLinkSplitContainer.Panel1.PerformLayout();
         this.selectedLinkSplitContainer.Panel2.ResumeLayout(false);
         this.selectedLinkSplitContainer.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.selectedLinkSplitContainer)).EndInit();
         this.selectedLinkSplitContainer.ResumeLayout(false);
         this.selectedNodeParentToolStrip.ResumeLayout(false);
         this.selectedNodeParentToolStrip.PerformLayout();
         this.selectedNodeChildToolStrip.ResumeLayout(false);
         this.selectedNodeChildToolStrip.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer selectedNodeOrLinkSplitContainer;
      private System.Windows.Forms.SplitContainer selectedLinkSplitContainer;
      private System.Windows.Forms.SplitContainer graphLinksSplitContainer;
      private System.Windows.Forms.SplitContainer parentsChildrenSplitContainer;
      private System.Windows.Forms.Integration.ElementHost graphHost;
      private System.Windows.Forms.TextBox selectedNodeParentAuthorTextBox;
      private System.Windows.Forms.Label selectedNodeParentAuthorLabel;
      private System.Windows.Forms.Label selectedNodeParentTextLabel;
      private System.Windows.Forms.RichTextBox selectedNodeParentTextTextBox;
      private System.Windows.Forms.ToolStrip selectedNodeParentToolStrip;
      private System.Windows.Forms.ToolStripButton saveChangesSelectedNodeParentButton;
      private System.Windows.Forms.ToolStrip selectedNodeChildToolStrip;
      private System.Windows.Forms.ToolStripButton saveChangesSelectedNodeChildButton;
      private System.Windows.Forms.RichTextBox selectedNodeChildTextTextBox;
      private System.Windows.Forms.Label selectedNodeChildTextLabel;
      private System.Windows.Forms.TextBox selectedNodeChildAuthorTextBox;
      private System.Windows.Forms.Label selectedNodeChildAuthorLabel;
      private System.Windows.Forms.ToolStripButton hideNodeParentMainButton;
      private System.Windows.Forms.ToolStripButton hideNodeChildOrHoveredButton;
      private System.ComponentModel.BackgroundWorker graphInitializeBackgroundWorker;
      private System.Windows.Forms.ToolStripButton showChildParentDetailsButton;
   }
}
