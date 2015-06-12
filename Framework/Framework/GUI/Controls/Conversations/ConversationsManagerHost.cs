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

namespace Framework.GUI.Controls.Conversations
{
    /// <summary>
    /// ConversationsManagerHost control class.
    /// </summary>
    public partial class ConversationsManagerHost : UserControl
    {
        #region Members

        /// <summary>
        /// Flag whether or not parents should be viewed.
        /// </summary>
        private bool _viewParents;

        /// <summary>
        /// Flag whether or not children should be viewed.
        /// </summary>
        private bool _viewChildren;

        /// <summary>
        /// Flag whether or not graph view is activated.
        /// </summary>
        private bool _graphView;

        /// <summary>
        /// Conversation Data manager.
        /// </summary>
        private DataManager _dataManager;

        /// <summary>
        /// Flag whether or not nodes should be refreshed.
        /// </summary>
        private bool _refreshNodes;

        #region Node lists

        /// <summary>
        /// Normal view node list.
        /// </summary>
        private NodeListControl normalViewNodeList;

        /// <summary>
        /// Graph view node list.
        /// </summary>
        private NodeListControl graphViewNodeList;

        /// <summary>
        /// Normal view parent list for current node.
        /// </summary>
        private NodeListControl parentsNodeList;

        /// <summary>
        /// Normal view children list for current node.
        /// </summary>
        private NodeListControl childrenNodesList;

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Get simple view flag (just nodes, not in graph mode).
        /// </summary>
        public bool SimpleView
        {
            get { return (_viewChildren || _viewParents/* || _graphView*/) ? false : true; }
        }

        /// <summary>
        /// Get or set Parents view flag.
        /// </summary>
        public bool Parents
        {
            get { return _viewParents; }
            set
            {
                _viewParents = value;
                ToggleParents();
            }
        }

