using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Framework.Util;
using Framework.Data.Conversations;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Saved Data Manager Form.
    /// </summary>
    public partial class SavedDataManagerForm : Form
    {
        #region Members

        /// <summary>
        /// Saved data manager state.
        /// </summary>
        private SavedDataManagerState _state;

        /// <summary>
        /// Saved data manager path for loading and creating database files.
        /// </summary>
        private string _savedDataPath;

        /// <summary>
        /// Link to MainForm parent.
        /// </summary>
        private ConversationsManager _parent;

        /// <summary>
        /// Renaming flag.
        /// </summary>
        private bool _renaming;

        /// <summary>
        /// Format for new database.
        /// </summary>
        private ExternalFormat _newDatabaseFormat;

        #endregion

        #region Properties

        /// <summary>
        /// Get form state
        /// </summary>
        public SavedDataManagerState State
        {
            get { return _state; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor by initial state and default path.
        /// </summary>
        /// <param name="state">SavedDataManager initial state.</param>
        /// <param name="path">SavedDataManager path for new and existing databases.</param>
        /// <param name="parent">Link to main form.</param>
        /// <param name="format">New database format.</param>
        public SavedDataManagerForm(SavedDataManagerState state, string path, ConversationsManager parent, ExternalFormat format)
        {
            // Set state
            _state = state;

            // Set path
            _savedDataPath = path;

            // Set parent
            _parent = parent;

            // Set renaming flag
            _renaming = false;

            // Set new database format
            _newDatabaseFormat = format;

            // Initialize default component
            InitializeComponent();

            // Initialize data (by state)
            InitializeData();
        }

        #endregion

        #region Events

        /// <summary>
        /// State changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedDataManager_StateChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            int value = int.Parse(rb.Tag.ToString());

            if (rb.Checked)
            {
                UpdateState(value, false);
            }
        }

        /// <summary>
        /// Database name text changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseName_TextChanged(object sender, EventArgs e)
        {
            doneButton.Enabled = ValidNewDatabase(databaseName.Text);
        }

        /// <summary>
        /// Saved data list selected index changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savedDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabled = false;

            // Set flag
            if (savedDataList.SelectedItems.Count == 1)
            {
                enabled = ValidExistingDatabase(savedDataList.SelectedItems[0].Tag.ToString());
            }

            if (enabled && _renaming)
            {
                newName.Text = savedDataList.SelectedItems[0].Text;
            }

            doneButton.Enabled = enabled;
            renameButton.Enabled = enabled;
            deleteButton.Enabled = enabled;
        }

        /// <summary>
        /// Rename button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renameButton_Click(object sender, EventArgs e)
        {
            StartRenaming();
        }

        /// <summary>
        /// New name text changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newName_TextChanged(object sender, EventArgs e)
        {
            finishRenamingButton.Enabled = ValidNewDatabase(newName.Text);
        }

        /// <summary>
        /// Finish renaming button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishRenamingButton_Click(object sender, EventArgs e)
        {
            FinishRenaming();
        }

        /// <summary>
        /// Delete button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedDatabase();
        }

        /// <summary>
        /// Cancel button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Done button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            try
            {
                switch (_state)
                {
                    case SavedDataManagerState.CreateNewData:
                        {
                            _parent.DatabaseName = databaseName.Text;
                            break;
                        }
                    case SavedDataManagerState.OpenExistingData:
                        {
                            _parent.DatabaseName = savedDataList.SelectedItems[0].Text;
                            break;
                        }
                }
                _parent.DatabaseState = _state;

            }
            catch { }
        }

        /// <summary>
        /// Saved data list double click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savedDataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (doneButton.Enabled)
            {
                doneButton.PerformClick();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize data.
        /// </summary>
        private void InitializeData()
        {
            // Add data
            PopulateDatabases(_savedDataPath);

            // Update controls
            UpdateState(_state, true);
        }

        /// <summary>
        /// Update form state.
        /// </summary>
        /// <param name="state">Form's new state.</param>
        /// <param name="checkRadioButtons">Whether or not radio buttons should be updated as well.</param>
        private void UpdateState(SavedDataManagerState state, bool checkRadioButtons)
        {
            switch (state)
            {
                case SavedDataManagerState.CreateNewData:
                    {
                        existingGroupBox.Enabled = false;

                        if (checkRadioButtons)
                        {
                            creatingNewData.Checked = true;
                        }

                        databaseName.Enabled = true;
                        break;
                    }
                case SavedDataManagerState.OpenExistingData:
                    {
                        databaseName.Enabled = false;
                        existingGroupBox.Enabled = true;

                        if (checkRadioButtons)
                        {
                            openingExistingSavedData.Checked = true;
                        }
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            doneButton.Enabled = false;
            databaseName.Text = "";
            _state = state;
        }

        /// <summary>
        /// Update form state.
        /// </summary>
        /// <param name="state">Form's new state as an integer.</param>
        /// <param name="checkRadioButtons">Whether or not radio buttons should be updated as well.</param>
        private void UpdateState(int state, bool checkRadioButtons)
        {
            // Get state
            SavedDataManagerState updatedState = GetState(state);

            // Update state
            UpdateState(updatedState, checkRadioButtons);
        }

        /// <summary>
        /// Convert form state from integer.
        /// </summary>
        /// <param name="state">Integer representation of form state.</param>
        /// <exception cref="InvalidStateException">State is invalid.</exception>
        /// <returns>SavedDataManagerState</returns>
        private SavedDataManagerState GetState(int state)
        {
            switch (state)
            {
                case 0:
                    {
                        return SavedDataManagerState.OpenExistingData;
                    }
                case 1:
                    {
                        return SavedDataManagerState.CreateNewData;
                    }
                default:
                    {
                        throw new InvalidStateException();
                    }
            }
        }

        /// <summary>
        /// Populate database list from files and format.
        /// </summary>
        /// <param name="files">Files containing databases to import.</param>
        /// <param name="format">Format in which the databases will be imported.</param>
        private void PopulateFromFiles(string[] files, ExternalFormat format)
        {
            ListViewItem item;
            string extension = PreferencesManager.GetExtension(format);
            bool includeExtension = true;

            foreach (string file in files)
            {
                ExternalDatabase database;

                try
                {
                    database = DataManager.Deserialize(file, format);
                    item = new ListViewItem(GetFilenameFromPath(file, extension, includeExtension));
                    item.Tag = file;
                    item.SubItems.Add(GetFileSizeFromPath(file, true));

                    savedDataList.Items.Add(item);
                }
                catch
                {
                    // skip
                }
            }
        }

        /// <summary>
        /// Populate list of legitimate databases found at given path.
        /// </summary>
        /// <param name="path">Databases path.</param>
        private void PopulateDatabases(string path)
        {
            string[] binaryFiles = Directory.GetFiles(path, "*.dat");
            string[] xmlFiles = Directory.GetFiles(path, "*.xml");

            // Clear Items
            savedDataList.Items.Clear();

            // Populate binary files
            PopulateFromFiles(binaryFiles, ExternalFormat.BinaryFormat);

            // Populate xml files
            PopulateFromFiles(xmlFiles, ExternalFormat.XMLFormat);
        }

        /// <summary>
        /// Extract filename from path.
        /// </summary>
        /// <param name="path">Path from which to extract filename.</param>
        /// <param name="extension">Extension to eliminate from path (example: ".dat").</param>
        /// <param name="includeExtension">Flag whether to include or not the file's extension.</param>
        /// <returns>Filename or "" whether the given path is correct.</returns>
        private string GetFilenameFromPath(string path, string extension, bool includeExtension)
        {
            string filename = "";

            try
            {
                int extensionIndex = (includeExtension) ? path.Length : path.IndexOf(extension);
                int lastSlashIndex = path.LastIndexOf('\\') + 1;

                filename = path.Substring(lastSlashIndex, extensionIndex - lastSlashIndex);

            }
            catch { }

            return filename;
        }

        /// <summary>
        /// Extract file size from path with additional formating if requested.
        /// </summary>
        /// <param name="path">Path from which to extract file size.</param>
        /// <param name="formatSize">Flag if size formating is performed.</param>
        /// <returns></returns>
        private string GetFileSizeFromPath(string path, bool formatSize)
        {
            string size = "";

            try
            {
                FileStream stream = File.OpenRead(path);
                long fileSizeInBytes = stream.Length;
                stream.Close();

                if (formatSize)
                {
                    size = FormatSize(fileSizeInBytes);
                }
                else
                {
                    size = fileSizeInBytes.ToString() + " B";
                }
            }
            catch { }

            return size;
        }

        /// <summary>
        /// Format size from given size value (in bytes).
        /// </summary>
        /// <param name="size">Size value in bytes.</param>
        /// <returns>Formated size of "" if not valid.</returns>
        private string FormatSize(long size)
        {
            const long KB = 1024;
            const long MB = 1024 * KB;
            const long GB = 1024 * MB;
            const long TB = 1024 * GB;
            string formatedSize = "";

            // Invalid size
            if (size < 0)
            {
                return formatedSize;
            }

            if (size >= TB)
            {
                float value = (float)size/ TB;
                formatedSize = value.ToString() + " TB";
                goto returnFormat;
            }

            if (size >= GB)
            {
                float value = (float)size / GB;
                formatedSize = value.ToString() + " GB";
                goto returnFormat;
            }

            if (size >= MB)
            {
                float value = (float)size / MB;
                formatedSize = value.ToString() + " MB";
                goto returnFormat;
            }

            if (size >= KB)
            {
                float value = (float)size / KB;
                formatedSize = value.ToString() + " KB";
                goto returnFormat;
            }

            // Bytes
            formatedSize = size.ToString() + " B";

            returnFormat:
            return formatedSize;
        }

        /// <summary>
        /// Check if given database name is valid.
        /// </summary>
        /// <param name="name">Database name to validate.</param>
        /// <returns>true if database name is valid, false if not.</returns>
        private bool ValidNewDatabase(string name)
        {
            if (name == "" || name == null)
            {
                return false;
            }
            string extension = PreferencesManager.GetExtension(_newDatabaseFormat);
            string generatedDatabasePath = _savedDataPath + "\\" + name + extension;
            return (File.Exists(generatedDatabasePath) == false);
        }

        /// <summary>
        /// Check whether or not the given path leads to a file.
        /// </summary>
        /// <param name="path">Path to check if valid.</param>
        /// <returns>Whether or not the path leads to a file.</returns>
        private bool ValidExistingDatabase(string path)
        {
            if (path == "" || path == null)
            {
                return false;
            }

            return File.Exists(path);
        }

        /// <summary>
        /// Delete selected database.
        /// </summary>
        private void DeleteSelectedDatabase()
        {
            //TODO Ask for confirmation when deleting existing database
            string databaseName = savedDataList.SelectedItems[0].Text;
            string currentLoadedDatabase = _parent.DatabaseName;

            if (currentLoadedDatabase == databaseName)
            {
                //TODO Ask if it's ok to delete current loaded database
                // Cannot delete current database name
            }
            else
            {
                File.Delete(savedDataList.SelectedItems[0].Tag.ToString());
                savedDataList.Items.Remove(savedDataList.SelectedItems[0]);
                renameButton.Enabled = false;
                deleteButton.Enabled = false;
                doneButton.Enabled = false;
                newName.Visible = false;
            }
        }

        /// <summary>
        /// Start renaming database.
        /// </summary>
        private void StartRenaming()
        {
            if (_renaming)
            {
                // Cancel renaming
                newName.Visible = false;
                finishRenamingButton.Visible = false;
                renameButton.Checked = false;
                _renaming = false;
            }
            else
            {
                // Start renaming
                newName.Text = savedDataList.SelectedItems[0].Text;
                newName.Visible = true;
                finishRenamingButton.Enabled = false;
                finishRenamingButton.Visible = true;
                renameButton.Checked = true;
                _renaming = true;
            }
        }

        /// <summary>
        /// Finish renaming database.
        /// </summary>
        private void FinishRenaming()
        {
            //TODO Ask if sure about renaming
            string extension = PreferencesManager.GetExtension(_newDatabaseFormat);
            string newPath = _savedDataPath + "\\" + newName.Text + extension;
            File.Move(savedDataList.SelectedItems[0].Tag.ToString(), newPath);
            newName.Visible = false;
            finishRenamingButton.Visible = false;
            UpdateSelectedItem(newName.Text, newPath);
            _renaming = false;
            renameButton.Checked = false;
        }

        /// <summary>
        /// Update selected item
        /// </summary>
        /// <param name="name">New name.</param>
        /// <param name="path">New location.</param>
        private void UpdateSelectedItem(string name, string path)
        {
            savedDataList.SelectedItems[0].Text = name;
            savedDataList.SelectedItems[0].Tag = path;
        }

        #endregion
    }
}
