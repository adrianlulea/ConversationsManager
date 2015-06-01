using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Data.Conversations;
using Framework.Util;
using Framework.GUI.Forms.Conversations;

namespace Framework.GUI.Controls.Conversations
{
    /// <summary>
    /// NodeListControl control class.
    /// </summary>
    public partial class NodeListControl : UserControl
    {
        #region Members

        /// <summary>
        /// Flag whether or not header should be visible.
        /// </summary>
        private bool _header;

        /// <summary>
        /// NodeListControl type.
        /// </summary>
        private NodeListControlType _type;
        
        /// <summary>
        /// String value of NodeListControl type.
        /// </summary>
        private string _typeAsString;

        /// <summary>
        /// Root node Guid.
        /// </summary>
        private Guid _rootNode;

        /// <summary>
        /// Conversations Data Manager.
        /// </summary>
        private DataManager _dataManager;

        /// <summary>
        /// List of nodes.
        /// </summary>
        private List<Guid> _nodes;

        /// <summary>
        /// Tool tip.
        /// </summary>
        private ToolTip toolTip = null;

        /// <summary>
        /// List of exceptions.
        /// </summary>
        private List<Guid> _exceptions;

        /// <summary>
        /// Node view mode.
        /// </summary>
        private ViewNodeMode _viewMode;

        /// <summary>
        /// Flag whether or not view mode is initializing.
        /// </summary>
        private bool _initializingViewNode;

        /// <summary>
        /// Flag whether or not reply's author was changed.
        /// </summary>
        private bool _authorChanged;

        /// <summary>
        /// Flag whether or not reply's text was changed.
        /// </summary>
        private bool _textChanged;

        /// <summary>
        /// Selected reply's data.
        /// </summary>
        private InternalReplyData _selectedNode;

        /// <summary>
        /// Selected reply's ID.
        /// </summary>
        private Guid _selectedId;

        /// <summary>
        /// Selected reply's author.
        /// </summary>
        private string _author;

        /// <summary>
        /// Selected reply's text.
        /// </summary>
        private string _text;

        #endregion

        #region Properties

        /// <summary>
        /// Get or set control's header flag.
        /// </summary>
        public bool Header
        {
            get { return _header; }
            set
            {
                _header = value;
                toolStrip1.Visible = value;
            }
        }

        /// <summary>
        /// Get or set NodeListControl type.
        /// </summary>
        public NodeListControlType Type
        {
            get { return _type; }
            set
            {
                _type = value;

                switch (value)
                {
                    case NodeListControlType.Basic:
                        {
                            _typeAsString = "Nodes";
                            break;
                        }
                    case NodeListControlType.Children:
                        {
                            _typeAsString = "Children";
                            break;
                        }
                    case NodeListControlType.Parents:
                        {
                            _typeAsString = "Parents";
                            break;
                        }
                    default:
                        {
                            throw new InvalidFieldException();
                        }
                }
                if (nodeList != null)
                {
                    toolTip.SetToolTip(nodeList, _typeAsString);
                }
            }
        }
        
        /// <summary>
        /// Get NodeListControl type as string.
        /// </summary>
        public string TypeAsString
        {
            get { return _typeAsString; }
        }

        /// <summary>
        /// Get or set root node.
        /// </summary>
        public Guid RootNode
        {
            get { return _rootNode; }
            set { _rootNode = value; }
        }

