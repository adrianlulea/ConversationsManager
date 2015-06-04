namespace Framework.GUI.Forms.Conversations
{
   partial class AvailableParsersForm
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
         this.parserLibrariesHost = new System.Windows.Forms.Panel();
         this.doneButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // parserLibrariesHost
         // 
         this.parserLibrariesHost.Location = new System.Drawing.Point(12, 12);
         this.parserLibrariesHost.Name = "parserLibrariesHost";
         this.parserLibrariesHost.Size = new System.Drawing.Size(443, 306);
         this.parserLibrariesHost.TabIndex = 0;
         // 
         // doneButton
         // 
         this.doneButton.Location = new System.Drawing.Point(380, 324);
         this.doneButton.Name = "doneButton";
         this.doneButton.Size = new System.Drawing.Size(75, 23);
         this.doneButton.TabIndex = 1;
         this.doneButton.Text = "Done";
         this.doneButton.UseVisualStyleBackColor = true;
         // 
         // AvailableParsersForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(466, 353);
         this.Controls.Add(this.doneButton);
         this.Controls.Add(this.parserLibrariesHost);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "AvailableParsersForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "AvailableParsersForm";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel parserLibrariesHost;
      private System.Windows.Forms.Button doneButton;
   }
}