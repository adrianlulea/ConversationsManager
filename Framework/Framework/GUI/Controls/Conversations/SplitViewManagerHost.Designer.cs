namespace Framework.GUI.Controls.Conversations
{
   partial class SplitViewManagerHost
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
         this.normalGraphSplitContainer = new System.Windows.Forms.SplitContainer();
         this.normalPanelHost = new System.Windows.Forms.Panel();
         this.graphPanelHost = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.normalGraphSplitContainer)).BeginInit();
         this.normalGraphSplitContainer.Panel1.SuspendLayout();
         this.normalGraphSplitContainer.Panel2.SuspendLayout();
         this.normalGraphSplitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // normalGraphSplitContainer
         // 
         this.normalGraphSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.normalGraphSplitContainer.Location = new System.Drawing.Point(0, 0);
         this.normalGraphSplitContainer.Name = "normalGraphSplitContainer";
         // 
         // normalGraphSplitContainer.Panel1
         // 
         this.normalGraphSplitContainer.Panel1.Controls.Add(this.normalPanelHost);
         // 
         // normalGraphSplitContainer.Panel2
         // 
         this.normalGraphSplitContainer.Panel2.Controls.Add(this.graphPanelHost);
         this.normalGraphSplitContainer.Size = new System.Drawing.Size(1016, 692);
         this.normalGraphSplitContainer.SplitterDistance = 508;
         this.normalGraphSplitContainer.TabIndex = 0;
         this.normalGraphSplitContainer.TabStop = false;
         // 
         // normalPanelHost
         // 
         this.normalPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.normalPanelHost.Location = new System.Drawing.Point(0, 0);
         this.normalPanelHost.Name = "normalPanelHost";
         this.normalPanelHost.Size = new System.Drawing.Size(508, 692);
         this.normalPanelHost.TabIndex = 0;
         // 
         // graphPanelHost
         // 
         this.graphPanelHost.Dock = System.Windows.Forms.DockStyle.Fill;
         this.graphPanelHost.Location = new System.Drawing.Point(0, 0);
         this.graphPanelHost.Name = "graphPanelHost";
         this.graphPanelHost.Size = new System.Drawing.Size(504, 692);
         this.graphPanelHost.TabIndex = 0;
         // 
         // SplitViewManagerHost
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.normalGraphSplitContainer);
         this.MinimumSize = new System.Drawing.Size(1016, 692);
         this.Name = "SplitViewManagerHost";
         this.Size = new System.Drawing.Size(1016, 692);
         this.normalGraphSplitContainer.Panel1.ResumeLayout(false);
         this.normalGraphSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.normalGraphSplitContainer)).EndInit();
         this.normalGraphSplitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer normalGraphSplitContainer;
      private System.Windows.Forms.Panel normalPanelHost;
      private System.Windows.Forms.Panel graphPanelHost;
   }
}
