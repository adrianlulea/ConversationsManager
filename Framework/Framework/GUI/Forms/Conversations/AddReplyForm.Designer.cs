using Framework.Util;

namespace Framework.GUI.Forms.Conversations
{
    partial class AddReplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReplyForm));
            this.userDataRadioButton = new System.Windows.Forms.RadioButton();
            this.xmlDataRadioButton = new System.Windows.Forms.RadioButton();
            this.browseXmlButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cancelButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.importReplyButton = new System.Windows.Forms.Button();
            this.replyDataHost = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.replyDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.basicInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addReplyButton = new System.Windows.Forms.ToolStripButton();
            this.removeReplyButton = new System.Windows.Forms.ToolStripButton();
            this.browseXMLFile = new System.Windows.Forms.OpenFileDialog();
            this.tempConsole = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDataRadioButton
            // 
            this.userDataRadioButton.AutoSize = true;
            this.userDataRadioButton.Checked = true;
            this.userDataRadioButton.Location = new System.Drawing.Point(12, 12);
            this.userDataRadioButton.Name = "userDataRadioButton";
            this.userDataRadioButton.Size = new System.Drawing.Size(71, 17);
            this.userDataRadioButton.TabIndex = 0;
            this.userDataRadioButton.TabStop = true;
            this.userDataRadioButton.Tag = "0";
            this.userDataRadioButton.Text = "From user";
            this.userDataRadioButton.UseVisualStyleBackColor = true;
            this.userDataRadioButton.CheckedChanged += new System.EventHandler(this.userDataRadioButton_CheckedChanged);
            // 
            // xmlDataRadioButton
            // 
            this.xmlDataRadioButton.AutoSize = true;
            this.xmlDataRadioButton.Location = new System.Drawing.Point(89, 12);
            this.xmlDataRadioButton.Name = "xmlDataRadioButton";
            this.xmlDataRadioButton.Size = new System.Drawing.Size(89, 17);
            this.xmlDataRadioButton.TabIndex = 1;
            this.xmlDataRadioButton.Tag = "1";
            this.xmlDataRadioButton.Text = "From XML file";
            this.xmlDataRadioButton.UseVisualStyleBackColor = true;
            this.xmlDataRadioButton.CheckedChanged += new System.EventHandler(this.userDataRadioButton_CheckedChanged);
            // 
            // browseXmlButton
            // 
            this.browseXmlButton.Enabled = false;
            this.browseXmlButton.Location = new System.Drawing.Point(184, 9);
            this.browseXmlButton.Name = "browseXmlButton";
            this.browseXmlButton.Size = new System.Drawing.Size(75, 23);
            this.browseXmlButton.TabIndex = 2;
            this.browseXmlButton.Text = "Browse";
            this.browseXmlButton.UseVisualStyleBackColor = true;
            this.browseXmlButton.Click += new System.EventHandler(this.browseXmlButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tempConsole);
            this.splitContainer1.Panel1.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel1.Controls.Add(this.doneButton);
            this.splitContainer1.Panel1.Controls.Add(this.importReplyButton);
            this.splitContainer1.Panel1.Controls.Add(this.userDataRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.browseXmlButton);
            this.splitContainer1.Panel1.Controls.Add(this.xmlDataRadioButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.replyDataHost);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(525, 401);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(357, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Location = new System.Drawing.Point(438, 9);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // importReplyButton
            // 
            this.importReplyButton.Enabled = false;
            this.importReplyButton.Location = new System.Drawing.Point(265, 9);
            this.importReplyButton.Name = "importReplyButton";
            this.importReplyButton.Size = new System.Drawing.Size(75, 23);
            this.importReplyButton.TabIndex = 3;
            this.importReplyButton.Text = "Import";
            this.importReplyButton.UseVisualStyleBackColor = true;
            this.importReplyButton.Click += new System.EventHandler(this.importReplyButton_Click);
            // 
            // replyDataHost
            // 
            this.replyDataHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replyDataHost.Location = new System.Drawing.Point(0, 25);
            this.replyDataHost.Name = "replyDataHost";
            this.replyDataHost.Size = new System.Drawing.Size(525, 334);
            this.replyDataHost.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replyDropDownButton,
            this.toolStripSeparator1,
            this.addReplyButton,
            this.removeReplyButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // replyDropDownButton
            // 
            this.replyDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicInformationToolStripMenuItem,
            this.childrenToolStripMenuItem,
            this.parentsToolStripMenuItem});
            this.replyDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("replyDropDownButton.Image")));
            this.replyDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.replyDropDownButton.Name = "replyDropDownButton";
            this.replyDropDownButton.Size = new System.Drawing.Size(129, 22);
            this.replyDropDownButton.Text = "Basic Information";
            // 
            // basicInformationToolStripMenuItem
            // 
            this.basicInformationToolStripMenuItem.Name = "basicInformationToolStripMenuItem";
            this.basicInformationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.basicInformationToolStripMenuItem.Tag = "0";
            this.basicInformationToolStripMenuItem.Text = "Basic Information";
            this.basicInformationToolStripMenuItem.Click += new System.EventHandler(this.replyDataMode_Changed);
            // 
            // childrenToolStripMenuItem
            // 
            this.childrenToolStripMenuItem.Name = "childrenToolStripMenuItem";
            this.childrenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.childrenToolStripMenuItem.Tag = "1";
            this.childrenToolStripMenuItem.Text = "Children";
            this.childrenToolStripMenuItem.Click += new System.EventHandler(this.replyDataMode_Changed);
            // 
            // parentsToolStripMenuItem
            // 
            this.parentsToolStripMenuItem.Name = "parentsToolStripMenuItem";
            this.parentsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.parentsToolStripMenuItem.Tag = "2";
            this.parentsToolStripMenuItem.Text = "Parents";
            this.parentsToolStripMenuItem.Click += new System.EventHandler(this.replyDataMode_Changed);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addReplyButton
            // 
            this.addReplyButton.Image = ((System.Drawing.Image)(resources.GetObject("addReplyButton.Image")));
            this.addReplyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addReplyButton.Name = "addReplyButton";
            this.addReplyButton.Size = new System.Drawing.Size(49, 22);
            this.addReplyButton.Text = "Add";
            this.addReplyButton.Visible = false;
            this.addReplyButton.Click += new System.EventHandler(this.addReplyButton_Click);
            // 
            // removeReplyButton
            // 
            this.removeReplyButton.Enabled = false;
            this.removeReplyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeReplyButton.Image")));
            this.removeReplyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeReplyButton.Name = "removeReplyButton";
            this.removeReplyButton.Size = new System.Drawing.Size(70, 22);
            this.removeReplyButton.Text = "Remove";
            this.removeReplyButton.Visible = false;
            this.removeReplyButton.Click += new System.EventHandler(this.removeReplyButton_Click);
            // 
            // browseXMLFile
            // 
            this.browseXMLFile.Filter = "XML Files|*.xml";
            this.browseXMLFile.Title = "Import reply";
            // 
            // tempConsole
            // 
            this.tempConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempConsole.Location = new System.Drawing.Point(12, 35);
            this.tempConsole.Name = "tempConsole";
            this.tempConsole.Size = new System.Drawing.Size(501, 0);
            this.tempConsole.TabIndex = 6;
            this.tempConsole.Text = "";
            // 
            // AddReplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 401);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add reply";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton userDataRadioButton;
        private System.Windows.Forms.RadioButton xmlDataRadioButton;
        private System.Windows.Forms.Button browseXmlButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button importReplyButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton replyDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem childrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton addReplyButton;
        private System.Windows.Forms.ToolStripButton removeReplyButton;
        private System.Windows.Forms.ToolStripMenuItem basicInformationToolStripMenuItem;
        private System.Windows.Forms.Panel replyDataHost;
        private System.Windows.Forms.OpenFileDialog browseXMLFile;
        private System.Windows.Forms.RichTextBox tempConsole;
    }
}