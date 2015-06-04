namespace Framework.GUI.Forms.Conversations
{
    partial class PreferencesForm
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
         this.languageGroup = new System.Windows.Forms.GroupBox();
         this.customLanguagePath = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.browseLanguageButton = new System.Windows.Forms.Button();
         this.customLanguage = new System.Windows.Forms.RadioButton();
         this.defaultLanguage = new System.Windows.Forms.RadioButton();
         this.themeBox = new System.Windows.Forms.GroupBox();
         this.customThemePath = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.browseThemeButton = new System.Windows.Forms.Button();
         this.customTheme = new System.Windows.Forms.RadioButton();
         this.defaultTheme = new System.Windows.Forms.RadioButton();
         this.dataFormatBox = new System.Windows.Forms.GroupBox();
         this.xmlDataFormat = new System.Windows.Forms.RadioButton();
         this.binaryDataFormat = new System.Windows.Forms.RadioButton();
         this.label3 = new System.Windows.Forms.Label();
         this.savingLocationBox = new System.Windows.Forms.GroupBox();
         this.changeDefaultLocationButton = new System.Windows.Forms.Button();
         this.defaultLocation = new System.Windows.Forms.Label();
         this.defaultSavingLocationLabel = new System.Windows.Forms.Label();
         this.applyButton = new System.Windows.Forms.Button();
         this.browseCustomLocation = new System.Windows.Forms.OpenFileDialog();
         this.browseCustomDirectory = new System.Windows.Forms.FolderBrowserDialog();
         this.browseParserLibrary = new System.Windows.Forms.OpenFileDialog();
         this.parsersHost = new System.Windows.Forms.Panel();
         this.languageGroup.SuspendLayout();
         this.themeBox.SuspendLayout();
         this.dataFormatBox.SuspendLayout();
         this.savingLocationBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // languageGroup
         // 
         this.languageGroup.Controls.Add(this.customLanguagePath);
         this.languageGroup.Controls.Add(this.label1);
         this.languageGroup.Controls.Add(this.browseLanguageButton);
         this.languageGroup.Controls.Add(this.customLanguage);
         this.languageGroup.Controls.Add(this.defaultLanguage);
         this.languageGroup.Location = new System.Drawing.Point(12, 12);
         this.languageGroup.Name = "languageGroup";
         this.languageGroup.Size = new System.Drawing.Size(443, 61);
         this.languageGroup.TabIndex = 0;
         this.languageGroup.TabStop = false;
         this.languageGroup.Text = "Language";
         // 
         // customLanguagePath
         // 
         this.customLanguagePath.AutoSize = true;
         this.customLanguagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.customLanguagePath.Location = new System.Drawing.Point(218, 21);
         this.customLanguagePath.Name = "customLanguagePath";
         this.customLanguagePath.Size = new System.Drawing.Size(73, 13);
         this.customLanguagePath.TabIndex = 4;
         this.customLanguagePath.Text = "customPath";
         this.customLanguagePath.Visible = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(6, 39);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(48, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "English";
         // 
         // browseLanguageButton
         // 
         this.browseLanguageButton.Enabled = false;
         this.browseLanguageButton.Location = new System.Drawing.Point(137, 16);
         this.browseLanguageButton.Name = "browseLanguageButton";
         this.browseLanguageButton.Size = new System.Drawing.Size(75, 23);
         this.browseLanguageButton.TabIndex = 2;
         this.browseLanguageButton.Tag = "0";
         this.browseLanguageButton.Text = "Browse";
         this.browseLanguageButton.UseVisualStyleBackColor = true;
         this.browseLanguageButton.Click += new System.EventHandler(this.browseLocationButton_Click);
         // 
         // customLanguage
         // 
         this.customLanguage.AutoSize = true;
         this.customLanguage.Location = new System.Drawing.Point(71, 19);
         this.customLanguage.Name = "customLanguage";
         this.customLanguage.Size = new System.Drawing.Size(60, 17);
         this.customLanguage.TabIndex = 1;
         this.customLanguage.TabStop = true;
         this.customLanguage.Tag = "0";
         this.customLanguage.Text = "Custom";
         this.customLanguage.UseVisualStyleBackColor = true;
         this.customLanguage.CheckedChanged += new System.EventHandler(this.customCheckboxes_CheckedChanged);
         // 
         // defaultLanguage
         // 
         this.defaultLanguage.AutoSize = true;
         this.defaultLanguage.Checked = true;
         this.defaultLanguage.Location = new System.Drawing.Point(6, 19);
         this.defaultLanguage.Name = "defaultLanguage";
         this.defaultLanguage.Size = new System.Drawing.Size(59, 17);
         this.defaultLanguage.TabIndex = 0;
         this.defaultLanguage.TabStop = true;
         this.defaultLanguage.Text = "Default";
         this.defaultLanguage.UseVisualStyleBackColor = true;
         // 
         // themeBox
         // 
         this.themeBox.Controls.Add(this.customThemePath);
         this.themeBox.Controls.Add(this.label2);
         this.themeBox.Controls.Add(this.browseThemeButton);
         this.themeBox.Controls.Add(this.customTheme);
         this.themeBox.Controls.Add(this.defaultTheme);
         this.themeBox.Location = new System.Drawing.Point(12, 79);
         this.themeBox.Name = "themeBox";
         this.themeBox.Size = new System.Drawing.Size(443, 60);
         this.themeBox.TabIndex = 1;
         this.themeBox.TabStop = false;
         this.themeBox.Text = "Theme";
         // 
         // customThemePath
         // 
         this.customThemePath.AutoSize = true;
         this.customThemePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.customThemePath.Location = new System.Drawing.Point(218, 21);
         this.customThemePath.Name = "customThemePath";
         this.customThemePath.Size = new System.Drawing.Size(73, 13);
         this.customThemePath.TabIndex = 8;
         this.customThemePath.Text = "customPath";
         this.customThemePath.Visible = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(6, 39);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(38, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Basic";
         // 
         // browseThemeButton
         // 
         this.browseThemeButton.Enabled = false;
         this.browseThemeButton.Location = new System.Drawing.Point(137, 16);
         this.browseThemeButton.Name = "browseThemeButton";
         this.browseThemeButton.Size = new System.Drawing.Size(75, 23);
         this.browseThemeButton.TabIndex = 6;
         this.browseThemeButton.Tag = "1";
         this.browseThemeButton.Text = "Browse";
         this.browseThemeButton.UseVisualStyleBackColor = true;
         this.browseThemeButton.Click += new System.EventHandler(this.browseLocationButton_Click);
         // 
         // customTheme
         // 
         this.customTheme.AutoSize = true;
         this.customTheme.Location = new System.Drawing.Point(71, 19);
         this.customTheme.Name = "customTheme";
         this.customTheme.Size = new System.Drawing.Size(60, 17);
         this.customTheme.TabIndex = 5;
         this.customTheme.TabStop = true;
         this.customTheme.Tag = "1";
         this.customTheme.Text = "Custom";
         this.customTheme.UseVisualStyleBackColor = true;
         this.customTheme.CheckedChanged += new System.EventHandler(this.customCheckboxes_CheckedChanged);
         // 
         // defaultTheme
         // 
         this.defaultTheme.AutoSize = true;
         this.defaultTheme.Checked = true;
         this.defaultTheme.Location = new System.Drawing.Point(6, 19);
         this.defaultTheme.Name = "defaultTheme";
         this.defaultTheme.Size = new System.Drawing.Size(59, 17);
         this.defaultTheme.TabIndex = 4;
         this.defaultTheme.TabStop = true;
         this.defaultTheme.Text = "Default";
         this.defaultTheme.UseVisualStyleBackColor = true;
         // 
         // dataFormatBox
         // 
         this.dataFormatBox.Controls.Add(this.xmlDataFormat);
         this.dataFormatBox.Controls.Add(this.binaryDataFormat);
         this.dataFormatBox.Controls.Add(this.label3);
         this.dataFormatBox.Location = new System.Drawing.Point(12, 145);
         this.dataFormatBox.Name = "dataFormatBox";
         this.dataFormatBox.Size = new System.Drawing.Size(443, 40);
         this.dataFormatBox.TabIndex = 2;
         this.dataFormatBox.TabStop = false;
         this.dataFormatBox.Text = "Data Format";
         // 
         // xmlDataFormat
         // 
         this.xmlDataFormat.AutoSize = true;
         this.xmlDataFormat.Location = new System.Drawing.Point(150, 14);
         this.xmlDataFormat.Name = "xmlDataFormat";
         this.xmlDataFormat.Size = new System.Drawing.Size(47, 17);
         this.xmlDataFormat.TabIndex = 2;
         this.xmlDataFormat.Text = "XML";
         this.xmlDataFormat.UseVisualStyleBackColor = true;
         // 
         // binaryDataFormat
         // 
         this.binaryDataFormat.AutoSize = true;
         this.binaryDataFormat.Checked = true;
         this.binaryDataFormat.Location = new System.Drawing.Point(90, 14);
         this.binaryDataFormat.Name = "binaryDataFormat";
         this.binaryDataFormat.Size = new System.Drawing.Size(54, 17);
         this.binaryDataFormat.TabIndex = 1;
         this.binaryDataFormat.TabStop = true;
         this.binaryDataFormat.Text = "Binary";
         this.binaryDataFormat.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 16);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(78, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Saving format: ";
         // 
         // savingLocationBox
         // 
         this.savingLocationBox.Controls.Add(this.changeDefaultLocationButton);
         this.savingLocationBox.Controls.Add(this.defaultLocation);
         this.savingLocationBox.Controls.Add(this.defaultSavingLocationLabel);
         this.savingLocationBox.Location = new System.Drawing.Point(12, 191);
         this.savingLocationBox.Name = "savingLocationBox";
         this.savingLocationBox.Size = new System.Drawing.Size(443, 62);
         this.savingLocationBox.TabIndex = 3;
         this.savingLocationBox.TabStop = false;
         this.savingLocationBox.Text = "Saving Location";
         // 
         // changeDefaultLocationButton
         // 
         this.changeDefaultLocationButton.Location = new System.Drawing.Point(362, 30);
         this.changeDefaultLocationButton.Name = "changeDefaultLocationButton";
         this.changeDefaultLocationButton.Size = new System.Drawing.Size(75, 23);
         this.changeDefaultLocationButton.TabIndex = 2;
         this.changeDefaultLocationButton.Tag = "2";
         this.changeDefaultLocationButton.Text = "Browse";
         this.changeDefaultLocationButton.UseVisualStyleBackColor = true;
         this.changeDefaultLocationButton.Click += new System.EventHandler(this.changeDefaultLocationButton_Click);
         // 
         // defaultLocation
         // 
         this.defaultLocation.AutoSize = true;
         this.defaultLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.defaultLocation.Location = new System.Drawing.Point(133, 16);
         this.defaultLocation.Name = "defaultLocation";
         this.defaultLocation.Size = new System.Drawing.Size(101, 13);
         this.defaultLocation.TabIndex = 1;
         this.defaultLocation.Text = "Current directory";
         // 
         // defaultSavingLocationLabel
         // 
         this.defaultSavingLocationLabel.AutoSize = true;
         this.defaultSavingLocationLabel.Location = new System.Drawing.Point(6, 16);
         this.defaultSavingLocationLabel.Name = "defaultSavingLocationLabel";
         this.defaultSavingLocationLabel.Size = new System.Drawing.Size(121, 13);
         this.defaultSavingLocationLabel.TabIndex = 0;
         this.defaultSavingLocationLabel.Text = "Default saving location: ";
         // 
         // applyButton
         // 
         this.applyButton.Location = new System.Drawing.Point(374, 571);
         this.applyButton.Name = "applyButton";
         this.applyButton.Size = new System.Drawing.Size(75, 23);
         this.applyButton.TabIndex = 4;
         this.applyButton.Text = "Apply";
         this.applyButton.UseVisualStyleBackColor = true;
         this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
         // 
         // browseCustomLocation
         // 
         this.browseCustomLocation.Filter = "XML Files|*.xml";
         this.browseCustomLocation.Title = "Custom location...";
         // 
         // browseCustomDirectory
         // 
         this.browseCustomDirectory.Description = "Saving location";
         // 
         // browseParserLibrary
         // 
         this.browseParserLibrary.FileName = "openFileDialog1";
         this.browseParserLibrary.Filter = "Parser libraries files|*.dll";
         this.browseParserLibrary.Title = "Import parser library";
         // 
         // parsersHost
         // 
         this.parsersHost.Location = new System.Drawing.Point(12, 259);
         this.parsersHost.Name = "parsersHost";
         this.parsersHost.Size = new System.Drawing.Size(443, 306);
         this.parsersHost.TabIndex = 5;
         // 
         // PreferencesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(467, 606);
         this.Controls.Add(this.parsersHost);
         this.Controls.Add(this.applyButton);
         this.Controls.Add(this.savingLocationBox);
         this.Controls.Add(this.dataFormatBox);
         this.Controls.Add(this.themeBox);
         this.Controls.Add(this.languageGroup);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "PreferencesForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PreferencesForm";
         this.languageGroup.ResumeLayout(false);
         this.languageGroup.PerformLayout();
         this.themeBox.ResumeLayout(false);
         this.themeBox.PerformLayout();
         this.dataFormatBox.ResumeLayout(false);
         this.dataFormatBox.PerformLayout();
         this.savingLocationBox.ResumeLayout(false);
         this.savingLocationBox.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox languageGroup;
        private System.Windows.Forms.RadioButton defaultLanguage;
        private System.Windows.Forms.RadioButton customLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseLanguageButton;
        private System.Windows.Forms.GroupBox themeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseThemeButton;
        private System.Windows.Forms.RadioButton customTheme;
        private System.Windows.Forms.RadioButton defaultTheme;
        private System.Windows.Forms.GroupBox dataFormatBox;
        private System.Windows.Forms.RadioButton xmlDataFormat;
        private System.Windows.Forms.RadioButton binaryDataFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox savingLocationBox;
        private System.Windows.Forms.Button changeDefaultLocationButton;
        private System.Windows.Forms.Label defaultLocation;
        private System.Windows.Forms.Label defaultSavingLocationLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label customLanguagePath;
        private System.Windows.Forms.Label customThemePath;
        private System.Windows.Forms.OpenFileDialog browseCustomLocation;
        private System.Windows.Forms.FolderBrowserDialog browseCustomDirectory;
        private System.Windows.Forms.OpenFileDialog browseParserLibrary;
        private System.Windows.Forms.Panel parsersHost;
    }
}