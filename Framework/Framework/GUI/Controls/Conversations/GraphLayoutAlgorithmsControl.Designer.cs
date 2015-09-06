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
         this.verticalGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.verticalGapLabel = new System.Windows.Forms.Label();
         this.horizontalGapNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.horizontalGapLabel = new System.Windows.Forms.Label();
         this.defaultOverlapRemovalAlgorithmListComboBox = new System.Windows.Forms.ComboBox();
         this.overlapRemovalAlgorithmLabel = new System.Windows.Forms.Label();
         this.defaultAlgorithmListComboBox = new System.Windows.Forms.ComboBox();
         this.defaultLayoutAlgorithmLabel = new System.Windows.Forms.Label();
         this.customAlgorithmDetailsGroupBox = new System.Windows.Forms.GroupBox();
         this.refreshEntireGraphWhenEditingCheckBox = new System.Windows.Forms.CheckBox();
         this.changesVisibleAfterApplicationIsRestartedLabel = new System.Windows.Forms.Label();
         this.defaultAlgorithmGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.verticalGapNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.horizontalGapNumericUpDown)).BeginInit();
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
         this.customAlgorithmDetailsGroupBox.Enabled = false;
         this.customAlgorithmDetailsGroupBox.Location = new System.Drawing.Point(3, 81);
         this.customAlgorithmDetailsGroupBox.Name = "customAlgorithmDetailsGroupBox";
         this.customAlgorithmDetailsGroupBox.Size = new System.Drawing.Size(681, 333);
         this.customAlgorithmDetailsGroupBox.TabIndex = 3;
         this.customAlgorithmDetailsGroupBox.TabStop = false;
         this.customAlgorithmDetailsGroupBox.Text = "Custom Layout Algorithms";
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
         // GraphLayoutAlgorithmsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.changesVisibleAfterApplicationIsRestartedLabel);
         this.Controls.Add(this.customAlgorithmDetailsGroupBox);
         this.Controls.Add(this.defaultAlgorithmGroupBox);
         this.Name = "GraphLayoutAlgorithmsControl";
         this.Size = new System.Drawing.Size(684, 430);
         this.defaultAlgorithmGroupBox.ResumeLayout(false);
         this.defaultAlgorithmGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.verticalGapNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.horizontalGapNumericUpDown)).EndInit();
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
   }
}
