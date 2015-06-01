using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Framework.Data.Conversations;
using Framework.Util;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Save as form.
    /// </summary>
    public partial class SaveAsForm : Form
    {
        #region Members

        /// <summary>
        /// Link to main form.
        /// </summary>
        private ConversationsManager _parent;

        /// <summary>
        /// Path to databases.
        /// </summary>
        private string _databasePath;

        /// <summary>
        /// Database external format.
        /// </summary>
        private ExternalFormat _externalFormat;

        #endregion

        #region Constructors

        /// <summary>
        /// Default SaveAsForm constructor.
        /// </summary>
        /// <param name="databasePath">Location for database.</param>
        /// <param name="parent">ConversationsManager form.</param>
        /// <param name="format">Format to save the database to.</param>
        public SaveAsForm(string databasePath, ConversationsManager parent, ExternalFormat format)
        {
            // Set path
            _databasePath = databasePath;

            // Set parent
            _parent = parent;

            // Set format
            _externalFormat = format;

            // Initialize GUI
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Database name text changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseName_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = ValidDatabase(databaseName.Text);
        }

        /// <summary>
        /// Cancel button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// Save button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            _parent.DatabaseName = databaseName.Text;
            _parent.DatabaseState = SavedDataManagerState.CreateNewData;

            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check whether or not the current database name is valid.
        /// </summary>
        /// <param name="name">Database name.</param>
        /// <returns>whether or not the given database name is valid</returns>
        private bool ValidDatabase(string name)
        {
            if (name == "" || name == null)
            {
                return false;
            }

            string extension = PreferencesManager.GetExtension(_externalFormat);
            string generatedDatabasePath = _databasePath + "\\" + name + extension;

            return (File.Exists(generatedDatabasePath) == false);
        }

        #endregion
    }
}
