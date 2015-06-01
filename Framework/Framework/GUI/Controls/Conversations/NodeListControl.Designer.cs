namespace Framework.GUI.Controls.Conversations
{
    partial class NodeListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeListControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNodeButton = new System.Windows.Forms.ToolStripButton();
            this.removeNodeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.nodeList = new System.Windows.Forms.ListView();
            this.timestampHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childrenHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.replyTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.hideButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveChangesButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeButton,
            this.removeNodeButton,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(349, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNodeButton
            // 
            this.addNodeButton.Image = ((System.Drawing.Image)(resources.GetObject("addNodeButton.Image")));
            this.addNodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(46, 22);
            this.addNodeButton.Text = "Add";
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Enabled = false;
            this.removeNodeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeNodeButton.Image")));
            this.removeNodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(66, 22);
            this.removeNodeButton.Text = "Remove";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "Filter";
            // 
            // nodeList
            // 
            this.nodeList.BackColor = System.Drawing.SystemColors.Info;
            this.nodeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timestampHeader,
            this.authorHeader,
            this.textHeader,
            this.childrenHeader,
            this.parentsHeader});
            this.nodeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodeList.FullRowSelect = true;
            this.nodeList.GridLines = true;
            this.nodeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.nodeList.Location = new System.Drawing.Point(0, 0);
            this.nodeList.MultiSelect = false;
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(349, 80);
            this.nodeList.TabIndex = 1;
            this.nodeList.UseCompatibleStateImageBehavior = false;
            this.nodeList.View = System.Windows.Forms.View.Details;
            this.nodeList.SelectedIndexChanged += new System.EventHandler(this.nodeList_SelectedIndexChanged);
            this.nodeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nodeList_OpenedItem);
            // 
            // timestampHeader
            // 
            this.timestampHeader.Text = "Timestamp";
            this.timestampHeader.Width = 63;
            // 
            // authorHeader
            // 
            this.authorHeader.Text = "Author";
            this.authorHeader.Width = 71;
            // 
            // textHeader
            // 
            this.textHeader.Text = "Text";
            this.textHeader.Width = 152;
            // 
            // childrenHeader
            // 
            this.childrenHeader.Text = "C";
            this.childrenHeader.Width = 28;
            // 
            // parentsHeader
            // 
            this.parentsHeader.Text = "P";
            this.parentsHeader.Width = 28;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.nodeList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(351, 166);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 2;
            // 
            // replyTextBox
            // 
            this.replyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.replyTextBox.Location = new System.Drawing.Point(56, 54);
            this.replyTextBox.Name = "replyTextBox";
            this.replyTextBox.Size = new System.Drawing.Size(288, 16);
            this.replyTextBox.TabIndex = 4;
            this.replyTextBox.Tag = "1";
            this.replyTextBox.Text = "";
            this.replyTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text : ";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(56, 28);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(170, 20);
            this.authorTextBox.TabIndex = 2;
            this.authorTextBox.Tag = "0";
            this.authorTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideButton,
            this.toolStripSeparator2,
            this.saveChangesButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(347, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // hideButton
            // 
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(48, 22);
            this.hideButton.Text = "Hide";
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesButton.Image")));
            this.saveChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(94, 22);
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.replyTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 78);
            this.panel1.TabIndex = 5;
            // 
            // NodeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(351, 166);
            this.Name = "NodeListControl";
            this.Size = new System.Drawing.Size(351, 166);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNodeButton;
        private System.Windows.Forms.ToolStripButton removeNodeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ListView nodeList;
        private System.Windows.Forms.ColumnHeader timestampHeader;
        private System.Windows.Forms.ColumnHeader authorHeader;
        private System.Windows.Forms.ColumnHeader textHeader;
        private System.Windows.Forms.ColumnHeader childrenHeader;
        private System.Windows.Forms.ColumnHeader parentsHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton hideButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton saveChangesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.RichTextBox replyTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}
