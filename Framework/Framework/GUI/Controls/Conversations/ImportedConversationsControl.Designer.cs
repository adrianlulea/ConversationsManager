namespace Framework.GUI.Controls.Conversations
{
    partial class ImportedConversationsControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportedConversationsControl));
            this.mainStrip = new System.Windows.Forms.ToolStrip();
            this.addReplyStrip = new System.Windows.Forms.ToolStripButton();
            this.editReplyStrip = new System.Windows.Forms.ToolStripButton();
            this.deleteReplyStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editParentsStrip = new System.Windows.Forms.ToolStripButton();
            this.editChildrenStrip = new System.Windows.Forms.ToolStripButton();
            this.listView = new System.Windows.Forms.ListView();
            this.timestampHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childrenHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addReplyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.editReplyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteReplyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editParentsContext = new System.Windows.Forms.ToolStripMenuItem();
            this.editChildrenContext = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStrip.SuspendLayout();
            this.mainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStrip
            // 
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReplyStrip,
            this.editReplyStrip,
            this.deleteReplyStrip,
            this.toolStripSeparator1,
            this.editParentsStrip,
            this.editChildrenStrip});
            this.mainStrip.Location = new System.Drawing.Point(0, 0);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(630, 25);
            this.mainStrip.TabIndex = 0;
            this.mainStrip.Text = "toolStrip1";
            // 
            // addReplyStrip
            // 
            this.addReplyStrip.Image = ((System.Drawing.Image)(resources.GetObject("addReplyStrip.Image")));
            this.addReplyStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addReplyStrip.Name = "addReplyStrip";
            this.addReplyStrip.Size = new System.Drawing.Size(46, 22);
            this.addReplyStrip.Text = "Add";
            this.addReplyStrip.Click += new System.EventHandler(this.addReply_Click);
            // 
            // editReplyStrip
            // 
            this.editReplyStrip.Enabled = false;
            this.editReplyStrip.Image = ((System.Drawing.Image)(resources.GetObject("editReplyStrip.Image")));
            this.editReplyStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editReplyStrip.Name = "editReplyStrip";
            this.editReplyStrip.Size = new System.Drawing.Size(45, 22);
            this.editReplyStrip.Text = "Edit";
            // 
            // deleteReplyStrip
            // 
            this.deleteReplyStrip.Enabled = false;
            this.deleteReplyStrip.Image = ((System.Drawing.Image)(resources.GetObject("deleteReplyStrip.Image")));
            this.deleteReplyStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteReplyStrip.Name = "deleteReplyStrip";
            this.deleteReplyStrip.Size = new System.Drawing.Size(58, 22);
            this.deleteReplyStrip.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // editParentsStrip
            // 
            this.editParentsStrip.Enabled = false;
            this.editParentsStrip.Image = ((System.Drawing.Image)(resources.GetObject("editParentsStrip.Image")));
            this.editParentsStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editParentsStrip.Name = "editParentsStrip";
            this.editParentsStrip.Size = new System.Drawing.Size(85, 22);
            this.editParentsStrip.Text = "Edit Parents";
            // 
            // editChildrenStrip
            // 
            this.editChildrenStrip.Enabled = false;
            this.editChildrenStrip.Image = ((System.Drawing.Image)(resources.GetObject("editChildrenStrip.Image")));
            this.editChildrenStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editChildrenStrip.Name = "editChildrenStrip";
            this.editChildrenStrip.Size = new System.Drawing.Size(87, 22);
            this.editChildrenStrip.Text = "Edit Children";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Info;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timestampHeader,
            this.nameHeader,
            this.textHeader,
            this.parentsHeader,
            this.childrenHeader});
            this.listView.ContextMenuStrip = this.mainContextMenu;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(630, 392);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // timestampHeader
            // 
            this.timestampHeader.Text = "Timestamp";
            this.timestampHeader.Width = 63;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 69;
            // 
            // textHeader
            // 
            this.textHeader.Text = "Text";
            this.textHeader.Width = 378;
            // 
            // parentsHeader
            // 
            this.parentsHeader.Text = "Parents";
            this.parentsHeader.Width = 49;
            // 
            // childrenHeader
            // 
            this.childrenHeader.Text = "Children";
            this.childrenHeader.Width = 50;
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReplyContext,
            this.editReplyContext,
            this.DeleteReplyContext,
            this.toolStripSeparator2,
            this.editParentsContext,
            this.editChildrenContext});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(153, 142);
            // 
            // addReplyContext
            // 
            this.addReplyContext.Name = "addReplyContext";
            this.addReplyContext.Size = new System.Drawing.Size(152, 22);
            this.addReplyContext.Text = "Add";
            this.addReplyContext.Click += new System.EventHandler(this.addReply_Click);
            // 
            // editReplyContext
            // 
            this.editReplyContext.Enabled = false;
            this.editReplyContext.Name = "editReplyContext";
            this.editReplyContext.Size = new System.Drawing.Size(152, 22);
            this.editReplyContext.Text = "Edit";
            // 
            // DeleteReplyContext
            // 
            this.DeleteReplyContext.Enabled = false;
            this.DeleteReplyContext.Name = "DeleteReplyContext";
            this.DeleteReplyContext.Size = new System.Drawing.Size(152, 22);
            this.DeleteReplyContext.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // editParentsContext
            // 
            this.editParentsContext.Enabled = false;
            this.editParentsContext.Name = "editParentsContext";
            this.editParentsContext.Size = new System.Drawing.Size(152, 22);
            this.editParentsContext.Text = "Edit Parents";
            // 
            // editChildrenContext
            // 
            this.editChildrenContext.Enabled = false;
            this.editChildrenContext.Name = "editChildrenContext";
            this.editChildrenContext.Size = new System.Drawing.Size(152, 22);
            this.editChildrenContext.Text = "Edit Children";
            // 
            // ImportedConversationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.mainStrip);
            this.MinimumSize = new System.Drawing.Size(630, 417);
            this.Name = "ImportedConversationsControl";
            this.Size = new System.Drawing.Size(630, 417);
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.mainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainStrip;
        private System.Windows.Forms.ToolStripButton addReplyStrip;
        private System.Windows.Forms.ToolStripButton editReplyStrip;
        private System.Windows.Forms.ToolStripButton deleteReplyStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editParentsStrip;
        private System.Windows.Forms.ToolStripButton editChildrenStrip;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader timestampHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader textHeader;
        private System.Windows.Forms.ColumnHeader parentsHeader;
        private System.Windows.Forms.ColumnHeader childrenHeader;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addReplyContext;
        private System.Windows.Forms.ToolStripMenuItem editReplyContext;
        private System.Windows.Forms.ToolStripMenuItem DeleteReplyContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editParentsContext;
        private System.Windows.Forms.ToolStripMenuItem editChildrenContext;
    }
}
