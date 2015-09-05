namespace Framework.GUI.Forms.Conversations
{
    partial class ConversationsManager
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversationsManager));
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.newMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.openMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.saveMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.exitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.preferencesMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.tutorialMainMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.conversationsToolStrip = new System.Windows.Forms.ToolStrip();
         this.addButton = new System.Windows.Forms.ToolStripSplitButton();
         this.addReplyOption = new System.Windows.Forms.ToolStripMenuItem();
         this.addParentOption = new System.Windows.Forms.ToolStripMenuItem();
         this.addChildOption = new System.Windows.Forms.ToolStripMenuItem();
         this.linkNodeButton = new System.Windows.Forms.ToolStripButton();
         this.removeReplyButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.showParentsButton = new System.Windows.Forms.ToolStripButton();
         this.showChildrenButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.filterTextBox = new System.Windows.Forms.ToolStripTextBox();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.showGraphButton = new System.Windows.Forms.ToolStripDropDownButton();
         this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.conversationsHost = new System.Windows.Forms.Panel();
         this.nodesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.addReplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.addReplyContext = new System.Windows.Forms.ToolStripMenuItem();
         this.addParentContext = new System.Windows.Forms.ToolStripMenuItem();
         this.addChildContext = new System.Windows.Forms.ToolStripMenuItem();
         this.removeReplyContext = new System.Windows.Forms.ToolStripMenuItem();
         this.childrenParentsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.addContext = new System.Windows.Forms.ToolStripMenuItem();
         this.removeContext = new System.Windows.Forms.ToolStripMenuItem();
         this.mainMenu.SuspendLayout();
         this.conversationsToolStrip.SuspendLayout();
         this.nodesContextMenu.SuspendLayout();
         this.childrenParentsContextMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // mainMenu
         // 
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.optionsMenu,
            this.helpMenu});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Size = new System.Drawing.Size(1016, 24);
         this.mainMenu.TabIndex = 1;
         this.mainMenu.Text = "mainMenu";
         // 
         // fileMenu
         // 
         this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMainMenu,
            this.openMainMenu,
            this.saveMainMenu,
            this.saveAsMainMenu,
            this.exitMainMenu});
         this.fileMenu.Name = "fileMenu";
         this.fileMenu.Size = new System.Drawing.Size(37, 20);
         this.fileMenu.Text = "File";
         // 
         // newMainMenu
         // 
         this.newMainMenu.Image = global::Framework.Properties.Resources.New;
         this.newMainMenu.Name = "newMainMenu";
         this.newMainMenu.Size = new System.Drawing.Size(114, 22);
         this.newMainMenu.Text = "New";
         this.newMainMenu.Click += new System.EventHandler(this.newMainMenu_Click);
         // 
         // openMainMenu
         // 
         this.openMainMenu.Image = global::Framework.Properties.Resources.Open;
         this.openMainMenu.Name = "openMainMenu";
         this.openMainMenu.Size = new System.Drawing.Size(114, 22);
         this.openMainMenu.Text = "Open";
         this.openMainMenu.Click += new System.EventHandler(this.openMainMenu_Click);
         // 
         // saveMainMenu
         // 
         this.saveMainMenu.Enabled = false;
         this.saveMainMenu.Image = global::Framework.Properties.Resources.Save;
         this.saveMainMenu.Name = "saveMainMenu";
         this.saveMainMenu.Size = new System.Drawing.Size(114, 22);
         this.saveMainMenu.Text = "Save";
         this.saveMainMenu.Click += new System.EventHandler(this.saveMainMenu_Click);
         // 
         // saveAsMainMenu
         // 
         this.saveAsMainMenu.Enabled = false;
         this.saveAsMainMenu.Name = "saveAsMainMenu";
         this.saveAsMainMenu.Size = new System.Drawing.Size(114, 22);
         this.saveAsMainMenu.Text = "Save As";
         this.saveAsMainMenu.Click += new System.EventHandler(this.saveAsMainMenu_Click);
         // 
         // exitMainMenu
         // 
         this.exitMainMenu.Name = "exitMainMenu";
         this.exitMainMenu.Size = new System.Drawing.Size(114, 22);
         this.exitMainMenu.Text = "Exit";
         this.exitMainMenu.Click += new System.EventHandler(this.exitMainMenu_Click);
         // 
         // optionsMenu
         // 
         this.optionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesMainMenu});
         this.optionsMenu.Name = "optionsMenu";
         this.optionsMenu.Size = new System.Drawing.Size(61, 20);
         this.optionsMenu.Text = "Options";
         // 
         // preferencesMainMenu
         // 
         this.preferencesMainMenu.Image = global::Framework.Properties.Resources.Settings;
         this.preferencesMainMenu.Name = "preferencesMainMenu";
         this.preferencesMainMenu.Size = new System.Drawing.Size(135, 22);
         this.preferencesMainMenu.Text = "Preferences";
         this.preferencesMainMenu.Click += new System.EventHandler(this.preferencesMainMenu_Click);
         // 
         // helpMenu
         // 
         this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMainMenu,
            this.tutorialMainMenu});
         this.helpMenu.Name = "helpMenu";
         this.helpMenu.Size = new System.Drawing.Size(44, 20);
         this.helpMenu.Text = "Help";
         // 
         // aboutMainMenu
         // 
         this.aboutMainMenu.Image = global::Framework.Properties.Resources.Info;
         this.aboutMainMenu.Name = "aboutMainMenu";
         this.aboutMainMenu.Size = new System.Drawing.Size(115, 22);
         this.aboutMainMenu.Text = "About";
         this.aboutMainMenu.Click += new System.EventHandler(this.aboutMainMenu_Click);
         // 
         // tutorialMainMenu
         // 
         this.tutorialMainMenu.Image = global::Framework.Properties.Resources.Tutorial;
         this.tutorialMainMenu.Name = "tutorialMainMenu";
         this.tutorialMainMenu.Size = new System.Drawing.Size(115, 22);
         this.tutorialMainMenu.Text = "Tutorial";
         this.tutorialMainMenu.Click += new System.EventHandler(this.tutorialMainMenu_Click);
         // 
         // conversationsToolStrip
         // 
         this.conversationsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.linkNodeButton,
            this.removeReplyButton,
            this.toolStripSeparator1,
            this.showParentsButton,
            this.showChildrenButton,
            this.toolStripSeparator2,
            this.filterTextBox,
            this.toolStripSeparator3,
            this.showGraphButton});
         this.conversationsToolStrip.Location = new System.Drawing.Point(0, 24);
         this.conversationsToolStrip.Name = "conversationsToolStrip";
         this.conversationsToolStrip.Size = new System.Drawing.Size(1016, 25);
         this.conversationsToolStrip.TabIndex = 2;
         this.conversationsToolStrip.Text = "toolStrip1";
         this.conversationsToolStrip.Visible = false;
         // 
         // addButton
         // 
         this.addButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReplyOption,
            this.addParentOption,
            this.addChildOption});
         this.addButton.Image = global::Framework.Properties.Resources.Add;
         this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(61, 22);
         this.addButton.Tag = "5";
         this.addButton.Text = "Add";
         this.addButton.ButtonClick += new System.EventHandler(this.addButton_Click);
         // 
         // addReplyOption
         // 
         this.addReplyOption.Image = global::Framework.Properties.Resources.Conversation;
         this.addReplyOption.Name = "addReplyOption";
         this.addReplyOption.Size = new System.Drawing.Size(108, 22);
         this.addReplyOption.Tag = "0";
         this.addReplyOption.Text = "Reply";
         this.addReplyOption.Click += new System.EventHandler(this.addButton_Click);
         // 
         // addParentOption
         // 
         this.addParentOption.Enabled = false;
         this.addParentOption.Image = global::Framework.Properties.Resources.Parents;
         this.addParentOption.Name = "addParentOption";
         this.addParentOption.Size = new System.Drawing.Size(108, 22);
         this.addParentOption.Tag = "1";
         this.addParentOption.Text = "Parent";
         this.addParentOption.Click += new System.EventHandler(this.addButton_Click);
         // 
         // addChildOption
         // 
         this.addChildOption.Enabled = false;
         this.addChildOption.Image = global::Framework.Properties.Resources.Children;
         this.addChildOption.Name = "addChildOption";
         this.addChildOption.Size = new System.Drawing.Size(108, 22);
         this.addChildOption.Tag = "2";
         this.addChildOption.Text = "Child";
         this.addChildOption.Click += new System.EventHandler(this.addButton_Click);
         // 
         // linkNodeButton
         // 
         this.linkNodeButton.Enabled = false;
         this.linkNodeButton.Image = global::Framework.Properties.Resources._1434396944_chain_link;
         this.linkNodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.linkNodeButton.Name = "linkNodeButton";
         this.linkNodeButton.Size = new System.Drawing.Size(49, 22);
         this.linkNodeButton.Text = "Link";
         this.linkNodeButton.Visible = false;
         this.linkNodeButton.Click += new System.EventHandler(this.linkNodeButton_Click);
         // 
         // removeReplyButton
         // 
         this.removeReplyButton.Enabled = false;
         this.removeReplyButton.Image = global::Framework.Properties.Resources.Delete;
         this.removeReplyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.removeReplyButton.Name = "removeReplyButton";
         this.removeReplyButton.Size = new System.Drawing.Size(70, 22);
         this.removeReplyButton.Text = "Remove";
         this.removeReplyButton.Click += new System.EventHandler(this.removeReplyButton_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // showParentsButton
         // 
         this.showParentsButton.Image = global::Framework.Properties.Resources.Parents;
         this.showParentsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.showParentsButton.Name = "showParentsButton";
         this.showParentsButton.Size = new System.Drawing.Size(66, 22);
         this.showParentsButton.Text = "Parents";
         this.showParentsButton.Click += new System.EventHandler(this.showParentsButton_Click);
         // 
         // showChildrenButton
         // 
         this.showChildrenButton.Image = global::Framework.Properties.Resources.Children;
         this.showChildrenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.showChildrenButton.Name = "showChildrenButton";
         this.showChildrenButton.Size = new System.Drawing.Size(72, 22);
         this.showChildrenButton.Text = "Children";
         this.showChildrenButton.Click += new System.EventHandler(this.showChildrenButton_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // filterTextBox
         // 
         this.filterTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
         this.filterTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
         this.filterTextBox.Name = "filterTextBox";
         this.filterTextBox.Size = new System.Drawing.Size(150, 25);
         this.filterTextBox.Text = "Filter";
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
         // 
         // showGraphButton
         // 
         this.showGraphButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.bothToolStripMenuItem});
         this.showGraphButton.Image = global::Framework.Properties.Resources.BasicInformation;
         this.showGraphButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.showGraphButton.Name = "showGraphButton";
         this.showGraphButton.Size = new System.Drawing.Size(76, 22);
         this.showGraphButton.Text = "Normal";
         this.showGraphButton.Click += new System.EventHandler(this.showGraphButton_Click);
         // 
         // normalToolStripMenuItem
         // 
         this.normalToolStripMenuItem.Image = global::Framework.Properties.Resources.BasicInformation;
         this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
         this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.normalToolStripMenuItem.Text = "Normal";
         this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
         // 
         // graphToolStripMenuItem
         // 
         this.graphToolStripMenuItem.Image = global::Framework.Properties.Resources.Graph;
         this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
         this.graphToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.graphToolStripMenuItem.Text = "Graph";
         this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
         // 
         // bothToolStripMenuItem
         // 
         this.bothToolStripMenuItem.Image = global::Framework.Properties.Resources.Normal;
         this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
         this.bothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.bothToolStripMenuItem.Text = "Split View";
         this.bothToolStripMenuItem.Click += new System.EventHandler(this.bothToolStripMenuItem_Click);
         // 
         // conversationsHost
         // 
         this.conversationsHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.conversationsHost.Location = new System.Drawing.Point(0, 49);
         this.conversationsHost.Name = "conversationsHost";
         this.conversationsHost.Size = new System.Drawing.Size(1016, 692);
         this.conversationsHost.TabIndex = 3;
         // 
         // nodesContextMenu
         // 
         this.nodesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReplyToolStripMenuItem,
            this.removeReplyContext});
         this.nodesContextMenu.Name = "nodesContextMenu";
         this.nodesContextMenu.Size = new System.Drawing.Size(129, 48);
         // 
         // addReplyToolStripMenuItem
         // 
         this.addReplyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReplyContext,
            this.addParentContext,
            this.addChildContext});
         this.addReplyToolStripMenuItem.Image = global::Framework.Properties.Resources.Add;
         this.addReplyToolStripMenuItem.Name = "addReplyToolStripMenuItem";
         this.addReplyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
         this.addReplyToolStripMenuItem.Text = "Add Reply";
         // 
         // addReplyContext
         // 
         this.addReplyContext.Image = global::Framework.Properties.Resources.Conversation;
         this.addReplyContext.Name = "addReplyContext";
         this.addReplyContext.Size = new System.Drawing.Size(108, 22);
         this.addReplyContext.Tag = "0";
         this.addReplyContext.Text = "Reply";
         this.addReplyContext.Click += new System.EventHandler(this.addButton_Click);
         // 
         // addParentContext
         // 
         this.addParentContext.Enabled = false;
         this.addParentContext.Image = global::Framework.Properties.Resources.Parents;
         this.addParentContext.Name = "addParentContext";
         this.addParentContext.Size = new System.Drawing.Size(108, 22);
         this.addParentContext.Tag = "1";
         this.addParentContext.Text = "Parent";
         this.addParentContext.Click += new System.EventHandler(this.addButton_Click);
         // 
         // addChildContext
         // 
         this.addChildContext.Enabled = false;
         this.addChildContext.Image = global::Framework.Properties.Resources.Children;
         this.addChildContext.Name = "addChildContext";
         this.addChildContext.Size = new System.Drawing.Size(108, 22);
         this.addChildContext.Tag = "2";
         this.addChildContext.Text = "Child";
         this.addChildContext.Click += new System.EventHandler(this.addButton_Click);
         // 
         // removeReplyContext
         // 
         this.removeReplyContext.Enabled = false;
         this.removeReplyContext.Image = global::Framework.Properties.Resources.Delete;
         this.removeReplyContext.Name = "removeReplyContext";
         this.removeReplyContext.Size = new System.Drawing.Size(128, 22);
         this.removeReplyContext.Text = "Remove";
         this.removeReplyContext.Click += new System.EventHandler(this.removeReplyButton_Click);
         // 
         // childrenParentsContextMenu
         // 
         this.childrenParentsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContext,
            this.removeContext});
         this.childrenParentsContextMenu.Name = "childrenParentsContextMenu";
         this.childrenParentsContextMenu.Size = new System.Drawing.Size(118, 48);
         this.childrenParentsContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.childrenParentsContextMenu_Opening);
         // 
         // addContext
         // 
         this.addContext.Enabled = false;
         this.addContext.Image = global::Framework.Properties.Resources.Add;
         this.addContext.Name = "addContext";
         this.addContext.Size = new System.Drawing.Size(117, 22);
         this.addContext.Text = "Add";
         this.addContext.Click += new System.EventHandler(this.addButton_Click);
         // 
         // removeContext
         // 
         this.removeContext.Enabled = false;
         this.removeContext.Image = global::Framework.Properties.Resources.Delete;
         this.removeContext.Name = "removeContext";
         this.removeContext.Size = new System.Drawing.Size(117, 22);
         this.removeContext.Text = "Remove";
         this.removeContext.Click += new System.EventHandler(this.removeReplyButton_Click);
         // 
         // ConversationsManager
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1016, 741);
         this.Controls.Add(this.conversationsHost);
         this.Controls.Add(this.conversationsToolStrip);
         this.Controls.Add(this.mainMenu);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.mainMenu;
         this.MinimumSize = new System.Drawing.Size(1024, 768);
         this.Name = "ConversationsManager";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Conversations Manager";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.conversationsToolStrip.ResumeLayout(false);
         this.conversationsToolStrip.PerformLayout();
         this.nodesContextMenu.ResumeLayout(false);
         this.childrenParentsContextMenu.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMainMenu;
        private System.Windows.Forms.ToolStripMenuItem openMainMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMainMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesMainMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tutorialMainMenu;
        private System.Windows.Forms.ToolStrip conversationsToolStrip;
        private System.Windows.Forms.ToolStripButton removeReplyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton showParentsButton;
        private System.Windows.Forms.ToolStripButton showChildrenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox filterTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel conversationsHost;
        private System.Windows.Forms.ToolStripSplitButton addButton;
        private System.Windows.Forms.ToolStripMenuItem addReplyOption;
        private System.Windows.Forms.ToolStripMenuItem addParentOption;
        private System.Windows.Forms.ToolStripMenuItem addChildOption;
        private System.Windows.Forms.ContextMenuStrip nodesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addReplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReplyContext;
        private System.Windows.Forms.ToolStripMenuItem addChildContext;
        private System.Windows.Forms.ToolStripMenuItem addParentContext;
        private System.Windows.Forms.ToolStripMenuItem removeReplyContext;
        private System.Windows.Forms.ContextMenuStrip childrenParentsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addContext;
        private System.Windows.Forms.ToolStripMenuItem removeContext;
        private System.Windows.Forms.ToolStripButton linkNodeButton;
        private System.Windows.Forms.ToolStripDropDownButton showGraphButton;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
    }
}