        /// <summary>
        /// Get selected reply's ID.
        /// </summary>
        public Guid SelectedNode
        {
            get
            {
                if (nodeList != null && nodeList.SelectedItems.Count == 1)
                {
                    return (Guid)nodeList.SelectedItems[0].Tag;
                }
                else
                {
                    return Guid.Empty;
                }
            }
            set
            {
                foreach (ListViewItem item in nodeList.Items)
                {
                    if (((Guid)item.Tag) == value)
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        /// <summary>
        /// Set list of exceptions
        /// </summary>
        public List<Guid> Exceptions
        {
            set { _exceptions = value; }
        }

        /// <summary>
        /// Get or set view mode type.
        /// </summary>
        public ViewNodeMode ViewNodeMode
        {
            get { return _viewMode; }
            set
            {
                _viewMode = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default NodeListControl control constructor.
        /// </summary>
        /// <param name="type">NodeListControl type.</param>
        /// <param name="dataManager">Conversations Data Manager.</param>
        public NodeListControl(NodeListControlType type, DataManager dataManager)
        {
            _exceptions = new List<Guid>();
            _initializingViewNode = false;

            // Set type (enum and string)
            Type= type;

            // Set data manager link
            _dataManager = dataManager;

            // Set root node
            _rootNode = Guid.Empty;

            // Initialize GUI
            InitializeComponent();

            // Default header = false
            Header = false;

            // Default Dock = DockStyle.Fill
            Dock = DockStyle.Fill;

            toolTip = new ToolTip();
            toolTip.SetToolTip(nodeList, _typeAsString);
            nodeList.HideSelection = (type != NodeListControlType.Basic);
            splitContainer1.Panel2Collapsed = true;
        }

        #endregion

        #region Events

        #region Own Created Events

        #region OnInvalidInformation

        /// <summary>
        /// InvalidInformation delegate.
        /// </summary>
        /// <param name="sender"></param>
        public delegate void InvalidInformation(NodeListControl sender);

        /// <summary>
        /// OnInvalidInformation event.
        /// </summary>
        public event InvalidInformation OnInvalidInformation;

        #endregion

        #region OnSelectedItemChanged

        /// <summary>
        /// SelectedItemChanged delegate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="valid"></param>
        /// <param name="id"></param>
        public delegate void SelectedItemChanged(NodeListControl sender, bool valid, Guid id);

        /// <summary>
        /// OnSelectedItemChanged event.
        /// </summary>
        public event SelectedItemChanged OnSelectedItemChanged;

        #endregion

        #region OnOpenedItem

        /// <summary>
        /// OpenedItemChanged delegate,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="valid"></param>
        /// <param name="id"></param>
        public delegate void OpenedItemChanged(NodeListControl sender, bool valid, Guid id);

        /// <summary>
        /// OnOpenedItemChanged event.
        /// </summary>
        public event OpenedItemChanged OnOpenedItemChanged;

        #endregion

        #region OnNodeDataChanged
        
        /// <summary>
        /// NodeDataChanged delegate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="id"></param>
        public delegate void NodeDataChanged(NodeListControl sender, Guid id);

        /// <summary>
        /// OnNodeDataChanged event.
        /// </summary>
        public event NodeDataChanged OnNodeDataChanged;

        #endregion

        #endregion

        /// <summary>
        /// SelectedIndexChanged event handler.
        /// </summary>
        /// <param name="sender">nodeList</param>
        /// <param name="e"></param>
        private void nodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool valid = false;
            _selectedId = Guid.Empty;

            if (nodeList.SelectedIndices.Count == 1)
            {
                _selectedId = (Guid)nodeList.SelectedItems[0].Tag;
                _selectedNode = _dataManager.GetReplyData(_selectedId);
                valid = true;
            }

            if (valid)
            {
                ViewInCurrentWindow(_selectedId);
            }
            else
            {
                ClearCurrentWindow();
            }

            if (OnSelectedItemChanged != null)
            {
                OnSelectedItemChanged.Invoke(this, valid, _selectedId);
            }
        }

        /// <summary>
        /// OpenedItem event handler.
        /// </summary>
        /// <param name="sender">nodeList</param>
        /// <param name="e"></param>
        private void nodeList_OpenedItem(object sender, MouseEventArgs e)
        {
            bool valid = false;
            Guid id = Guid.Empty;

            if (nodeList.SelectedIndices.Count == 1)
            {
                id = (Guid)nodeList.SelectedItems[0].Tag;
                valid = true;
            }

            if (OnOpenedItemChanged != null)
            {
                OnOpenedItemChanged.Invoke(this, valid, id);
            }
            else
            {
                ViewNode(valid, id);
            }
        }

        /// <summary>
        /// TextChanged event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_initializingViewNode)
            {
                return;
            }

            Control tb = (Control)sender;
            int tag = int.Parse(tb.Tag.ToString());
            ReplyField field = GetField(tag);
            ToggleSaveChangesButton(field, tb.Text);
        }

        /// <summary>
        /// Click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (_authorChanged)
            {
                _selectedNode.Author = authorTextBox.Text;
            }

            if (_textChanged)
            {
                _selectedNode.Text = replyTextBox.Text;
            }

            if (OnNodeDataChanged != null)
            {
                OnNodeDataChanged(this, _selectedId);
            }

            saveChangesButton.Enabled = false;
        }

        /// <summary>
        /// Click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hideButton_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Populate ListViewItem from internal reply.
        /// </summary>
        /// <param name="data">Internal Reply</param>
        /// <returns>ListViewItem</returns>
        private ListViewItem PopulateListItem(InternalReply data)
        {
            ListViewItem item = new ListViewItem(data.Timestamp.ToString());

            item.SubItems.Add(data.Author);
            item.SubItems.Add(data.Text.Replace('\n', ' '));
            item.SubItems.Add(data.ChildCount.ToString());
            item.SubItems.Add(data.ParentCount.ToString());

            item.Tag = data.Id;

            return item;
        }

        /// <summary>
        /// Populate ListViewItem from internal reply data and given id.
        /// </summary>
        /// <param name="id">Internal Reply Data ID.</param>
        /// <param name="data">Internal Reply Data</param>
        /// <returns>ListViewItem</returns>
        private ListViewItem PopulateListItem(Guid id, InternalReplyData data)
        {
            ListViewItem item = new ListViewItem(data.Timestamp.ToString());

            item.SubItems.Add(data.Author);
            item.SubItems.Add(data.Text.Replace('\n', ' '));
            item.SubItems.Add(data.ChildCount.ToString());
            item.SubItems.Add(data.ParentCount.ToString());
            item.Tag = id;

            return item;
        }

        /// <summary>
        /// Initialize replies for current root node.
        /// </summary>
        private void InitializeReplies()
        {
            if (_rootNode == Guid.Empty)
            {
                InitializeAllReplies();
                return;
            }

            nodeList.Items.Clear();
            ListViewItem item;

            foreach (InternalReply reply in _dataManager.Replies)
            {
                if (reply.Id == _rootNode ||
                    reply.Children.Contains(_rootNode) ||
                    reply.Parents.Contains(_rootNode)
                    )
                {
                    continue;
                }
                item = PopulateListItem(reply);
                nodeList.Items.Add(item);
            }
        }

        /// <summary>
        /// Initialize all replies
        /// </summary>
        private void InitializeAllReplies()
        {
            nodeList.Items.Clear();
            ListViewItem item;

            foreach (InternalReply reply in _dataManager.Replies)
            {
                if (_exceptions.Contains(reply.Id))
                {
                    continue;
                }

                item = PopulateListItem(reply);
                nodeList.Items.Add(item);
            }
        }

        /// <summary>
        /// Initialize children for current root node.
        /// </summary>
        private void InitializeChildren()
        {
            // Initialize nodes list
            _nodes = _dataManager.GetChildren(_rootNode);

            // Add nodes to list
            nodeList.Items.Clear();
            ListViewItem item;
            foreach (Guid node in _nodes)
            {
                InternalReplyData child = _dataManager.GetReplyData(node);

                item = PopulateListItem(node, child);
                nodeList.Items.Add(item);
            }
        }

        /// <summary>
        /// Initialize parents for current root node.
        /// </summary>
        private void InitializeParents()
        {
            // Initialize nodes list
            _nodes = _dataManager.GetParents(_rootNode);

            // Add nodes to list
            nodeList.Items.Clear();
            ListViewItem item;
            foreach (Guid node in _nodes)
            {
                InternalReplyData parent = _dataManager.GetReplyData(node);

                item = PopulateListItem(node, parent);
                nodeList.Items.Add(item);
            }
        }

        /// <summary>
        /// Clear control content.
        /// </summary>
        public void ClearContent()
        {
            nodeList.Items.Clear();

            if (OnInvalidInformation != null)
            {
                OnInvalidInformation.Invoke(this);
            }
        }

        /// <summary>
        /// Refresh control content
        /// </summary>
        /// <exception cref="InvalidFieldException">NodeListControl type is invalid.</exception>
        public void UpdateContent()
        {
            switch (_type)
            {
                case NodeListControlType.Basic:
                    {
                        // Initialize all replies
                        InitializeReplies();
                        break;
                    }
                case NodeListControlType.Children:
                    {
                        // Initialize node's children
                        InitializeChildren();
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        // Initialize node's parents
                        InitializeParents();
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Add ListViewItem
        /// </summary>
        /// <param name="item">ListViewItem to add.</param>
        public void AddItem(ListViewItem item)
        {
            nodeList.Items.Add(item);
        }

        /// <summary>
        /// Remove item by id.
        /// </summary>
        /// <param name="id">Item id.</param>
        public void RemoveItem(Guid id)
        {
            foreach (ListViewItem item in nodeList.Items)
            {
                Guid itemId = (Guid)item.Tag;

                if (id == itemId)
                {
                    nodeList.Items.Remove(item);
                    break;
                }
            }
        }

        /// <summary>
        /// View node.
        /// </summary>
        /// <param name="show">Whether or not the node should be seen.</param>
        /// <param name="id">Node's ID.</param>
        /// <exception cref="InvalidFieldException">View mode is invalid.</exception>
        public void ViewNode(bool show, Guid id)
        {
            if (show == false)
            {
                return;
            }

            switch (_viewMode)
            {
                case ViewNodeMode.AsANewWindow:
                    {
                        ViewAsNewWindow(id);
                        break;
                    }
                case ViewNodeMode.InCurrentWindow:
                    {
                        splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
                        ViewInCurrentWindow(id);
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Clear current window's content.
        /// </summary>
        private void ClearCurrentWindow()
        {
            _initializingViewNode = true;

            authorTextBox.Text = "";
            replyTextBox.Text = "";

            authorTextBox.Enabled = false;
            replyTextBox.Enabled = false;
            saveChangesButton.Enabled = false;

            _authorChanged = false;
            _textChanged = false;

            _initializingViewNode = false;
        }

        /// <summary>
        /// View Node in current window
        /// </summary>
        /// <param name="id">Node's ID.</param>
        private void ViewInCurrentWindow(Guid id)
        {
            _initializingViewNode = true;

            authorTextBox.Enabled = true;
            replyTextBox.Enabled = true;

            _authorChanged = false;
            _textChanged = false;

            authorTextBox.Text = _selectedNode.Author;
            replyTextBox.Text = _selectedNode.Text;

            _initializingViewNode = false;
        }

        /// <summary>
        /// View Node in a new window.
        /// </summary>
        /// <param name="id">Node's ID.</param>
        private void ViewAsNewWindow(Guid id)
        {
            ViewReplyForm view = new ViewReplyForm(_dataManager.GetReplyData(id));
            view.ShowDialog();

            if (view.DataChanged)
            {
                UpdateContent();

                if (OnNodeDataChanged != null)
                {
                    OnNodeDataChanged.Invoke(this, id);
                }
            }
        }

        /// <summary>
        /// Get ReplyField
        /// </summary>
        /// <param name="tag">Tag.</param>
        /// <exception cref="InvalidFieldException">Tag is invalid.</exception>
        /// <returns>ReplyField</returns>
        private ReplyField GetField(int tag)
        {
            switch (tag)
            {
                case 0:
                    {
                        return ReplyField.Author;
                    }
                case 1:
                    {
                        return ReplyField.Text;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }
        
        /// <summary>
        /// Toggle save changes button.
        /// </summary>
        /// <param name="field">Field to test.</param>
        /// <param name="data">Value.</param>
        /// <exception cref="InvalidFieldException">Invalid field.</exception>
        private void ToggleSaveChangesButton(ReplyField field, string data)
        {
            switch (field)
            {
                case ReplyField.Author:
                    {
                        _authorChanged = (_selectedNode.Author != data);
                        _author = data;
                        break;
                    }
                case ReplyField.Text:
                    {
                        _textChanged = (_selectedNode.Text != data);
                        _text = data;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            bool dataChanged = (_authorChanged || _textChanged);
            bool dataIsValid = ((_author == "" || _text == "") == false);

            saveChangesButton.Enabled = (dataChanged && dataIsValid);
        }

        /// <summary>
        /// Refresh Node.
        /// </summary>
        /// <param name="id">Node id.</param>
        public void RefreshField(Guid id)
        {
            foreach (ListViewItem item in nodeList.Items)
            {
                if (((Guid)item.Tag) == id)
                {
                    RefreshField(item);
                    break;
                }
            }
        }

        /// <summary>
        /// Refresh Node.
        /// </summary>
        /// <param name="item">ListViewItem.</param>
        public void RefreshField(ListViewItem item)
        {
            Guid id = (Guid)item.Tag;
            InternalReplyData data = _dataManager.GetReplyData(id);

            item.Text = data.Timestamp.ToString();
            item.SubItems[1].Text = data.Author;
            item.SubItems[2].Text = data.Text.Replace('\n', ' ');
            item.SubItems[3].Text = data.ChildCount.ToString();
            item.SubItems[4].Text = data.ParentCount.ToString();
        }

        #endregion
    }
}
