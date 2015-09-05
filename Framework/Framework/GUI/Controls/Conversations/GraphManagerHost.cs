using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Framework.Data.Conversations;
using Framework.Util;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using GraphX.Controls;
using QuickGraph;
using Framework.GUI.Graph;
using Framework.GUI.Forms.Conversations;
using System.Windows.Threading;

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

      #region Graph

      /// <summary>
      /// Actual canvas
      /// </summary>
      private GraphHost _host;

      /// <summary>
      /// Zoom control
      /// </summary>
      private ZoomControl _zoomControl;

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

         // Initialize OnGotFocusControls
         InitializeOnGotFocusControls();
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

         if (_refreshNodes)
         {
            ClearChildren();
            ClearParents();
            //RefreshGraph();
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void InitializeGraph()
      {
         Dispatcher.CurrentDispatcher.BeginInvoke( new Action(() =>
            {
               InitializeGraphOnSeparateThread();
            }), DispatcherPriority.Background);

         

         /*ThreadStart ts = new ThreadStart(InitializeGraphOnSeparateThread);
         Thread initializeGraphThread = new Thread(ts);

         initializeGraphThread.SetApartmentState(ApartmentState.STA);
         initializeGraphThread.Start();
         initializeGraphThread.Join();*/

         //graphInitializeBackgroundWorker.RunWorkerAsync();
      }

      private void RefreshGraph()
      {
         //TODO
         //Updates la graf
         _host.GenerateGraph();
         _host.RelayoutGraph();
      }

      private void ClearSelectedNodePanelData()
      {
         // Parent details
         selectedNodeParentAuthorTextBox.Text = "";
         selectedNodeParentTextTextBox.Text = "";

         selectedNodeParentAuthorTextBox.Enabled = false;
         selectedNodeParentTextTextBox.Enabled = false;

         saveChangesSelectedNodeParentButton.Enabled = false;
      }

      private void PopulateSelectedNodePanelData(Guid id, InternalReplyData data)
      {
         string author = data.Author;
         string text = data.Text;

         selectedNodeParentAuthorTextBox.Enabled = true;
         selectedNodeParentTextTextBox.Enabled = true;

         saveChangesSelectedNodeChildButton.Enabled = false;

         // Node details
         selectedNodeParentAuthorTextBox.Text = author;
         selectedNodeParentTextTextBox.Text = text;

         // Parents
         parentsNodeList.RootNode = id;
         parentsNodeList.UpdateContent();

         // Children
         childrenNodesList.RootNode = id;
         childrenNodesList.UpdateContent();
      }

      private void ClearChildNodePanelData()
      {
         // Child details
         selectedNodeChildAuthorTextBox.Text = "";
         selectedNodeChildTextTextBox.Text = "";

         selectedNodeChildAuthorTextBox.Enabled = false;
         selectedNodeChildTextTextBox.Enabled = false;

         saveChangesSelectedNodeChildButton.Enabled = false;
      }

      private void PopulateSelectedChildPanelData(InternalReplyData data)
      {
         selectedNodeChildAuthorTextBox.Enabled = true;
         selectedNodeChildTextTextBox.Enabled = true;

         saveChangesSelectedNodeChildButton.Enabled = false;

         // Child details
         selectedNodeChildAuthorTextBox.Text = data.Author;
         selectedNodeChildTextTextBox.Text = data.Text;
      }

      private Graph.Graph GenerateGraph()
      {
         var dataGraph = new Graph.Graph();

         // Add all replies (also keep a hash [replyId, vertex]
         Dictionary<Guid, DataVertex> nodeHash = new Dictionary<Guid, DataVertex>();

         //int i = 3;

         foreach (InternalReply internalReply in _dataManager.Replies)
         {
            Guid replyId = internalReply.Id;
            var dataNode = new DataVertex(replyId, "");

            nodeHash.Add(replyId, dataNode);

            dataGraph.AddVertex(dataNode);

            //if (i-- == 0) break;

         }

         //i = 3;

         // Populate edges
         foreach (InternalReply internalReply in _dataManager.Replies)
         {
            Guid replyId = internalReply.Id;
            var replyNode = nodeHash[replyId];

            foreach (Guid parent in internalReply.Parents)
            {
               var parentNode = nodeHash[parent];
               var dataEdge = new DataEdge(parentNode, replyNode)
               {
                  Text = string.Format("{0} -> {1}", parentNode, replyNode)
               };

               dataGraph.AddEdge(dataEdge);
            }

            //if (i-- == 0) break;
         }


         // 5 noduri



         /*var dataNode1 = new DataVertex("", Guid.Empty);
         var dataNode2 = new DataVertex("", Guid.Empty);
         var dataNode3 = new DataVertex("", Guid.Empty);
         var dataNode4 = new DataVertex("", Guid.Empty);
         var dataNode5 = new DataVertex("", Guid.Empty);

         dataGraph.AddVertex(dataNode1);
         dataGraph.AddVertex(dataNode2);
         dataGraph.AddVertex(dataNode3);
         dataGraph.AddVertex(dataNode4);
         dataGraph.AddVertex(dataNode5);

         var nodesList = dataGraph.Vertices.ToList();

         // 3 muchii
         var dataEdge1 = new DataEdge(nodesList[0], nodesList[1]) { Text = string.Format("{0} -> {1}", nodesList[0], nodesList[1]) };
         var dataEdge2 = new DataEdge(nodesList[1], nodesList[2]) { Text = string.Format("{0} -> {1}", nodesList[1], nodesList[2]) };
         var dataEdge3 = new DataEdge(nodesList[1], nodesList[3]) { Text = string.Format("{0} -> {1}", nodesList[1], nodesList[3]) };

         dataGraph.AddEdge(dataEdge1);
         dataGraph.AddEdge(dataEdge2);
         dataGraph.AddEdge(dataEdge3);*/

         return dataGraph;
      }

      private UIElement GenerateWPFHost()
      {
         _zoomControl = new ZoomControl();
         _zoomControl.MouseUp += _zoomControl_MouseUp;

         ZoomControl.SetViewFinderVisibility(_zoomControl, Visibility.Visible);

         var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
         _host = new GraphHost()
         {
            EnableWinFormsHostingMode = true,
            LogicCore = logic
         };

         _host.OnSelectedNodeChanged += _host_OnSelectedNodeChanged;
         _host.OnSelectedLinkChanged += _host_OnSelectedLinkChanged;
         _host.OnNodeDoubleClicked += _host_OnNodeDoubleClicked;
         _host.OnEdgeDoubleClicked += _host_OnEdgeDoubleClicked;
         _host.OnNodeHovered += _host_OnNodeHovered;
         _host.OnPendingNewLink += _host_OnPendingNewLink;
         _host.OnDragStarted += _host_OnDragStarted;
         _host.OnDragFinished += _host_OnDragFinished;

         logic.Graph = GenerateGraph();
         logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.EfficientSugiyama;
         logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.EfficientSugiyama);

         logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
         logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);

         ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 50;
         ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 50;

         logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
         logic.AsyncAlgorithmCompute = false;

         _zoomControl.Content = _host;

         _host.RelayoutFinished += _host_RelayoutFinished;

         var myResourceDictionary = new ResourceDictionary { Source = new Uri("/Framework;component/Resources/template.xaml", UriKind.RelativeOrAbsolute) };
         _zoomControl.Resources.MergedDictionaries.Add(myResourceDictionary);

         return _zoomControl;
      }

      /// <summary>
      /// 
      /// </summary>
      public void RemoveSelectedNode()
      {
         _host.RemoveSelectedNode();

         RefreshGraph();
      }

      /// <summary>
      /// 
      /// </summary>
      public void RemoveSelectedLink()
      {
         // Clear selected data
         ClearSelectedNodePanelData();
         ClearChildNodePanelData();

         _host.RemoveSelectedLink();

         RefreshGraph();
      }

      /// <summary>
      /// 
      /// </summary>
      public void BeginLinkCreation()
      {
         selectedNodeOrLinkSplitContainer.Panel2Collapsed = false;
         selectedLinkSplitContainer.Panel2Collapsed = false;

         _host.BeginLinkCreation();
      }

      /// <summary>
      /// 
      /// </summary>
      public void CancelLinkCreation()
      {
         selectedLinkSplitContainer.Panel2Collapsed = false;
         ClearChildNodePanelData();

         _host.CancelLinkCreation();
      }

      /// <summary>
      /// 
      /// </summary>
      public void FinalizeLinkCreation()
      {
         // Determine link type

      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="node1Data"></param>
      /// <param name="node1Id"></param>
      /// <param name="node2Data"></param>
      /// <param name="node2Id"></param>
      /// <returns></returns>
      private bool ConfirmNewLink(InternalReplyData node1Data, Guid node1Id, InternalReplyData node2Data, Guid node2Id)
      {
         InternalReplyData parent = null;
         InternalReplyData child = null;
         Guid parentId, childId;
         ReplyField linkType = ReplyField.Child;

         if (node1Data.Timestamp > node2Data.Timestamp)
         {
            parent = node2Data;
            child = node1Data;

            parentId = node2Id;
            childId = node1Id;

            linkType = ReplyField.Parent; // node2 is node1's parent
         }
         else
         {
            parent = node1Data;
            child = node2Data;

            parentId = node1Id;
            childId = node2Id;

            linkType = ReplyField.Child;
         }

         ConfirmNewLinkForm confirmNewLink = new ConfirmNewLinkForm(parent, child);

         if (confirmNewLink.ShowDialog() == DialogResult.OK)
         {
            _host.FinalizeLinkCreation(linkType);

            SelectedLinkArgs e = new SelectedLinkArgs(true, parentId, childId);

            _dataManager.AddLink(parentId, ReplyField.Child, childId);

            if (OnLinkFinalized != null)
            {
               OnLinkFinalized.Invoke(this, e);
            }

            return true;
         }
         else
         {
            return false;
         }
      }

      private void InitializeOnGotFocusControls()
      {
         this.childrenNodesList.GotFocus += childControl_GotFocus;
         this.graphLinksSplitContainer.GotFocus += childControl_GotFocus;
         this.parentsChildrenSplitContainer.GotFocus += childControl_GotFocus;
         this.parentsNodeList.GotFocus += childControl_GotFocus;
         this.selectedLinkSplitContainer.GotFocus += childControl_GotFocus;
         this.selectedNodeChildAuthorTextBox.GotFocus += childControl_GotFocus;
         this.selectedNodeChildTextTextBox.GotFocus += childControl_GotFocus;
         this.selectedNodeChildToolStrip.GotFocus += childControl_GotFocus;
         this.selectedNodeOrLinkSplitContainer.GotFocus += childControl_GotFocus;
         this.selectedNodeParentAuthorTextBox.GotFocus += childControl_GotFocus;
         this.selectedNodeParentTextTextBox.GotFocus += childControl_GotFocus;
         this.selectedNodeParentToolStrip.GotFocus += childControl_GotFocus;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="id"></param>
      public void SelectNodeInGraphView(Guid id)
      {
         _host.SelectNode(id);
      }

      #endregion

      #region Events

      #region OnGotFocus

      private void _host_OnHostGotFocus(object sender, EventArgs args)
      {
         OnGotFocus(new EventArgs());
      }

      private void childControlUI_GotFocus(object sender, RoutedEventArgs e)
      {
         OnGotFocus(new EventArgs());
      }

      void childControl_GotFocus(object sender, EventArgs e)
      {
         OnGotFocus(new EventArgs());
      }

      #endregion

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

      #region Graph

      #region OnGraphNodeSelected

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void GraphNodeSelected(object sender, SelectedNodeArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event GraphNodeSelected OnGraphNodeSelected;

      #endregion

      #region OnGraphLinkSelected

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void GraphLinkSelected(object sender, SelectedLinkArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event GraphLinkSelected OnGraphLinkSelected;

      #endregion

      #region OnGraphInitialized

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public delegate void GraphInitialized(object sender, EventArgs e);

      /// <summary>
      /// 
      /// </summary>
      public event GraphInitialized OnGraphInitialized;

      /// <summary>
      /// 
      /// </summary>
      private void InitializeGraphOnSeparateThread()
      {
         graphHost.Child = GenerateWPFHost();
         //_zoomControl.ZoomToFill();
         _host.GenerateGraph(true);
         _host.SetVerticesDrag(false);
         _zoomControl.ZoomToFill();

         this._host.OnHostGotFocus += _host_OnHostGotFocus;
         this._zoomControl.GotFocus += childControlUI_GotFocus;

         if (OnGraphInitialized != null)
         {
            EventArgs args = new EventArgs();

            OnGraphInitialized.Invoke(this, args);
         }
      }

      #endregion

      #region OnNodeHovered

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnNodeHovered(object sender, SelectedNodeArgs args)
      {
         if (args.Valid)
         {
            InternalReplyData childData = _dataManager.GetReplyData(args.Id);

            PopulateSelectedChildPanelData(childData);
         }
         else
         {
            ClearChildNodePanelData();
         }
      }

      #endregion

      #region OnPendingLink

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnPendingNewLink(object sender, SelectedLinkArgs args)
      {
         /*InternalReplyData parent = null;
         InternalReplyData child = null;
         Guid parentId, childId;
         ReplyField linkType = ReplyField.Child;*/

         InternalReplyData node1 = _dataManager.GetReplyData(args.ParentId);
         InternalReplyData node2 = _dataManager.GetReplyData(args.ChildId);

         ConfirmNewLink(node1, args.ParentId, node2, args.ChildId);

         /*
         if (node1.Timestamp > node2.Timestamp)
         {
            parent = node2;
            child = node1;

            parentId = args.ChildId;
            childId = args.ParentId;

            linkType = ReplyField.Parent; // node2 (childId) este parintele lui node1 (parentId)
         }
         else
         {
            parent = node1;
            child = node2;

            parentId = args.ParentId;
            childId = args.ChildId;

            linkType = ReplyField.Child; // node2 (childId) este copilul lui node1 (parentId)
         }

         ConfirmNewLinkForm confirmNewLink = new ConfirmNewLinkForm(parent, child);

         if (confirmNewLink.ShowDialog() == DialogResult.OK)
         {
            _host.FinalizeLinkCreation(linkType);

            SelectedLinkArgs e = new SelectedLinkArgs(true, parentId, childId);

            _dataManager.AddLink(parentId, ReplyField.Child, childId);

            if (OnLinkFinalized != null)
            {
               OnLinkFinalized.Invoke(this, e);
            }
         }*/
      }

      #endregion

      #region OnLinkFinalized

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void LinkFinalized(object sender, SelectedLinkArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event LinkFinalized OnLinkFinalized;

      #endregion

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

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void hideNodeParentMainButton_Click(object sender, EventArgs e)
      {
         selectedNodeOrLinkSplitContainer.Panel2Collapsed = true;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void hideNodeChildOrHoveredButton_Click(object sender, EventArgs e)
      {
         selectedLinkSplitContainer.Panel2Collapsed = true;
         showChildParentDetailsButton.Visible = true;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void showChildParentDetailsButton_Click(object sender, EventArgs e)
      {
         selectedLinkSplitContainer.Panel2Collapsed = false;
         showChildParentDetailsButton.Visible = false;
      }

      #region Graph

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      void _host_RelayoutFinished(object sender, EventArgs e)
      {
         _zoomControl.ZoomToFill();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnSelectedNodeChanged(object sender, SelectedNodeArgs args)
      {
         selectedNodeOrLinkSplitContainer.Panel2Collapsed = false;
         InternalReplyData replyData = _dataManager.GetReplyData(args.Id);

         PopulateSelectedNodePanelData(args.Id, replyData);

         ClearChildNodePanelData();

         if (OnGraphNodeSelected != null)
         {
            OnGraphNodeSelected.Invoke(sender, args);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnSelectedLinkChanged(object sender, SelectedLinkArgs args)
      {
         InternalReplyData parentData = _dataManager.GetReplyData(args.ParentId);
         InternalReplyData childData = _dataManager.GetReplyData(args.ChildId);

         PopulateSelectedNodePanelData(args.ParentId, parentData);
         PopulateSelectedChildPanelData(childData);

         if (OnGraphLinkSelected != null)
         {
            OnGraphLinkSelected.Invoke(sender, args);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnNodeDoubleClicked(object sender, SelectedNodeArgs args)
      {
         // Select node
         // Node already selected as onSelectedNodeChanged has been triggered
         /*InternalReplyData replyData = _dataManager.GetReplyData(args.Id);

         PopulateSelectedNodePanelData(args.Id, replyData);

         ClearChildNodePanelData();*/

         selectedNodeOrLinkSplitContainer.Panel2Collapsed = !selectedNodeOrLinkSplitContainer.Panel2Collapsed;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnEdgeDoubleClicked(object sender, SelectedLinkArgs args)
      {
         // Select edge
         // Edge already selected as onSelectedLinkChanged has been triggered
         /*InternalReplyData parentData = _dataManager.GetReplyData(args.ParentId);
         InternalReplyData childData = _dataManager.GetReplyData(args.ChildId);

         PopulateSelectedNodePanelData(args.ParentId, parentData);
         PopulateSelectedChildPanelData(childData);*/

         selectedLinkSplitContainer.Panel2Collapsed = !selectedLinkSplitContainer.Panel2Collapsed;
      }

      #region Drag

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnDragStarted(object sender, CreateLinkDragEventArgs args)
      {
         _host.BeginLinkCreation(args.StartingNode);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void _zoomControl_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
      {
         _host.CancelLinkCreation();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void _host_OnDragFinished(object sender, CreateLinkDragEventArgs args)
      {
         InternalReplyData startData = _dataManager.GetReplyData(args.StartingNode.ReplyId);
         InternalReplyData endData = _dataManager.GetReplyData(args.EndingNode.ReplyId);

         _host.LinkSourceVertex = args.StartingNode;
         _host.LinkTargetVertex = args.EndingNode;

         if (ConfirmNewLink(startData, args.StartingNode.ReplyId, endData, args.EndingNode.ReplyId) == false)
         {
            CancelLinkCreation();
         }
         else
         {
            RefreshGraph();
         }

         /*
         ReplyField linkType = ReplyField.Child;

         if (startData.Timestamp > endData.Timestamp)
         {
            linkType = ReplyField.Parent;
         }

         _host.FinalizeLinkCreation(linkType);
         */
      }

      #endregion

      #endregion

      #endregion
   }
}
