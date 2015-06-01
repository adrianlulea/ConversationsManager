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
using Framework.GUI.Controls.Conversations;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Add link form.
    /// </summary>
    public partial class AddLinkForm : Form
    {
        #region Members

        /// <summary>
        /// Conversations data manager.
        /// </summary>
        private DataManager _dataManager;

        /// <summary>
        /// Link type.
        /// </summary>
        private ReplyField _linkType;

        /// <summary>
        /// ID to link.
        /// </summary>
        private Guid _link;

        /// <summary>
        /// Node list control.
        /// </summary>
        private NodeListControl _nodeList;

        /// <summary>
        /// IDs to exclude from full list.
        /// </summary>
        private List<Guid> _excludeList;

        /// <summary>
        /// Whether or not this is a new reply.
        /// </summary>
        private bool _newReply;

        /// <summary>
        /// Action type.
        /// </summary>
        private ActionType _actionType;

        #endregion

        #region Properties

        /// <summary>
        /// Get selected node's ID.
        /// </summary>
        public Guid SelectedNode
        {
            get { return _nodeList.SelectedNode; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default AddLinkForm constructor.
        /// </summary>
        /// <param name="linkType">Type of link.</param>
        /// <param name="dataManager">Conversations data manager.</param>
        /// <param name="link">Id to link.</param>
        public AddLinkForm(ReplyField linkType, DataManager dataManager, Guid link)
        {
            _linkType = linkType;
            _dataManager = dataManager;
            _link = link;

            // Link is for New reply
            _newReply = false;
            _actionType = ActionType.Add;

            _nodeList = new NodeListControl(NodeListControlType.Basic, _dataManager);
            _nodeList.RootNode = link;
            _nodeList.OnSelectedItemChanged += new NodeListControl.SelectedItemChanged(NodeList_OnSelectedItemChanged);
            _nodeList.OnOpenedItemChanged += new NodeListControl.OpenedItemChanged(NodeList_OnOpenedItemChanged);

            // Initialize GUI
            InitializeComponent();

            // Validate link type
            ValidateLinkType(linkType);

            // Initialize host
            host.Controls.Add(_nodeList);
            _nodeList.UpdateContent();
        }

        /// <summary>
        /// AddLinkForm constructor by providing exclude list.
        /// </summary>
        /// <param name="linkType">Type of link</param>
        /// <param name="dataManager">Conversations data manager.</param>
        /// <param name="excludeList">List of IDs to be excluded from full list.</param>
        public AddLinkForm(ReplyField linkType, DataManager dataManager, List<Guid> excludeList)
        {
            _linkType = linkType;
            _dataManager = dataManager;
            _excludeList = excludeList;

            // Link is for New reply
            _newReply = true;
            _actionType = ActionType.Add;

            _nodeList = new NodeListControl(NodeListControlType.Basic, _dataManager);
            _nodeList.Exceptions = excludeList;
            _nodeList.OnSelectedItemChanged += new NodeListControl.SelectedItemChanged(NodeList_OnSelectedItemChanged);
            _nodeList.OnOpenedItemChanged += new NodeListControl.OpenedItemChanged(NodeList_OnOpenedItemChanged);

            // Validate link type
            ValidateLinkType(linkType);

            // Initialize GUI
            InitializeComponent();

            // Initialize host
            host.Controls.Add(_nodeList);
            _nodeList.UpdateContent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Node list on selected item changed event handler.
        /// </summary>
        /// <param name="sender">Node list control.</param>
        /// <param name="valid">Whether or not selected item is valid.</param>
        /// <param name="id">Selected item's ID.</param>
        private void NodeList_OnSelectedItemChanged(NodeListControl sender, bool valid, Guid id)
        {
            okButton.Enabled = valid;
        }

        /// <summary>
        /// Node list on opened item changed event handler.
        /// </summary>
        /// <param name="sender">Node list control.</param>
        /// <param name="valid">Whether or not opened item is valid.</param>
        /// <param name="id">Opened item's ID.</param>
        private void NodeList_OnOpenedItemChanged(NodeListControl sender, bool valid, Guid id)
        {
            if (valid)
            {
                switch (_actionType)
                {
                    case ActionType.Add:
                        {
                            okButton.PerformClick();
                            break;
                        }
                    case ActionType.Open:
                        {
                            _nodeList.ViewNode(valid, id);
                            break;
                        }
                    default:
                        {
                            throw new InvalidFieldException();
                        }
                }
            }
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
        /// OK button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (_newReply == false)
            {
                UpdateDatabase();
            }

            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Validate link type.
        /// </summary>
        /// <param name="linkType">Link type.</param>
        /// <exception cref="InvalidFieldException">Link type is invalid.</exception>
        private void ValidateLinkType(ReplyField linkType)
        {
            bool valid = (linkType == ReplyField.Child || linkType == ReplyField.Parent);

            if (valid == false)
            {
                throw new InvalidFieldException();
            }

            Text = GetTextValue(linkType);
        }

        /// <summary>
        /// Get text value according to reply field.
        /// </summary>
        /// <param name="type">Reply field type.</param>
        /// <exception cref="InvalidFieldException">Reply field type is invalid.</exception>
        /// <returns>Text according to reply field type.</returns>
        private string GetTextValue(ReplyField type)
        {
            switch (type)
            {
                case ReplyField.Child:
                    {
                        return "Add child";
                    }
                case ReplyField.Parent:
                    {
                        return "Add parent";
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Update database.
        /// </summary>
        private void UpdateDatabase()
        {
            _dataManager.AddLink(_link, _linkType, _nodeList.SelectedNode);
        }

        #endregion
    }
}