        /// <summary>
        /// Get or set Children view flag.
        /// </summary>
        public bool Children
        {
            get { return _viewChildren; }
            set
            {
                _viewChildren = value;
                ToggleChildren();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default ConversationsManagerHost control constructor.
        /// </summary>
        /// <param name="dataManager">Conversations Data Manager.</param>
        /// <param name="graph">Graph flag value.</param>
        /// <param name="parents">Parents flag value.</param>
        /// <param name="children">Children flag value.</param>
        public ConversationsManagerHost(DataManager dataManager, bool graph, bool parents, bool children)
        {
            // Set data
            _graphView = graph;
            _dataManager = dataManager;

            // Default Dock = DockStyle.Fill
            Dock = DockStyle.Fill;

            // Initialize GUI (except lists)
            InitializeComponent();

            Parents = parents;
            Children = children;

            // Initialize lists
            InitializeLists();
        }

        #endregion

        #region Events

        #region Own Created Events

        #region OnSelectedItemChanged

        /// <summary>
        /// SelectedItemChanged delegate.
        /// </summary>
        /// <param name="sender">Node list control who's item has been selected.</param>
        /// <param name="e"></param>
        /*/// <param name="valid">Whether or not the selection is valid.</param>
        /// <param name="id">Selected id.</param>*/
        public delegate void SelectedItemChanged(object sender, SelectedNodeArgs e);

        /// <summary>
        /// OnSelectedItemChanged event.
        /// </summary>
        public event SelectedItemChanged OnSelectedItemChanged;

        #endregion

        #region OnNodeDataChanged

        /// <summary>
        /// NodeDataChanged delegate.
        /// </summary>
        /// <param name="sender">Node List control who's data has changed.</param>
        /// <param name="e"></param>
        public delegate void NodeDataChanged(object sender, SelectedNodeArgs e);

        #endregion

        #endregion

        /// <summary>
        /// Selected item changed event handler
        /// </summary>
        /// <param name="sender">Node list control who's selection has changed.</param>
        /// <param name="e"></param>
        /*/// <param name="valid">Whether or not the selection is valid.</param>
        /// <param name="id">Selected item's ID.</param>*/
        private void NodeList_SelectedItemChanged(object sender, SelectedNodeArgs e)
        {
            if (OnSelectedItemChanged != null)
            {
               //SelectedNodeArgs e = new SelectedNodeArgs(valid, id);
               OnSelectedItemChanged.Invoke(sender, e);
            }
        }

        /// <summary>
        /// NodeDataChanged event handler.
        /// </summary>
        /// <param name="sender">Node list control</param>
        /// <param name="e"></param>
        private void NodeList_NodeDataChanged(object sender, SelectedNodeArgs e)
        {
            RefreshField(normalViewNodeList, e.Id);
            //RefreshField(sender, id);
            
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set OnSelectedItemChanged event handler for given Node list control.
        /// </summary>
        /// <param name="control">Node list control to set the event handler to.</param>
        /// <param name="method">Event handler to set to node list control.</param>
        private void SetOnSelectedItemChangedEvent(NodeListControl control, SelectedItemChanged method)
        {
            control.OnSelectedItemChanged +=new NodeListControl.SelectedItemChanged(method);
        }

        /// <summary>
        /// Set OnNodeDataChanged event handler for given Node list control.
        /// </summary>
        /// <param name="control">Node list control to set the event handler to.</param>
        /// <param name="method">Event handler to set to node list control.</param>
        private void SetOnNodeDataChangedEvent(NodeListControl control, NodeDataChanged method)
        {
            control.OnNodeDataChanged += new NodeListControl.NodeDataChanged(method);
        }

        /// <summary>
        /// Initialize node lists.
        /// </summary>
        private void InitializeLists()
        {
            normalViewNodeList = new NodeListControl(NodeListControlType.Basic, _dataManager);
            graphViewNodeList = new NodeListControl(NodeListControlType.Basic, _dataManager);
            childrenNodesList = new NodeListControl(NodeListControlType.Children, _dataManager);
            parentsNodeList = new NodeListControl(NodeListControlType.Parents, _dataManager);

            normalViewNodeList.ViewNodeMode = ViewNodeMode.InCurrentWindow;
            graphViewNodeList.ViewNodeMode = ViewNodeMode.AsANewWindow;
            childrenNodesList.ViewNodeMode = ViewNodeMode.AsANewWindow;
            parentsNodeList.ViewNodeMode = ViewNodeMode.AsANewWindow;

            SetOnSelectedItemChangedEvent(normalViewNodeList, NodeList_SelectedItemChanged);
            SetOnSelectedItemChangedEvent(graphViewNodeList, NodeList_SelectedItemChanged);
            SetOnSelectedItemChangedEvent(childrenNodesList, NodeList_SelectedItemChanged);
            SetOnSelectedItemChangedEvent(parentsNodeList, NodeList_SelectedItemChanged);

            SetOnNodeDataChangedEvent(childrenNodesList, NodeList_NodeDataChanged);
            SetOnNodeDataChangedEvent(parentsNodeList, NodeList_NodeDataChanged);
            SetOnNodeDataChangedEvent(normalViewNodeList, NodeList_NodeDataChanged);

            splitContainer1.Panel1.Controls.Add(normalViewNodeList);
            splitContainer2.Panel1.Controls.Add(graphViewNodeList);
            splitContainer3.Panel2.Controls.Add(childrenNodesList);
            splitContainer3.Panel1.Controls.Add(parentsNodeList);
        }

        /// <summary>
        /// Load graph view.
        /// </summary>
        private void LoadGraphView()
        {
            //TODO Implement graph view
        }

        /// <summary>
        /// Load normal view.
        /// </summary>
        private void LoadNormalView()
        {
           splitContainer1.Panel2Collapsed = SimpleView;
            normalViewNodeList.UpdateContent();

            if (_refreshNodes)
            {
                ClearParents();
                ClearChildren();
                return;
            }
        }

        /// <summary>
        /// Populate children for given node ID.
        /// </summary>
        /// <param name="node">Root node ID.</param>
        public void PopulateChildren(Guid node)
        {
            childrenNodesList.RootNode = node;
            childrenNodesList.UpdateContent();
        }

        /// <summary>
        /// Populate parents for given node id.
        /// </summary>
        /// <param name="node">Root node ID.</param>
        public void PopulateParents(Guid node)
        {
            parentsNodeList.RootNode = node;
            parentsNodeList.UpdateContent();
        }

        /// <summary>
        /// Clear children.
        /// </summary>
        public void ClearChildren()
        {
            childrenNodesList.RootNode = Guid.Empty;
            childrenNodesList.ClearContent();
        }

        /// <summary>
        /// Clear parents
        /// </summary>
        public void ClearParents()
        {
            parentsNodeList.RootNode = Guid.Empty;
            parentsNodeList.ClearContent();
        }

        /// <summary>
        /// Toggle the show parents button and update the host accordingly.
        /// </summary>
        private void ToggleParents()
        {
            if (_graphView)
            {
                //TODO ToggleParents in graph view
            }
            else
            {
                //splitContainer2.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = !(_viewParents || _viewChildren);

                if (_viewParents)
                {
                    if (_viewChildren)
                    {
                        splitContainer3.Panel1Collapsed = false;
                    }
                    else
                    {
                        splitContainer3.Panel2Collapsed = true;
                    }
                }
                else
                {
                    if (_viewChildren)
                    {
                        splitContainer3.Panel1Collapsed = true;
                    }
                    else
                    {
                        splitContainer3.Panel2Collapsed = false;
                    }
                }
            }
        }

        /// <summary>
        /// Toggle the show children button and update the host accordingly.
        /// </summary>
        private void ToggleChildren()
        {
            if (_graphView)
            {
                //TODO ToggleChildren in graph view
            }
            else
            {
                //splitContainer2.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = !(_viewParents || _viewChildren);

                if (_viewChildren)
                {
                    if (_viewParents)
                    {
                        splitContainer3.Panel2Collapsed = false;
                    }
                    else
                    {
                        splitContainer3.Panel1Collapsed = true;
                    }
                }
                else
                {
                    if (_viewParents)
                    {
                        splitContainer3.Panel2Collapsed = true;
                    }
                    else
                    {
                        splitContainer3.Panel1Collapsed = false;
                    }
                }
            }
        }

        /// <summary>
        /// Update content.
        /// </summary>
        /// <param name="deleted">Was anything deleted.</param>
        public void UpdateContent(bool deleted)
        {
            _refreshNodes = deleted;

            if (_graphView)
            {
                LoadGraphView();
            }
            else
            {
                LoadNormalView();
            }
        }

        /// <summary>
        /// Update content for given reply field.
        /// </summary>
        /// <param name="deletedField">Reply field to update.</param>
        /// <exception cref="InvalidFieldException">ReplyField is invalid.</exception>
        public void UpdateContent(ReplyField deletedField)
        {
            Guid selectedNode = normalViewNodeList.SelectedNode;
            normalViewNodeList.UpdateContent();

            switch (deletedField)
            {
                case ReplyField.Child:
                    {
                        childrenNodesList.UpdateContent();
                        break;
                    }
                case ReplyField.Parent:
                    {
                        parentsNodeList.UpdateContent();
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            normalViewNodeList.SelectedNode = selectedNode;
        }

        /// <summary>
        /// Refresh field in list.
        /// </summary>
        /// <param name="list">List where the field should be refreshed.</param>
        /// <param name="id">Field's ID.</param>
        private void RefreshField(NodeListControl list, Guid id)
        {
            list.RefreshField(id);
        }

        /// <summary>
        /// Set context menu for given node list control.
        /// </summary>
        /// <param name="type">Node list control type.</param>
        /// <param name="menu">Context menu to set.</param>
        /// <exception cref="InvalidFieldException">Node list control type is invalid.</exception>
        public void SetContextMenu(NodeListControlType type, ContextMenuStrip menu)
        {
            switch (type)
            {
                case NodeListControlType.Basic:
                    {
                        normalViewNodeList.ContextMenuStrip = menu;
                        graphViewNodeList.ContextMenuStrip = menu;
                        break;
                    }
                case NodeListControlType.Children:
                    {
                        childrenNodesList.ContextMenuStrip = menu;
                        break;
                    }
                case NodeListControlType.Parents:
                    {
                        parentsNodeList.ContextMenuStrip = menu;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
        public void SelectNodeInNormalView(Guid id)
        {
           normalViewNodeList.SelectNode(id);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
        public void SelectNodeInGraphView(Guid id)
        {
 
        }

        #endregion
    }
}
