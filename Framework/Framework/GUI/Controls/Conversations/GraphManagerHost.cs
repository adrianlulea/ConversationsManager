using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Data.Conversations;
using Framework.Util;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class GraphManagerHost : UserControl
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
      /// Conversation Data manager.
      /// </summary>
      private DataManager _dataManager;

      /// <summary>
      /// Flag whether or not nodes should be refreshed.
      /// </summary>
      private bool _refreshNodes;

      #region Node lists

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

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="dataManager"></param>
      /// <param name="parents"></param>
      /// <param name="children"></param>
      public GraphManagerHost(DataManager dataManager, bool parents, bool children)
      {
         // Set data
         _dataManager = dataManager;

         // Default Dock = Dockstyle.Fill
         Dock = DockStyle.Fill;

         // Initialize GUI (except lists)
         InitializeComponent();

         Parents = parents;
         Children = children;

         // Initialize lists
         InitializeLists();

         // Initialize Graph
         InitializeGraph();
      }

      #endregion

      #region Methods

      /// <summary>
      /// Initialize node lists.
      /// </summary>
      private void InitializeLists()
      {
         childrenNodesList = new NodeListControl(Util.NodeListControlType.Children, _dataManager);
         parentsNodeList = new NodeListControl(Util.NodeListControlType.Parents, _dataManager);

         childrenNodesList.ViewNodeMode = Util.ViewNodeMode.AsANewWindow;
         parentsNodeList.ViewNodeMode = Util.ViewNodeMode.AsANewWindow;

         SetOnSelectedItemChangedEvent(childrenNodesList, NodeList_SelectedItemChanged);
         SetOnSelectedItemChangedEvent(parentsNodeList, NodeList_SelectedItemChanged);

         SetOnNodeDataChangedEvent(childrenNodesList, NodeList_NodeDataChanged);
         SetOnNodeDataChangedEvent(parentsNodeList, NodeList_NodeDataChanged);

         parentsChildrenSplitContainer.Panel1.Controls.Add(parentsNodeList);
         parentsChildrenSplitContainer.Panel2.Controls.Add(childrenNodesList);
      }

      #region Node lists

      /// <summary>
      /// Set OnSelectedItemChanged event handler for given Node list control.
      /// </summary>
      /// <param name="control">Node list control to set the event handler to.</param>
      /// <param name="method">Event handler to set to node list control.</param>
      private void SetOnSelectedItemChangedEvent(NodeListControl control, SelectedItemChanged method)
      {
         control.OnSelectedItemChanged += new NodeListControl.SelectedItemChanged(method);
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
      /// Refresh field in list.
      /// </summary>
      /// <param name="list">List where the field should be refreshed.</param>
      /// <param name="id">Field's ID.</param>
      private void RefreshField(NodeListControl list, Guid id)
      {
         list.RefreshField(id);
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

      #endregion

      /// <summary>
      /// Toggle the show parents button and update the host accordingly.
      /// </summary>
      private void ToggleParents()
      {
         graphLinksSplitContainer.Panel2Collapsed = !(_viewParents || _viewChildren);

         if (_viewParents)
         {
            if (_viewChildren)
            {
               parentsChildrenSplitContainer.Panel1Collapsed = false;
            }
            else
            {
               parentsChildrenSplitContainer.Panel2Collapsed = true;
            }
         }
         else
         {
            if (_viewChildren)
            {
               parentsChildrenSplitContainer.Panel1Collapsed = true;
            }
            else
            {
               parentsChildrenSplitContainer.Panel2Collapsed = false;
            }
         }
      }

      /// <summary>
      /// Toggle the show children button and update the host accordingly.
      /// </summary>
      private void ToggleChildren()
      {
         graphLinksSplitContainer.Panel2Collapsed = !(_viewParents || _viewChildren);

         if (_viewChildren)
         {
            if (_viewParents)
            {
               parentsChildrenSplitContainer.Panel2Collapsed = false;
            }
            else
            {
               parentsChildrenSplitContainer.Panel1Collapsed = true;
            }
         }
         else
         {
            if (_viewParents)
            {
               parentsChildrenSplitContainer.Panel2Collapsed = true;
            }
            else
            {
               parentsChildrenSplitContainer.Panel1Collapsed = false;
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

         RefreshGraph();

         if (_refreshNodes)
         {
            ClearChildren();
            ClearParents();
         }
      }

      private void InitializeGraph()
      {
 
      }

      private void RefreshGraph()
      {
         //TODO
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
         //TODO
         //RefreshField(normalViewNodeList, e.Id);
         //RefreshField(sender, id);
      }

      #endregion
   }
}
