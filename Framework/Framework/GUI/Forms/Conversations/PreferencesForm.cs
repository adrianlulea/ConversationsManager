using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Util;
using Framework.Data.Conversations;
using System.IO;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Preferences form.
    /// </summary>
    public partial class PreferencesForm : Form
    {
        #region Members

        /// <summary>
        /// Preferences data manager.
        /// </summary>
        private PreferencesManager _manager;

        /// <summary>
        /// Initializing flag.
        /// </summary>
        private bool _initializing;

        /// <summary>
        /// Flag whether or not the language is set to its default value.
        /// </summary>
        private bool _defaultLanguage;

        /// <summary>
        /// Flag whether or not the theme is set to its default value.
        /// </summary>
        private bool _defaultTheme;

        /// <summary>
        /// Flag whether or not the default database location is set to its default value.
        /// </summary>
        private bool _defaultLocation;

        /// <summary>
        /// Custom location for language.
        /// </summary>
        private string _customLanguagePath;

        /// <summary>
        /// Custom location for theme.
        /// </summary>
        private string _customThemePath;

        #endregion

        #region Constructors

        /// <summary>
        /// Default PreferencesForm constructor.
        /// </summary>
        /// <param name="manager">Preferences data manager.</param>
        public PreferencesForm(PreferencesManager manager)
        {
            // Initialize manager
            _manager = manager;

            // Initialize GUI
            InitializeComponent();

            // Initialize data
            InitializeData();
        }

        #endregion

        #region Events

        /// <summary>
        /// Radio buttons checked changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing)
            {
                return;
            }

            RadioButton rb = (RadioButton)sender;
            int tagValue = int.Parse(rb.Tag.ToString());

            UpdateApplyButton();

            switch (tagValue)
            {
                case 0:
                    {
                        browseLanguageButton.Enabled = rb.Checked;
                        customLanguagePath.Visible = false;
                        _defaultLanguage = (rb.Checked == false);
                        break;
                    }
                case 1:
                    {
                        browseThemeButton.Enabled = rb.Checked;
                        _defaultTheme = (rb.Checked == false);
                        customThemePath.Visible = false;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Browse location buttons click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseLocationButton_Click(object sender, EventArgs e)
        {
            if (_initializing)
            {
                return;
            }

            Button b = (Button)sender;
            int tagValue = int.Parse(b.Tag.ToString());

            browseCustomLocation.InitialDirectory = Directory.GetCurrentDirectory();

            if (browseCustomLocation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (tagValue)
                {
                    case 0:
                        {
                            _customLanguagePath = browseCustomLocation.FileName;
                            customLanguagePath.Text = ProcessPath(_customLanguagePath);
                            customLanguagePath.Visible = true;
                            break;
                        }
                    case 1:
                        {
                            _customThemePath = browseCustomLocation.FileName;
                            customThemePath.Text = ProcessPath(_customThemePath);
                            customThemePath.Visible = true;
                            break;
                        }
                    default:
                        {
                            throw new InvalidFieldException();
                        }
                }
            }

            UpdateApplyButton();
        }

        /// <summary>
        /// Change default location button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeDefaultLocationButton_Click(object sender, EventArgs e)
        {
            if (_initializing)
            {
                return;
            }

            if (browseCustomDirectory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _defaultLocation = (browseCustomDirectory.SelectedPath == Directory.GetCurrentDirectory());
                if (_defaultLocation)
                {
                    defaultLocation.Text = "Current directory";
                }
                else
                {
                    defaultLocation.Text = ProcessPath(browseCustomDirectory.SelectedPath);
                }

                if (customLanguage.Checked)
                {
                    customLanguagePath.Text = ProcessPath(_customLanguagePath);
                }

                if (customTheme.Checked)
                {
                    customThemePath.Text = ProcessPath(_customThemePath);
                }
            }
        }

        /// <summary>
        /// Apply button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (_initializing)
            {
                return;
            }

            // Defaults
            _manager.Data.LanguageLocation = "";
            _manager.Data.ThemeLocation = "";
            _manager.Data.SaveLocation = "";

            // Set language data
            _manager.Data.DefaultLanguage = defaultLanguage.Checked;
            if (defaultLanguage.Checked == false)
            {
                _manager.Data.LanguageLocation = customLanguagePath.Text;
            }

            // Set theme data
            _manager.Data.DefaultTheme = defaultTheme.Checked;
            if (defaultTheme.Checked == false)
            {
                _manager.Data.ThemeLocation = customThemePath.Text;
            }

            // Set external format
            _manager.Data.BinaryFormat = binaryDataFormat.Checked;
            _manager.Data.XMLFormat = xmlDataFormat.Checked;

            // Set default location for saving data
            _manager.Data.DefaultLocation = (defaultLocation.Text == "Current directory");

            if(_manager.Data.DefaultLocation == false)
            {
                _manager.Data.SaveLocation = defaultLocation.Text;
            }

            _manager.Save();

            DialogResult = System.Windows.Forms.DialogResult.Yes;

            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize data.
        /// </summary>
        private void InitializeData()
        {
            _initializing = true;

            // Language
            InitializeLanguage();

            // Theme
            InitializeTheme();

            // Format
            InitializeFormat();

            // Saving location
            InitializeSavingLocation();

            _initializing = false;
        }

        /// <summary>
        /// Initialize language.
        /// </summary>
        private void InitializeLanguage()
        {
            // Set flag
            defaultLanguage.Checked = _manager.Data.DefaultLanguage;
            _defaultLanguage = defaultLanguage.Checked;

            if (defaultLanguage.Checked == false)
            {
                customLanguage.Checked = true;
                customLanguagePath.Visible = true;
                customLanguagePath.Text = _manager.Data.LanguageLocation;
            }
        }

        /// <summary>
        /// Initialize theme.
        /// </summary>
        private void InitializeTheme()
        {
            defaultTheme.Checked = _manager.Data.DefaultTheme;
            _defaultTheme = defaultTheme.Checked;

            if (defaultTheme.Checked == false)
            {
                customTheme.Checked = true;
                customThemePath.Visible = true;
                customThemePath.Text = _manager.Data.ThemeLocation;
            }
        }

        /// <summary>
        /// Intialize format.
        /// </summary>
        private void InitializeFormat()
        {
            binaryDataFormat.Checked = _manager.Data.BinaryFormat;
            xmlDataFormat.Checked = _manager.Data.XMLFormat;
        }

        /// <summary>
        /// Initialize saving location.
        /// </summary>
        private void InitializeSavingLocation()
        {
            if (_manager.Data.DefaultLocation)
            {
                defaultLocation.Text = "Current directory";
                _defaultLocation = true;
            }
            else
            {
                defaultLocation.Text = _manager.Data.SaveLocation;
                _defaultLocation = false;
            }
        }

        /// <summary>
        /// Process path for display.
        /// </summary>
        /// <param name="path">Path to process.</param>
        /// <returns>processed path</returns>
        private string ProcessPath(string path)
        {
            string newPath = string.Copy(path);
            string currentDirectory = Directory.GetCurrentDirectory();
            bool withinDefaultLocation = path.Contains(currentDirectory);
            bool withinCustomLocation = path.Contains(defaultLocation.Text);

            if (_defaultLocation)
            {
                if (withinDefaultLocation)
                {
                    newPath = newPath.Replace(currentDirectory, "");
                }
            }
            else
            {
                if (withinCustomLocation)
                {
                    newPath = newPath.Replace(defaultLocation.Text, "");
                }
            }

            return newPath;
        }

        /// <summary>
        /// Update apply button.
        /// </summary>
        private void UpdateApplyButton()
        {
            if (customLanguage.Checked && customLanguagePath.Visible == false)
            {
                applyButton.Enabled = false;
                return;
            }

            if (customTheme.Checked && customThemePath.Visible == false)
            {
                applyButton.Enabled = false;
                return;
            }

            applyButton.Enabled = true;
            
        }

        #endregion
    }
}
