﻿namespace Framework.GUI.Controls.Conversations
{
    partial class ConversationsManagerHost
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
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.splitContainer3 = new System.Windows.Forms.SplitContainer();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
         this.splitContainer3.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
         this.splitContainer1.Size = new System.Drawing.Size(1016, 692);
         this.splitContainer1.SplitterDistance = 659;
         this.splitContainer1.TabIndex = 0;
         this.splitContainer1.TabStop = false;
         // 
         // splitContainer2
         // 
         this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
         this.splitContainer2.Panel1Collapsed = true;
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
         this.splitContainer2.Size = new System.Drawing.Size(353, 692);
         this.splitContainer2.SplitterDistance = 352;
         this.splitContainer2.TabIndex = 0;
         // 
         // splitContainer3
         // 
         this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer3.Location = new System.Drawing.Point(0, 0);
         this.splitContainer3.Name = "splitContainer3";
         this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
         this.splitContainer3.Size = new System.Drawing.Size(353, 692);
         this.splitContainer3.SplitterDistance = 346;
         this.splitContainer3.TabIndex = 0;
         // 
         // ConversationsManagerHost
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.splitContainer1);
         this.MinimumSize = new System.Drawing.Size(1016, 692);
         this.Name = "ConversationsManagerHost";
         this.Size = new System.Drawing.Size(1016, 692);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
         this.splitContainer3.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}
