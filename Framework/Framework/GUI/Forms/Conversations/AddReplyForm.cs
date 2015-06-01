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
using Framework.GUI.Controls.Conversations;
using System.Reflection;
using Framework.Util.Parsing;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Add reply form.
    /// </summary>
    public partial class AddReplyForm : Form
    {
        #region Members
        
        /// <summary>
        /// Conversations data manager.
        /// </summary>
        private DataManager _dataManager;

        /// <summary>
        /// Flag whether or not the form is initializing.
        /// </summary>
        private bool _initializing;

        /// <summary>
        /// List of children.
        /// </summary>
        private List<Guid> _children;

        /// <summary>
        /// List of parents.
        /// </summary>
        private List<Guid> _parents;

        /// <summary>
        /// Reply's ID.
        /// </summary>
        private Guid _id;

        /// <summary>
        /// Reply's data.
        /// </summary>
        private InternalReplyData _replyData;

        /// <summary>
        /// Add reply type.
        /// </summary>
        private AddReplyType _type;

        /// <summary>
        /// Basic information control.
        /// </summary>
        private BasicInformationControl basicInformation;

        /// <summary>
        /// Children node list control.
        /// </summary>
        private NodeListControl childrenList;

        /// <summary>
        /// Parents node list control.
        /// </summary>
        private NodeListControl parentList;

        /// <summary>
        /// Selected link ID,
        /// </summary>
        private Guid _selectedLinkId;

        /// <summary>
        /// Selected link type.
        /// </summary>
        private NodeListControlType _selectedLinkType;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets reply's Timestamp.
        /// </summary>
        public DateTime Timestamp
        {
            get { return basicInformation.Timestamp; }
            set { basicInformation.Timestamp = value; }
        }

        /// <summary>
        /// Gets or sets reply's Author.
        /// </summary>
        public string Author
        {
            get { return basicInformation.Author; }
            set { basicInformation.Author = value; }
        }

        /// <summary>
        /// Gets or sets reply's text.
        /// </summary>
        public string Reply
        {
            get { return basicInformation.Reply; }
            set { basicInformation.Reply = value; }
        }

        /// <summary>
        /// Gets reply's children.
        /// </summary>
        public List<Guid> Children
        {
            get { return _children; }
        }

        /// <summary>
        /// Gets reply's parents.
        /// </summary>
        public List<Guid> Parents
        {
            get { return _parents; }
        }

        /// <summary>
        /// Gets reply's ID.
        /// </summary>
        public Guid Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets reply's data.
        /// </summary>
        public InternalReplyData ReplyData
        {
            get { return _replyData; }
        }

        /// <summary>
        /// Gets add reply type.
        /// </summary>
        public AddReplyType AddType
        {
            get { return _type; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default AddReplyForm constructor.
        /// </summary>
        /// <param name="dataManager">Conversations data manager.</param>
        public AddReplyForm(DataManager dataManager)
        {
            // Set initializing flag
            _initializing = true;

            // Set data manager
            _dataManager = dataManager;

            // Set add type
            _type = AddReplyType.FromUser;

            // Initialize children and parents
            _children = new List<Guid>();
            _parents = new List<Guid>();

            // Initialize GUI
            InitializeComponent();

            // Initialize controls
            InitializeControls();

            // Unset initializing flag
            _initializing = false;
        }

        #endregion

        #region Events

        /// <summary>
        /// Radio button checked changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            int tagValue = int.Parse(rb.Tag.ToString());

            if (rb.Checked == false || _initializing)
            {
                return;
            }

            switch (tagValue)
            {
                case 0:
                    {
                        AddingReplyFromUser();
                        break;
                    }
                case 1:
                    {
                        AddingReplyFromXML();
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Reply data mode changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void replyDataMode_Changed(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            int tagValue = int.Parse(tsmi.Tag.ToString());

            if (replyDropDownButton.Text == tsmi.Text || _initializing)
            {
                // skip if same type
                return;
            }

            replyDropDownButton.Text = tsmi.Text;

            switch (tagValue)
            {
                case 0:
                    {
                        _selectedLinkType = NodeListControlType.Basic;
                        basicInformation.BringToFront();
                        addReplyButton.Visible = false;
                        removeReplyButton.Visible = false;
                        break;
                    }
                case 1:
                    {
                        _selectedLinkType = NodeListControlType.Children;
                        childrenList.BringToFront();
                        addReplyButton.Visible = true;
                        removeReplyButton.Visible = true;
                        break;
                    }
                case 2:
                    {
                        _selectedLinkType = NodeListControlType.Parents;
                        parentList.BringToFront();
                        addReplyButton.Visible = true;
                        removeReplyButton.Visible = true;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Browse xml button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseXmlButton_Click(object sender, EventArgs e)
        {
            browseXMLFile.InitialDirectory = Directory.GetCurrentDirectory();
            importReplyButton.Enabled = (browseXMLFile.ShowDialog() == System.Windows.Forms.DialogResult.OK);
        }

        /// <summary>
        /// Done button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            UpdateDatabase();
            this.Close();
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
        /// Basic information on invalid information event handler.
        /// </summary>
        /// <param name="sender"></param>
        private void basicInformation_OnInvalidInformation(BasicInformationControl sender)
        {
            doneButton.Enabled = false;
        }

        /// <summary>
        /// Basic information on valid information event handler.
        /// </summary>
        /// <param name="sender"></param>
        private void basicInformation_OnValidInformation(BasicInformationControl sender)
        {
            doneButton.Enabled = true;
        }

        /// <summary>
        /// Node list on selected item changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="valid"></param>
        /// <param name="id"></param>
        private void NodeList_OnSelectedItemChanged(NodeListControl sender, bool valid, Guid id)
        {
            _selectedLinkType = sender.Type;
            _selectedLinkId = id;
            removeReplyButton.Enabled = valid;
        }

        /// <summary>
        /// Add reply button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addReplyButton_Click(object sender, EventArgs e)
        {
            List<Guid> restrictionList = new List<Guid>();
            restrictionList.AddRange(_children);
            restrictionList.AddRange(_parents);

            switch (_selectedLinkType)
            {
                case NodeListControlType.Children:
                    {
                        AddLinkForm add = new AddLinkForm(ReplyField.Child, _dataManager, restrictionList);
                        if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            _children.Add(add.SelectedNode);
                            ListViewItem item = _dataManager.PopulateItem(add.SelectedNode);
                            childrenList.AddItem(item);
                        }
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        AddLinkForm add = new AddLinkForm(ReplyField.Parent, _dataManager, restrictionList);
                        if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            _parents.Add(add.SelectedNode);
                            ListViewItem item = _dataManager.PopulateItem(add.SelectedNode);
                            parentList.AddItem(item);
                        }
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
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
            switch (_selectedLinkType)
            {
                case NodeListControlType.Children:
                    {
                        _children.Remove(_selectedLinkId);
                        childrenList.RemoveItem(_selectedLinkId);
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        _parents.Remove(_selectedLinkId);
                        parentList.RemoveItem(_selectedLinkId);
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add reply from XML.
        /// </summary>
        private void AddingReplyFromXML()
        {
            browseXmlButton.Enabled = true;
            splitContainer1.Panel2Collapsed = true;
        }

        /// <summary>
        /// Add reply from user.
        /// </summary>
        private void AddingReplyFromUser()
        {
            browseXmlButton.Enabled = false;
            importReplyButton.Enabled = false;
            doneButton.Enabled = false;
            splitContainer1.Panel2Collapsed = false;
            basicInformationToolStripMenuItem.PerformClick();
            basicInformation.ResetInformation();
            parentList.ClearContent();
            childrenList.ClearContent();
            _children = new List<Guid>();
            _parents = new List<Guid>();
            _type = AddReplyType.FromUser;
            _selectedLinkType = NodeListControlType.Basic;
        }

        /// <summary>
        /// Update database.
        /// </summary>
        private void UpdateDatabase()
        {
            _replyData = new InternalReplyData(Timestamp, Author, Reply);
            _id = _dataManager.AddReply(_replyData);

            // Link node with children
            foreach (Guid child in _children)
            {
                _dataManager.AddLink(_id, ReplyField.Child, child);
            }

            // Link node with parents
            foreach (Guid parent in _parents)
            {
                _dataManager.AddLink(_id, ReplyField.Parent, parent);
            }
        }

        /// <summary>
        /// Initialize controls.
        /// </summary>
        private void InitializeControls()
        {
            basicInformation = new BasicInformationControl();

            childrenList = new NodeListControl(NodeListControlType.Children, _dataManager);
            parentList = new NodeListControl(NodeListControlType.Parents, _dataManager);

            basicInformation.OnInvalidInformation += new BasicInformationControl.InvalidInformation(basicInformation_OnInvalidInformation);
            basicInformation.OnValidInformation +=new BasicInformationControl.ValidInformation(basicInformation_OnValidInformation);

            childrenList.OnSelectedItemChanged += new NodeListControl.SelectedItemChanged(NodeList_OnSelectedItemChanged);
            parentList.OnSelectedItemChanged += new NodeListControl.SelectedItemChanged(NodeList_OnSelectedItemChanged);

            replyDataHost.Controls.Add(basicInformation);
            replyDataHost.Controls.Add(parentList);
            replyDataHost.Controls.Add(childrenList);
        }


        private void ImportData(string file, IConversationParser parser)
        {

            if (parser.ExpectedFormat(file))
            {
                List<ParsedReply> parsedData = parser.ParseConversation(file, _dataManager.UsedIds);

                tempConsole.Text = "";

                foreach (ParsedReply reply in parsedData)
                {
                    string replyInString = reply.ToString();
                    Console.WriteLine(replyInString);
                    tempConsole.Text = tempConsole.Text + replyInString + "\n";
                }

            }
            else
            {
                // Signal error
            }
        }

        #endregion

        private void importReplyButton_Click(object sender, EventArgs e)
        {
            // Make static/public or something
            string libraryLocation = "DefaultParser.dll";
            string parserName = "DefaultParser";
            string parsedFile = browseXMLFile.FileName;

            IConversationParser parser = ParserLoader.LoadParser(libraryLocation, parserName);

            ImportData(parsedFile, parser);
        }
    }
}
