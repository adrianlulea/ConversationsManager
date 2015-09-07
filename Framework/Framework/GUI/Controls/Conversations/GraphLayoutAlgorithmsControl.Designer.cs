namespace Framework.GUI.Controls.Conversations
{
   partial class GraphLayoutAlgorithmsControl
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
         this.defaultAlgorithmGroupBox = new System.Windows.Forms.GroupBox();
         this.refreshEntireGraphWhenEditingCheckBox = new System.Windows.Forms.CheckBox();
         this.verticalGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.verticalGapLabel = new System.Windows.Forms.Label();
         this.horizontalGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.horizontalGapLabel = new System.Windows.Forms.Label();
         this.defaultOverlapRemovalAlgorithmListComboBox = new System.Windows.Forms.ComboBox();
         this.overlapRemovalAlgorithmLabel = new System.Windows.Forms.Label();
         this.defaultAlgorithmListComboBox = new System.Windows.Forms.ComboBox();
         this.defaultLayoutAlgorithmLabel = new System.Windows.Forms.Label();
         this.customAlgorithmDetailsGroupBox = new System.Windows.Forms.GroupBox();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter = new System.Windows.Forms.SplitContainer();
         this.selectedCustomAlgorithmLibraryLabel = new System.Windows.Forms.Label();
         this.selectedCustomAlgorithmNameLabel = new System.Windows.Forms.Label();
         this.libraryLabel = new System.Windows.Forms.Label();
         this.algorithmLabel = new System.Windows.Forms.Label();
         this.availableCustomAlgorithmsHost = new System.Windows.Forms.Panel();
         this.changesVisibleAfterApplicationIsRestartedLabel = new System.Windows.Forms.Label();
         this.customOverlapRemovalDetailsGroupBox = new System.Windows.Forms.GroupBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.selectedCustomOverlapRemovalLibraryLabel = new System.Windows.Forms.Label();
         this.selectedCustomOverlapRemovalNameLabel = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.availableCustomOverlapRemovalAlgorithmsHost = new System.Windows.Forms.Panel();
         this.noCustomAlgorithmSelected = new System.Windows.Forms.Label();
         this.defaultAlgorithmGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.verticalGapNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.horizontalGapNumericUpDown)).BeginInit();
         this.customAlgorithmDetailsGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter)).BeginInit();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.SuspendLayout();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel2.SuspendLayout();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.SuspendLayout();
         this.customOverlapRemovalDetailsGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.SuspendLayout();
         // 
         // defaultAlgorithmGroupBox
         // 
         this.defaultAlgorithmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.defaultAlgorithmGroupBox.Controls.Add(this.refreshEntireGraphWhenEditingCheckBox);
         this.defaultAlgorithmGroupBox.Controls.Add(this.verticalGapNumericUpDown);
         this.defaultAlgorithmGroupBox.Controls.Add(this.verticalGapLabel);
         this.defaultAlgorithmGroupBox.Controls.Add(this.horizontalGapNumericUpDown);
         this.defaultAlgorithmGroupBox.Controls.Add(this.horizontalGapLabel);
         this.defaultAlgorithmGroupBox.Controls.Add(this.defaultOverlapRemovalAlgorithmListComboBox);
         this.defaultAlgorithmGroupBox.Controls.Add(this.overlapRemovalAlgorithmLabel);
         this.defaultAlgorithmGroupBox.Controls.Add(this.defaultAlgorithmListComboBox);
         this.defaultAlgorithmGroupBox.Controls.Add(this.defaultLayoutAlgorithmLabel);
         this.defaultAlgorithmGroupBox.Location = new System.Drawing.Point(6, 3);
         this.defaultAlgorithmGroupBox.Name = "defaultAlgorithmGroupBox";
         this.defaultAlgorithmGroupBox.Size = new System.Drawing.Size(678, 72);
         this.defaultAlgorithmGroupBox.TabIndex = 1;
         this.defaultAlgorithmGroupBox.TabStop = false;
         this.defaultAlgorithmGroupBox.Text = "Details";
         // 
         // refreshEntireGraphWhenEditingCheckBox
         // 
         this.refreshEntireGraphWhenEditingCheckBox.AutoSize = true;
         this.refreshEntireGraphWhenEditingCheckBox.Location = new System.Drawing.Point(434, 15);
         this.refreshEntireGraphWhenEditingCheckBox.Name = "refreshEntireGraphWhenEditingCheckBox";
         this.refreshEntireGraphWhenEditingCheckBox.Size = new System.Drawing.Size(153, 17);
         this.refreshEntireGraphWhenEditingCheckBox.TabIndex = 8;
         this.refreshEntireGraphWhenEditingCheckBox.Text = "Always refresh entire graph";
         this.refreshEntireGraphWhenEditingCheckBox.UseVisualStyleBackColor = true;
         this.refreshEntireGraphWhenEditingCheckBox.CheckedChanged += new System.EventHandler(this.refreshEntireGraphWhenEditingCheckBox_CheckedChanged);
         // 
         // verticalGapNumericUpDown
         // 
         this.verticalGapNumericUpDown.Location = new System.Drawing.Point(627, 41);
         this.verticalGapNumericUpDown.Name = "verticalGapNumericUpDown";
         this.verticalGapNumericUpDown.Size = new System.Drawing.Size(48, 20);
         this.verticalGapNumericUpDown.TabIndex = 7;
         this.verticalGapNumericUpDown.ValueChanged += new System.EventHandler(this.verticalGapNumericUpDown_ValueChanged);
         // 
         // verticalGapLabel
         // 
         this.verticalGapLabel.AutoSize = true;
         this.verticalGapLabel.Location = new System.Drawing.Point(560, 43);
         this.verticalGapLabel.Name = "verticalGapLabel";
         this.verticalGapLabel.Size = new System.Drawing.Size(61, 13);
         this.verticalGapLabel.TabIndex = 6;
         this.verticalGapLabel.Text = "Vert. Gap : ";
         // 
         // horizontalGapNumericUpDown
         // 
         this.horizontalGapNumericUpDown.Location = new System.Drawing.Point(506, 41);
         this.horizontalGapNumericUpDown.Name = "horizontalGapNumericUpDown";
         this.horizontalGapNumericUpDown.Size = new System.Drawing.Size(48, 20);
         this.horizontalGapNumericUpDown.TabIndex = 5;
         this.horizontalGapNumericUpDown.ValueChanged += new System.EventHandler(this.horizontalGapNumericUpDown_ValueChanged);
         // 
         // horizontalGapLabel
         // 
         this.horizontalGapLabel.AutoSize = true;
         this.horizontalGapLabel.Location = new System.Drawing.Point(434, 43);
         this.horizontalGapLabel.Name = "horizontalGapLabel";
         this.horizontalGapLabel.Size = new System.Drawing.Size(66, 13);
         this.horizontalGapLabel.TabIndex = 4;
         this.horizontalGapLabel.Text = "Horiz. Gap : ";
         // 
         // defaultOverlapRemovalAlgorithmListComboBox
         // 
         this.defaultOverlapRemovalAlgorithmListComboBox.FormattingEnabled = true;
         this.defaultOverlapRemovalAlgorithmListComboBox.Location = new System.Drawing.Point(156, 40);
         this.defaultOverlapRemovalAlgorithmListComboBox.Name = "defaultOverlapRemovalAlgorithmListComboBox";
         this.defaultOverlapRemovalAlgorithmListComboBox.Size = new System.Drawing.Size(272, 21);
         this.defaultOverlapRemovalAlgorithmListComboBox.TabIndex = 3;
         this.defaultOverlapRemovalAlgorithmListComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultOverlapRemovalAlgorithmListComboBox_SelectedIndexChanged);
         // 
         // overlapRemovalAlgorithmLabel
         // 
         this.overlapRemovalAlgorithmLabel.AutoSize = true;
         this.overlapRemovalAlgorithmLabel.Location = new System.Drawing.Point(6, 43);
         this.overlapRemovalAlgorithmLabel.Name = "overlapRemovalAlgorithmLabel";
         this.overlapRemovalAlgorithmLabel.Size = new System.Drawing.Size(144, 13);
         this.overlapRemovalAlgorithmLabel.TabIndex = 2;
         this.overlapRemovalAlgorithmLabel.Text = "Overlap Removal Algorithm : ";
         // 
         // defaultAlgorithmListComboBox
         // 
         this.defaultAlgorithmListComboBox.FormattingEnabled = true;
         this.defaultAlgorithmListComboBox.Location = new System.Drawing.Point(156, 13);
         this.defaultAlgorithmListComboBox.Name = "defaultAlgorithmListComboBox";
         this.defaultAlgorithmListComboBox.Size = new System.Drawing.Size(272, 21);
         this.defaultAlgorithmListComboBox.TabIndex = 1;
         this.defaultAlgorithmListComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultAlgorithmListComboBox_SelectedIndexChanged);
         // 
         // defaultLayoutAlgorithmLabel
         // 
         this.defaultLayoutAlgorithmLabel.AutoSize = true;
         this.defaultLayoutAlgorithmLabel.Location = new System.Drawing.Point(6, 16);
         this.defaultLayoutAlgorithmLabel.Name = "defaultLayoutAlgorithmLabel";
         this.defaultLayoutAlgorithmLabel.Size = new System.Drawing.Size(94, 13);
         this.defaultLayoutAlgorithmLabel.TabIndex = 0;
         this.defaultLayoutAlgorithmLabel.Text = "Layout Algorithm : ";
         // 
         // customAlgorithmDetailsGroupBox
         // 
         this.customAlgorithmDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.customAlgorithmDetailsGroupBox.Controls.Add(this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter);
         this.customAlgorithmDetailsGroupBox.Enabled = false;
         this.customAlgorithmDetailsGroupBox.Location = new System.Drawing.Point(3, 81);
         this.customAlgorithmDetailsGroupBox.Name = "customAlgorithmDetailsGroupBox";
         this.customAlgorithmDetailsGroupBox.Size = new System.Drawing.Size(681, 333);
         this.customAlgorithmDetailsGroupBox.TabIndex = 3;
         this.customAlgorithmDetailsGroupBox.TabStop = false;
         this.customAlgorithmDetailsGroupBox.Text = "Custom Layout Algorithms";
         // 
         // selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter
         // 
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.IsSplitterFixed = true;
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Location = new System.Drawing.Point(3, 16);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Name = "selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter";
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1
         // 
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.Controls.Add(this.noCustomAlgorithmSelected);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.Controls.Add(this.selectedCustomAlgorithmLibraryLabel);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.Controls.Add(this.selectedCustomAlgorithmNameLabel);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.Controls.Add(this.libraryLabel);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.Controls.Add(this.algorithmLabel);
         // 
         // selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel2
         // 
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel2.Controls.Add(this.availableCustomAlgorithmsHost);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Size = new System.Drawing.Size(675, 314);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.SplitterDistance = 29;
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.TabIndex = 0;
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.TabStop = false;
         // 
         // selectedCustomAlgorithmLibraryLabel
         // 
         this.selectedCustomAlgorithmLibraryLabel.AutoSize = true;
         this.selectedCustomAlgorithmLibraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.selectedCustomAlgorithmLibraryLabel.Location = new System.Drawing.Point(71, 13);
         this.selectedCustomAlgorithmLibraryLabel.Name = "selectedCustomAlgorithmLibraryLabel";
         this.selectedCustomAlgorithmLibraryLabel.Size = new System.Drawing.Size(37, 13);
         this.selectedCustomAlgorithmLibraryLabel.TabIndex = 3;
         this.selectedCustomAlgorithmLibraryLabel.Text = "None";
         // 
         // selectedCustomAlgorithmNameLabel
         // 
         this.selectedCustomAlgorithmNameLabel.AutoSize = true;
         this.selectedCustomAlgorithmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.selectedCustomAlgorithmNameLabel.Location = new System.Drawing.Point(71, 0);
         this.selectedCustomAlgorithmNameLabel.Name = "selectedCustomAlgorithmNameLabel";
         this.selectedCustomAlgorithmNameLabel.Size = new System.Drawing.Size(37, 13);
         this.selectedCustomAlgorithmNameLabel.TabIndex = 2;
         this.selectedCustomAlgorithmNameLabel.Text = "None";
         // 
         // libraryLabel
         // 
         this.libraryLabel.AutoSize = true;
         this.libraryLabel.Location = new System.Drawing.Point(6, 13);
         this.libraryLabel.Name = "libraryLabel";
         this.libraryLabel.Size = new System.Drawing.Size(47, 13);
         this.libraryLabel.TabIndex = 1;
         this.libraryLabel.Text = "Library : ";
         // 
         // algorithmLabel
         // 
         this.algorithmLabel.AutoSize = true;
         this.algorithmLabel.Location = new System.Drawing.Point(6, 0);
         this.algorithmLabel.Name = "algorithmLabel";
         this.algorithmLabel.Size = new System.Drawing.Size(59, 13);
         this.algorithmLabel.TabIndex = 0;
         this.algorithmLabel.Text = "Algorithm : ";
         // 
         // availableCustomAlgorithmsHost
         // 
         this.availableCustomAlgorithmsHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.availableCustomAlgorithmsHost.Location = new System.Drawing.Point(0, 0);
         this.availableCustomAlgorithmsHost.Name = "availableCustomAlgorithmsHost";
         this.availableCustomAlgorithmsHost.Size = new System.Drawing.Size(675, 281);
         this.availableCustomAlgorithmsHost.TabIndex = 0;
         // 
         // changesVisibleAfterApplicationIsRestartedLabel
         // 
         this.changesVisibleAfterApplicationIsRestartedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.changesVisibleAfterApplicationIsRestartedLabel.AutoSize = true;
         this.changesVisibleAfterApplicationIsRestartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.changesVisibleAfterApplicationIsRestartedLabel.ForeColor = System.Drawing.Color.Red;
         this.changesVisibleAfterApplicationIsRestartedLabel.Location = new System.Drawing.Point(3, 417);
         this.changesVisibleAfterApplicationIsRestartedLabel.Name = "changesVisibleAfterApplicationIsRestartedLabel";
         this.changesVisibleAfterApplicationIsRestartedLabel.Size = new System.Drawing.Size(307, 13);
         this.changesVisibleAfterApplicationIsRestartedLabel.TabIndex = 4;
         this.changesVisibleAfterApplicationIsRestartedLabel.Text = "Need to restart application for new algorithm settings";
         this.changesVisibleAfterApplicationIsRestartedLabel.Visible = false;
         // 
         // customOverlapRemovalDetailsGroupBox
         // 
         this.customOverlapRemovalDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.customOverlapRemovalDetailsGroupBox.Controls.Add(this.splitContainer1);
         this.customOverlapRemovalDetailsGroupBox.Enabled = false;
         this.customOverlapRemovalDetailsGroupBox.Location = new System.Drawing.Point(3, 249);
         this.customOverlapRemovalDetailsGroupBox.Name = "customOverlapRemovalDetailsGroupBox";
         this.customOverlapRemovalDetailsGroupBox.Size = new System.Drawing.Size(681, 165);
         this.customOverlapRemovalDetailsGroupBox.TabIndex = 4;
         this.customOverlapRemovalDetailsGroupBox.TabStop = false;
         this.customOverlapRemovalDetailsGroupBox.Text = "Custom Overlap Removal Algorithms";
         this.customOverlapRemovalDetailsGroupBox.Visible = false;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer1.IsSplitterFixed = true;
         this.splitContainer1.Location = new System.Drawing.Point(3, 16);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.selectedCustomOverlapRemovalLibraryLabel);
         this.splitContainer1.Panel1.Controls.Add(this.selectedCustomOverlapRemovalNameLabel);
         this.splitContainer1.Panel1.Controls.Add(this.label3);
         this.splitContainer1.Panel1.Controls.Add(this.label4);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.availableCustomOverlapRemovalAlgorithmsHost);
         this.splitContainer1.Size = new System.Drawing.Size(675, 146);
         this.splitContainer1.SplitterDistance = 29;
         this.splitContainer1.TabIndex = 0;
         this.splitContainer1.TabStop = false;
         // 
         // selectedCustomOverlapRemovalLibraryLabel
         // 
         this.selectedCustomOverlapRemovalLibraryLabel.AutoSize = true;
         this.selectedCustomOverlapRemovalLibraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.selectedCustomOverlapRemovalLibraryLabel.Location = new System.Drawing.Point(71, 13);
         this.selectedCustomOverlapRemovalLibraryLabel.Name = "selectedCustomOverlapRemovalLibraryLabel";
         this.selectedCustomOverlapRemovalLibraryLabel.Size = new System.Drawing.Size(37, 13);
         this.selectedCustomOverlapRemovalLibraryLabel.TabIndex = 3;
         this.selectedCustomOverlapRemovalLibraryLabel.Text = "None";
         // 
         // selectedCustomOverlapRemovalNameLabel
         // 
         this.selectedCustomOverlapRemovalNameLabel.AutoSize = true;
         this.selectedCustomOverlapRemovalNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.selectedCustomOverlapRemovalNameLabel.Location = new System.Drawing.Point(71, 0);
         this.selectedCustomOverlapRemovalNameLabel.Name = "selectedCustomOverlapRemovalNameLabel";
         this.selectedCustomOverlapRemovalNameLabel.Size = new System.Drawing.Size(37, 13);
         this.selectedCustomOverlapRemovalNameLabel.TabIndex = 2;
         this.selectedCustomOverlapRemovalNameLabel.Text = "None";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 13);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(47, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Library : ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(59, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Algorithm : ";
         // 
         // availableCustomOverlapRemovalAlgorithmsHost
         // 
         this.availableCustomOverlapRemovalAlgorithmsHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.availableCustomOverlapRemovalAlgorithmsHost.Location = new System.Drawing.Point(0, 0);
         this.availableCustomOverlapRemovalAlgorithmsHost.Name = "availableCustomOverlapRemovalAlgorithmsHost";
         this.availableCustomOverlapRemovalAlgorithmsHost.Size = new System.Drawing.Size(675, 113);
         this.availableCustomOverlapRemovalAlgorithmsHost.TabIndex = 0;
         // 
         // noCustomAlgorithmSelected
         // 
         this.noCustomAlgorithmSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.noCustomAlgorithmSelected.AutoSize = true;
         this.noCustomAlgorithmSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.noCustomAlgorithmSelected.ForeColor = System.Drawing.Color.Red;
         this.noCustomAlgorithmSelected.Location = new System.Drawing.Point(498, 0);
         this.noCustomAlgorithmSelected.Name = "noCustomAlgorithmSelected";
         this.noCustomAlgorithmSelected.Size = new System.Drawing.Size(174, 13);
         this.noCustomAlgorithmSelected.TabIndex = 5;
         this.noCustomAlgorithmSelected.Text = "No custom algorithm selected";
         this.noCustomAlgorithmSelected.Visible = false;
         // 
         // GraphLayoutAlgorithmsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.customOverlapRemovalDetailsGroupBox);
         this.Controls.Add(this.changesVisibleAfterApplicationIsRestartedLabel);
         this.Controls.Add(this.customAlgorithmDetailsGroupBox);
         this.Controls.Add(this.defaultAlgorithmGroupBox);
         this.Name = "GraphLayoutAlgorithmsControl";
         this.Size = new System.Drawing.Size(684, 430);
         this.defaultAlgorithmGroupBox.ResumeLayout(false);
         this.defaultAlgorithmGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.verticalGapNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.horizontalGapNumericUpDown)).EndInit();
         this.customAlgorithmDetailsGroupBox.ResumeLayout(false);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.ResumeLayout(false);
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel1.PerformLayout();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter)).EndInit();
         this.selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter.ResumeLayout(false);
         this.customOverlapRemovalDetailsGroupBox.ResumeLayout(false);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox defaultAlgorithmGroupBox;
      private System.Windows.Forms.ComboBox defaultAlgorithmListComboBox;
      private System.Windows.Forms.Label defaultLayoutAlgorithmLabel;
      private System.Windows.Forms.NumericUpDown verticalGapNumericUpDown;
      private System.Windows.Forms.Label verticalGapLabel;
      private System.Windows.Forms.NumericUpDown horizontalGapNumericUpDown;
      private System.Windows.Forms.Label horizontalGapLabel;
      private System.Windows.Forms.ComboBox defaultOverlapRemovalAlgorithmListComboBox;
      private System.Windows.Forms.Label overlapRemovalAlgorithmLabel;
      private System.Windows.Forms.GroupBox customAlgorithmDetailsGroupBox;
      private System.Windows.Forms.CheckBox refreshEntireGraphWhenEditingCheckBox;
      private System.Windows.Forms.Label changesVisibleAfterApplicationIsRestartedLabel;
      private System.Windows.Forms.SplitContainer selectedCustomAlgorithmAvailableCustomAlgorithmsSplitter;
      private System.Windows.Forms.Label selectedCustomAlgorithmLibraryLabel;
      private System.Windows.Forms.Label selectedCustomAlgorithmNameLabel;
      private System.Windows.Forms.Label libraryLabel;
      private System.Windows.Forms.Label algorithmLabel;
      private System.Windows.Forms.Panel availableCustomAlgorithmsHost;
      private System.Windows.Forms.GroupBox customOverlapRemovalDetailsGroupBox;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Label selectedCustomOverlapRemovalLibraryLabel;
      private System.Windows.Forms.Label selectedCustomOverlapRemovalNameLabel;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Panel availableCustomOverlapRemovalAlgorithmsHost;
      private System.Windows.Forms.Label noCustomAlgorithmSelected;
   }
}
