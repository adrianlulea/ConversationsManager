namespace Framework.GUI.Forms.Conversations
{
    partial class SavedDataManagerForm
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
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.databaseName = new System.Windows.Forms.TextBox();
         this.creatingNewData = new System.Windows.Forms.RadioButton();
         this.openingExistingSavedData = new System.Windows.Forms.RadioButton();
         this.cancelButton = new System.Windows.Forms.Button();
         this.doneButton = new System.Windows.Forms.Button();
         this.databaseModeHost = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
         this.splitContainer1.IsSplitterFixed = true;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.databaseName);
         this.splitContainer1.Panel1.Controls.Add(this.creatingNewData);
         this.splitContainer1.Panel1.Controls.Add(this.openingExistingSavedData);
         this.splitContainer1.Panel1.Controls.Add(this.databaseModeHost);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
         this.splitContainer1.Panel2.Controls.Add(this.doneButton);
         this.splitContainer1.Size = new System.Drawing.Size(572, 359);
         this.splitContainer1.SplitterDistance = 323;
         this.splitContainer1.TabIndex = 0;
         this.splitContainer1.TabStop = false;
         // 
         // databaseName
         // 
         this.databaseName.Location = new System.Drawing.Point(192, 9);
         this.databaseName.Name = "databaseName";
         this.databaseName.Size = new System.Drawing.Size(368, 20);
         this.databaseName.TabIndex = 3;
         this.databaseName.TextChanged += new System.EventHandler(this.databaseName_TextChanged);
         // 
         // creatingNewData
         // 
         this.creatingNewData.AutoSize = true;
         this.creatingNewData.Location = new System.Drawing.Point(107, 12);
         this.creatingNewData.Name = "creatingNewData";
         this.creatingNewData.Size = new System.Drawing.Size(79, 17);
         this.creatingNewData.TabIndex = 2;
         this.creatingNewData.Tag = "1";
         this.creatingNewData.Text = "Create new";
         this.creatingNewData.UseVisualStyleBackColor = true;
         this.creatingNewData.CheckedChanged += new System.EventHandler(this.SavedDataManager_StateChanged);
         // 
         // openingExistingSavedData
         // 
         this.openingExistingSavedData.AutoSize = true;
         this.openingExistingSavedData.Checked = true;
         this.openingExistingSavedData.Location = new System.Drawing.Point(12, 12);
         this.openingExistingSavedData.Name = "openingExistingSavedData";
         this.openingExistingSavedData.Size = new System.Drawing.Size(89, 17);
         this.openingExistingSavedData.TabIndex = 1;
         this.openingExistingSavedData.TabStop = true;
         this.openingExistingSavedData.Tag = "0";
         this.openingExistingSavedData.Text = "Open existing";
         this.openingExistingSavedData.UseVisualStyleBackColor = true;
         this.openingExistingSavedData.CheckedChanged += new System.EventHandler(this.SavedDataManager_StateChanged);
         // 
         // cancelButton
         // 
         this.cancelButton.Location = new System.Drawing.Point(12, 3);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(75, 23);
         this.cancelButton.TabIndex = 1;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
         // 
         // doneButton
         // 
         this.doneButton.Enabled = false;
         this.doneButton.Location = new System.Drawing.Point(485, 3);
         this.doneButton.Name = "doneButton";
         this.doneButton.Size = new System.Drawing.Size(75, 23);
         this.doneButton.TabIndex = 0;
         this.doneButton.Text = "Done";
         this.doneButton.UseVisualStyleBackColor = true;
         this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
         // 
         // databaseModeHost
         // 
         this.databaseModeHost.Location = new System.Drawing.Point(12, 35);
         this.databaseModeHost.Name = "databaseModeHost";
         this.databaseModeHost.Size = new System.Drawing.Size(548, 282);
         this.databaseModeHost.TabIndex = 4;
         // 
         // SavedDataManagerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(572, 359);
         this.Controls.Add(this.splitContainer1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "SavedDataManagerForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "SavedDataManager";
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox databaseName;
        private System.Windows.Forms.RadioButton creatingNewData;
        private System.Windows.Forms.RadioButton openingExistingSavedData;
        private System.Windows.Forms.Panel databaseModeHost;
    }
}