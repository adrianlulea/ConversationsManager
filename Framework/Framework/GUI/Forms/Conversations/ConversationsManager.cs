﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Framework.GUI.Controls.Conversations;
using Framework.Util;
using Framework.Data.Conversations;
using Parser;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Conversations Manager main form.
    /// </summary>
    public partial class ConversationsManager : Form
    {
        #region Members

        /// <summary>
        /// Data manager.
        /// </summary>
        private DataManager _dataManager;

        /// <summary>
        /// Default path for 
        /// </summary>
        private string _databasesPath;

        /// <summary>
        /// Current database name (set by New or Open; used on Save).
        /// </summary>
        private string _databaseName;

        /// <summary>
        /// Current state (set by New or Open; used on Save).
        /// </summary>
        private SavedDataManagerState _state;

        /// <summary>
        /// Preferences data manager.
        /// </summary>
        private PreferencesManager _preferencesManager;

        /// <summary>
        /// Preferences save location.
        /// </summary>
        private string _saveLocationBeforePreferences;

        /// <summary>
        /// Conversations Manager host.
        /// </summary>
        private ConversationsManagerHost _host;

        /// <summary>
        /// Add type.
        /// </summary>
        private AddType _addType;

        /// <summary>
        /// Selected ID.
        /// </summary>
        private Guid _selectedId;

        /// <summary>
        /// Selected node.
        /// </summary>
        private Guid _selectedNode;

        /// <summary>
        /// Selected list control type.
        /// </summary>
        private NodeListControlType _selectedType;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets database name (usually by SavedDataManager).
        /// </summary>
        /// <exception cref="InvalidPathException">Database name is invalid.</exception>
        public string DatabaseName
        {
            get { return _databaseName; }
            set
            {
                if (value != "" || value != null)
                {
                    _databaseName = value;
                }
                else
                {
                    throw new InvalidPathException();
                }
            }
        }

        /// <summary>
        /// Gets or sets main form state (by SavedDataManager).
        /// </summary>
        public SavedDataManagerState DatabaseState
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// Gets or sets parents flag.
        /// </summary>
        public bool Parents
        {
            get { return showParentsButton.Checked; }
            set
            {
                showParentsButton.Checked = value;
                _host.Parents = value;
            }
        }

        /// <summary>
        /// Gets or sets children flag.
        /// </summary>
        public bool Children
        {
            get { return showChildrenButton.Checked; }
            set
            {
                showChildrenButton.Checked = value;
                _host.Children = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
        public string ParsersPath
        {
           get { return _preferencesManager.Data.ParserPath; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default ConversationsManager constructor.
        /// </summary>
        public ConversationsManager()
        {
            // Initialize preferences manager
            _preferencesManager = new PreferencesManager();

            // Initialize host
            _host = null;

            // Set add type
            _addType = AddType.Reply;

            // Set default database path
            if (_preferencesManager.Data.DefaultLocation)
            {
                _databasesPath = Directory.GetCurrentDirectory();
            }
            else
            {
                _databasesPath = _preferencesManager.Data.SaveLocation;
            }

            // Initialize GUI
            InitializeComponent();
        }

        #endregion

        #region Events

        #region Main Menu

        #region File

        /// <summary>
        /// New click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newMainMenu_Click(object sender, EventArgs e)
        {
            New();
        }

        /// <summary>
        /// Open click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMainMenu_Click(object sender, EventArgs e)
        {
            Open();
        }

        /// <summary>
        /// Save click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMainMenu_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Save as click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsMainMenu_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        /// <summary>
        /// Exit click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMainMenu_Click(object sender, EventArgs e)
        {
            Exit();
        }

        #endregion

        #region Options

        /// <summary>
        /// Preferences click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preferencesMainMenu_Click(object sender, EventArgs e)
        {
            Preferences();
        }

        #endregion

        #region Help

        /// <summary>
        /// About click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutMainMenu_Click(object sender, EventArgs e)
        {
            About();
        }

        /// <summary>
        /// Tutorial click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tutorialMainMenu_Click(object sender, EventArgs e)
        {
            Tutorial();
        }

        #endregion

        #endregion

        #region Conversations

        /// <summary>
        /// Add button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
			//TODO see if this has any impact whatsoever
            //Type type = sender.GetType();
            int tagValue = int.Parse( ((ToolStripItem)sender).Tag.ToString());

            if (tagValue == 5)
            {
                switch (_addType)
                {
                    case AddType.Reply:
                        {
                            AddReply();
                            break;
                        }
                    case AddType.Child:
                        {
                            AddChild();
                            break;
                        }
                    case AddType.Parent:
                        {
                            AddParent();
                            break;
                        }
                }
            }
            else
            {
                switch (tagValue)
                {
                    case 0:
                        {
                            AddReply();
                            break;
                        }
                    case 1:
                        {
                            AddParent();
                            break;
                        }
                    case 2:
                        {
                            AddChild();
                            break;
                        }
                }
            }
        }
        
        /// <summary>
        /// Remove reply button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeReplyButton_Click(object sender, EventArgs e)
        {
            switch (_selectedType)
            {
                case NodeListControlType.Basic:
                    {
                        RemoveReply();
                        break;
                    }
                case NodeListControlType.Children:
                    {
                        RemoveChild();
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        RemoveParent();
                        break;
                    }
            }
        }

        /// <summary>
        /// Show parents button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showParentsButton_Click(object sender, EventArgs e)
        {
            showParentsButton.Checked = !showParentsButton.Checked;
            Parents = showParentsButton.Checked;
        }

        /// <summary>
        /// Show children button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showChildrenButton_Click(object sender, EventArgs e)
        {
            showChildrenButton.Checked = !showChildrenButton.Checked;
            Children = showChildrenButton.Checked;
        }

        /// <summary>
        /// Conversations host on selected item changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="valid"></param>
        /// <param name="id"></param>
        private void ConversationsHost_OnSelectedItemChanged(NodeListControl sender, bool valid, Guid id)
        {
            if (valid)
            {
                _selectedId = id;
                _selectedType = sender.Type;
            }

            switch (sender.Type)
            {
                case NodeListControlType.Basic:
                    {
                        SelectedNode(valid);
                        break;
                    }
                case NodeListControlType.Children:
                    {
                        SelectedChild(valid);
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        SelectedParent(valid);
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Children and parents context menu opening event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childrenParentsContextMenu_Opening(object sender, CancelEventArgs e)
        {
            NodeListControl control = (NodeListControl)(((ContextMenuStrip)sender).SourceControl);
            Guid rootNode = control.RootNode;

            addContext.Enabled = (rootNode != Guid.Empty);
            removeContext.Enabled = (_selectedType == control.Type);

            switch (control.Type)
            {
                case NodeListControlType.Children:
                    {
                        addContext.Tag = 2;
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        addContext.Tag = 1;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        #endregion

        #endregion

        #region Methods

        #region Main menu methods

        #region File

        /// <summary>
        /// Create new conversations database.
        /// </summary>
        private void New()
        {
            //TODO Ask if save current database (if not saved)
            SavedDataManagerForm newData = new SavedDataManagerForm(SavedDataManagerState.CreateNewData, _databasesPath, this, _preferencesManager.Format);

            if (newData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool newDatabase = (newData.State == SavedDataManagerState.CreateNewData);

                InitializeDatabase(newDatabase, newData.ImportFromFile, newData.ImportedConversation);
            }
        }

        /// <summary>
        /// Open existing conversations database.
        /// </summary>
        private void Open()
        {
            //TODO Ask if save current database (if not saved)
            SavedDataManagerForm openData = new SavedDataManagerForm(SavedDataManagerState.OpenExistingData, _databasesPath, this, _preferencesManager.Format);

            if (openData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool newDatabase = (openData.State == SavedDataManagerState.CreateNewData);
                InitializeDatabase(newDatabase, false, null);
            }
        }

        /// <summary>
        /// Save current conversations database.
        /// </summary>
        private void Save()
        {
            if (_dataManager != null)
            {
                _dataManager.SaveData();
            }

            // No data has been changed
            saveMainMenu.Enabled = false;
        }

        /// <summary>
        /// Save current conversations database as a different database.
        /// </summary>
        private void SaveAs()
        {
            //TODO Ask if save current database (if not saved)
            SaveAsForm saveas = new SaveAsForm(_databasesPath, this, _preferencesManager.Format);

            if (saveas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = _preferencesManager.Extension;
                string newPath = _databasesPath + "\\" + _databaseName + extension;
                _dataManager.ExportData(newPath);
                Text = "Conversations Manager - " + _databaseName;
                saveMainMenu.Enabled = false;
            }
        }

        /// <summary>
        /// Exit current application
        /// </summary>
        private void Exit()
        {
            //TODO Ask if save changed data
            this.Close();
        }

        #endregion

        #region Options

        /// <summary>
        /// Show application preferences.
        /// </summary>
        private void Preferences()
        {
            PreferencesForm pform = new PreferencesForm(_preferencesManager);

            _saveLocationBeforePreferences = _preferencesManager.Data.SaveLocation;

            if (pform.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                PreferencesChanged();
            }
        }

        #endregion

        #region Help

        /// <summary>
        /// Show about window.
        /// </summary>
        private void About()
        {
            //TODO implement about window.
        }

        /// <summary>
        /// Show tutorial window.
        /// </summary>
        private void Tutorial()
        {
            //TODO implement tutorial window.
        }

        #endregion

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newDatabase"></param>
        /// <param name="importFileAsWell"></param>
        /// <param name="importedConversation"></param>
        private void InitializeDatabase(bool newDatabase, bool importFileAsWell, Tuple<string, string, string> importedConversation)
        {
            //TODO Ask about current loaded database (if any loaded)

            // Read or create new databae
            string extension = newDatabase ? _preferencesManager.Extension : "";
            string path = _databasesPath + "\\" + _databaseName + extension;
            Text = "Conversations Manager - " + _databaseName;
            switch (_state)
            {
                case SavedDataManagerState.CreateNewData:
                    {
                        _dataManager = new DataManager(path, true);
                        saveMainMenu.Enabled = true;
                        saveAsMainMenu.Enabled = true;
                        break;
                    }
                case SavedDataManagerState.OpenExistingData:
                    {
                        _dataManager = new DataManager(path, false);
                        saveMainMenu.Enabled = true;
                        saveAsMainMenu.Enabled = true;
                        break;
                    }
            }

            // Initialize data
            if (importFileAsWell)
            {
               InitializeData(importedConversation);
            }
            else
            {
               InitializeData();
            }
        }

        /// <summary>
        /// Intialize data.
        /// </summary>
        private void InitializeData()
        {
            //TODO Initialize current data
            // Get host flags
            bool graphFlag = false;
            bool parentsFlag = false;
            bool childrenFlag = false;

            // Initialize host and add it to conversationsHost
            conversationsToolStrip.Visible = true;
            conversationsHost.Controls.Clear();
            _host = new ConversationsManagerHost(_dataManager, graphFlag, parentsFlag, childrenFlag);
            _host.OnSelectedItemChanged += new ConversationsManagerHost.SelectedItemChanged(ConversationsHost_OnSelectedItemChanged);
            _host.SetContextMenu(NodeListControlType.Basic, nodesContextMenu);
            _host.SetContextMenu(NodeListControlType.Children, childrenParentsContextMenu);
            _host.SetContextMenu(NodeListControlType.Parents, childrenParentsContextMenu);
            conversationsHost.Controls.Add(_host);
            _host.UpdateContent(false);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="importedConversation"></param>
        private void InitializeData(Tuple<string, string, string> importedConversation)
        {
           //TODO Initialize current data
           // Get host flags
           bool graphFlag = false;
           bool parentsFlag = false;
           bool childrenFlag = false;

           // Import data
           string libraryPath = Directory.GetCurrentDirectory() + "\\" + _preferencesManager.Data.ParserPath + "\\" + importedConversation.Item2;
           string parserName = importedConversation.Item3;
           string importFile = importedConversation.Item1;
           IConversationParser parser = ParserLoader.LoadParser(libraryPath, parserName);

           if (parser.ExpectedFormat(importFile))
           {
              List<ParsedReply> parsedReplies = parser.ParseConversation(importFile, new List<Guid>());

              _dataManager.ImportDataFromListOfParsedReplies(parsedReplies);
           }
           else
           {
              //TODO throw some exception or error
           }

           // Initialize host and add it to conversationsHost
           conversationsToolStrip.Visible = true;
           conversationsHost.Controls.Clear();
           _host = new ConversationsManagerHost(_dataManager, graphFlag, parentsFlag, childrenFlag);
           _host.OnSelectedItemChanged += new ConversationsManagerHost.SelectedItemChanged(ConversationsHost_OnSelectedItemChanged);
           _host.SetContextMenu(NodeListControlType.Basic, nodesContextMenu);
           _host.SetContextMenu(NodeListControlType.Children, childrenParentsContextMenu);
           _host.SetContextMenu(NodeListControlType.Parents, childrenParentsContextMenu);
           conversationsHost.Controls.Add(_host);
           _host.UpdateContent(false);
        }

        /// <summary>
        /// Preferences changed.
        /// </summary>
        private void PreferencesChanged()
        {
            //TODO Initialize language (if changed)
            //TODO Initialize theme (if changed)
            //TODO Move data (if location changed)
            if (_saveLocationBeforePreferences != _preferencesManager.Data.SaveLocation)
            {
                MoveData(_saveLocationBeforePreferences, _preferencesManager.Data.SaveLocation);
            }
        }

        /// <summary>
        /// Move files from a location to another.
        /// </summary>
        /// <param name="from">Location from where the files should be moved.</param>
        /// <param name="to">Location where the files should be moved to.</param>
        /// <exception cref="InvalidPathException">At least on of the locations is invalid.</exception>
        private void MoveData(string from, string to)
        {
            // Format from and to paths
            from = (from == "") ? Directory.GetCurrentDirectory() : from;
            to = (to == "") ? Directory.GetCurrentDirectory() : to;

            if (Directory.Exists(from) == false || Directory.Exists(to) == false)
            {
                throw new InvalidPathException();
            }

            string[] binaryFiles = Directory.GetFiles(from, "*" + PreferencesManager.GetExtension(ExternalFormat.BinaryFormat));
            string[] xmlFiles = Directory.GetFiles(from, "*" + PreferencesManager.GetExtension(ExternalFormat.XMLFormat));

            // Copy binary files
            foreach (string file in binaryFiles)
            {
                string source = file;
                string destination = to + file.Replace(from, "");
                File.Move(source, destination);
            }

            // Copy xml files
            foreach (string file in xmlFiles)
            {
                string filename = file.Replace(from, "");

                if (filename == "\\preferences.xml")
                {
                    continue;
                }

                string source = file;
                string destination = to + filename;
                File.Move(source, destination);
            }
        }

        #region Conversations

        /// <summary>
        /// Add reply.
        /// </summary>
        private void AddReply()
        {
            AddReplyForm add = new AddReplyForm(_dataManager);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateContent(false);
            }

            _addType = AddType.Reply;
            addButton.ToolTipText = "Add reply";
        }

        /// <summary>
        /// Add child.
        /// </summary>
        private void AddChild()
        {
            //TODO implement add child
            Guid currentNode = _selectedId;
            AddLinkForm add = new AddLinkForm(ReplyField.Child, _dataManager, currentNode);

            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateContent(ReplyField.Child);
            }

            _addType = AddType.Child;
            addButton.ToolTipText = "Add child";
        }

        /// <summary>
        /// Add parent.
        /// </summary>
        private void AddParent()
        {
            //TODO implement add parent
            Guid currentNode = _selectedId;
            AddLinkForm add = new AddLinkForm(ReplyField.Parent, _dataManager, currentNode);

            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateContent(ReplyField.Parent);
            }

            _addType = AddType.Parent;
            addButton.ToolTipText = "Add parent";
        }

        /// <summary>
        /// Update content.
        /// </summary>
        /// <param name="deletedNode">Field that needs updated</param>
        private void UpdateContent(ReplyField deletedNode)
        {
            _host.UpdateContent(deletedNode);
        }

        /// <summary>
        /// Update content.
        /// </summary>
        /// <param name="deleted">Whether or not something was deleted.</param>
        private void UpdateContent(bool deleted)
        {
            _host.UpdateContent(deleted);
        }

        /// <summary>
        /// Select node.
        /// </summary>
        /// <param name="valid">Mark as valid selection.</param>
        private void SelectedNode(bool valid)
        {
            addChildOption.Enabled = valid;
            addChildContext.Enabled = valid;
            addParentOption.Enabled = valid;
            addParentContext.Enabled = valid;
            removeReplyButton.Enabled = valid;
            removeReplyContext.Enabled = valid;
            removeReplyButton.ToolTipText = "Remove selected node";

            if (valid)
            {
                _selectedNode = _selectedId;
                _host.PopulateChildren(_selectedId);
                _host.PopulateParents(_selectedId);
            }
            else
            {
                _addType = AddType.Reply;
                _selectedType = NodeListControlType.Basic;
                addButton.ToolTipText = "Add reply";
                _host.ClearChildren();
                _host.ClearParents();
            }
        }

        /// <summary>
        /// Select child.
        /// </summary>
        /// <param name="valid">Mark as valid.</param>
        private void SelectedChild(bool valid)
        {
            removeReplyButton.Enabled = true;
            removeContext.Enabled = valid;
            addContext.Enabled = true;

            if (valid)
            {
                removeReplyButton.ToolTipText = "Remove selected child";
                _selectedType = NodeListControlType.Children;
            }
            else
            {
                removeReplyButton.ToolTipText = "Remove selected node";
                _selectedType = NodeListControlType.Basic;
            }

            _addType = AddType.Child;
            addButton.ToolTipText = "Add child";
        }

        /// <summary>
        /// Select parent.
        /// </summary>
        /// <param name="valid">Mark as valid.</param>
        private void SelectedParent(bool valid)
        {
            removeReplyButton.Enabled = true;
            removeContext.Enabled = valid;

            if (valid)
            {
                removeReplyButton.ToolTipText = "Remove selected parent";
                _selectedType = NodeListControlType.Parents;
            }
            else
            {
                removeReplyButton.ToolTipText = "Remove selected node";
                _selectedType = NodeListControlType.Basic;
            }

            _addType = AddType.Parent;
            addButton.ToolTipText = "Add parent";
        }

        /// <summary>
        /// Remove selected reply.
        /// </summary>
        private void RemoveReply()
        {
            //TODO Ask if sure to remove (if enabled)
            removeReplyButton.Enabled = false;
            _dataManager.RemoveReply(_selectedId);
            UpdateContent(true);
        }

        /// <summary>
        /// Remove selected child.
        /// </summary>
        private void RemoveChild()
        {
            //TODO Ask if sure to remove (if enabled)
            removeReplyButton.Enabled = false;
            _dataManager.RemoveLink(_selectedNode, ReplyField.Child, _selectedId);
            UpdateContent(ReplyField.Child);
        }

        /// <summary>
        /// Remove selected parent.
        /// </summary>
        private void RemoveParent()
        {
            //TODO Ask if sure to remove (if enabled)
            removeReplyButton.Enabled = false;
            _dataManager.RemoveLink(_selectedNode, ReplyField.Parent, _selectedId);
            UpdateContent(ReplyField.Parent);
        }

        #endregion

        #endregion
    }
}
