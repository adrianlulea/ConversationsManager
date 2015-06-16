using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX;
using QuickGraph;
using GraphX.Controls;
using Framework.Util;


namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public class GraphHost : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private DataVertex _selectedNode;

      /// <summary>
      /// 
      /// </summary>
      private List<DataVertex> _selectedNodesParents;

      /// <summary>
      /// 
      /// </summary>
      private List<DataVertex> _selectedNodesChildren;

      /// <summary>
      /// 
      /// </summary>
      private DataEdge _selectedLink;

      /// <summary>
      /// 
      /// </summary>
      private DataVertex _linkSourceVertex;

      /// <summary>
      /// 
      /// </summary>
      private DataVertex _linkTargetVertex;

      /// <summary>
      /// 
      /// </summary>
      private LinkCreateState _linkCreationState;

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      public GraphHost()
      {
         _selectedNode = null;
         _selectedNodesParents = new List<DataVertex>();
         _selectedNodesChildren = new List<DataVertex>();
         _selectedLink = null;

         _linkSourceVertex = null;
         _linkTargetVertex = null;
         _linkCreationState = LinkCreateState.None;

         this.VertexSelected += GraphHost_VertexSelected;
         this.EdgeSelected += GraphHost_EdgeSelected;
         this.VertexDoubleClick += GraphHost_VertexDoubleClick;
         this.EdgeDoubleClick += GraphHost_EdgeDoubleClick;

         this.VertexMouseEnter += GraphHost_VertexMouseEnter;
         this.VertexMouseLeave += GraphHost_VertexMouseLeave;
      }

      #endregion

      #region Event Handlers

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void SelectedNodeChanged(object sender, SelectedNodeArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event SelectedNodeChanged OnSelectedNodeChanged;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void GraphHost_VertexSelected(object sender, GraphX.Controls.Models.VertexSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {
                  UnselectAllNodes();
                  UnselectAllLinks();

                  // Select current control
                  HighlightBehaviour.SetHighlighted(args.VertexControl, true);

                  HighlightChildren(args.VertexControl.Vertex as DataVertex);
                  HighlightParents(args.VertexControl.Vertex as DataVertex);

                  this._selectedNode = (DataVertex)args.VertexControl.Vertex;

                  if (OnSelectedNodeChanged != null)
                  {
                     SelectedNodeArgs e = new SelectedNodeArgs(true, ((DataVertex)args.VertexControl.Vertex).ReplyId);

                     OnSelectedNodeChanged.Invoke(this, e);
                  }

                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {
                  VertexControl vc = args.VertexControl;
                  DataVertex dv = vc.Vertex as DataVertex;

                  bool valid = ExtendedHighlightBehavior.GetAvailableNodeForLink(vc);
                  Guid source = _selectedNode.ReplyId;
                  Guid target = dv.ReplyId;

                  SelectedLinkArgs e = new SelectedLinkArgs(valid, source, target);

                  if (valid)
                  {
                     _linkTargetVertex = dv;

                     if (OnPendingNewLink != null)
                     {
                        OnPendingNewLink.Invoke(this, e);
                     }
                  }

                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void SelectedLinkChanged(object sender, SelectedLinkArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event SelectedLinkChanged OnSelectedLinkChanged;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      void GraphHost_EdgeSelected(object sender, GraphX.Controls.Models.EdgeSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {
                  UnselectAllNodes();
                  UnselectAllLinks();

                  // Select current control
                  DataEdge de = (DataEdge)args.EdgeControl.Edge;
                  HighlightBehaviour.SetHighlighted(args.EdgeControl, true);

                  // Select parent node (differently)
                  ExtendedHighlightBehavior.SetHighlightedParent(args.EdgeControl.Source, true);
                  //HighlightBehaviour.SetHighlighted(args.EdgeControl.Source, true);
                  ExtendedHighlightBehavior.SetHighlightedChild(args.EdgeControl.Target, true);
                  //HighlightBehaviour.SetHighlighted(args.EdgeControl.Target, true);

                  this._selectedLink = de;

                  if (OnSelectedLinkChanged != null)
                  {
                     SelectedLinkArgs e = new SelectedLinkArgs(true, de.ParentId, de.ChildId);

                     OnSelectedLinkChanged.Invoke(this, e);
                  }
                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {

                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void NodeDoubleClicked(object sender, SelectedNodeArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event NodeDoubleClicked OnNodeDoubleClicked;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void GraphHost_VertexDoubleClick(object sender, GraphX.Controls.Models.VertexSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {
                  // Select current node
                  UnselectAllNodes();
                  UnselectAllLinks();

                  HighlightBehaviour.SetHighlighted(args.VertexControl, true);

                  HighlightChildren(args.VertexControl.Vertex as DataVertex);
                  HighlightParents(args.VertexControl.Vertex as DataVertex);

                  this._selectedNode = (DataVertex)args.VertexControl.Vertex;

                  // Show or hide node information
                  if (OnNodeDoubleClicked != null)
                  {
                     SelectedNodeArgs e = new SelectedNodeArgs(true, ((DataVertex)args.VertexControl.Vertex).ReplyId);

                     OnNodeDoubleClicked.Invoke(this, e);
                  }

                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {

                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void EdgeDoubleClicked(object sender, SelectedLinkArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event EdgeDoubleClicked OnEdgeDoubleClicked;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void GraphHost_EdgeDoubleClick(object sender, GraphX.Controls.Models.EdgeSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {
                  // Select current link
                  UnselectAllNodes();
                  UnselectAllLinks();

                  // Select current control
                  DataEdge de = (DataEdge)args.EdgeControl.Edge;
                  HighlightBehaviour.SetHighlighted(args.EdgeControl, true);

                  // Select parent node (differently)
                  ExtendedHighlightBehavior.SetHighlightedParent(args.EdgeControl.Source, true);
                  ExtendedHighlightBehavior.SetHighlightedChild(args.EdgeControl.Target, true);

                  this._selectedLink = de;

                  // Show or hide node information
                  if (OnEdgeDoubleClicked != null)
                  {
                     SelectedLinkArgs e = new SelectedLinkArgs(true, de.ParentId, de.ChildId);

                     OnEdgeDoubleClicked.Invoke(this, e);
                  }
                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {

                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void NodeHovered(object sender, SelectedNodeArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event NodeHovered OnNodeHovered;
      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void GraphHost_VertexMouseEnter(object sender, GraphX.Controls.Models.VertexSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {

                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {
                  VertexControl vc = args.VertexControl;
                  DataVertex dv = vc.Vertex as DataVertex;

                  if (OnNodeHovered != null)
                  {
                     bool valid = ExtendedHighlightBehavior.GetAvailableNodeForLink(vc);
                     SelectedNodeArgs e = new SelectedNodeArgs(valid, dv.ReplyId);

                     OnNodeHovered.Invoke(this, e);
                  }

                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      private void GraphHost_VertexMouseLeave(object sender, GraphX.Controls.Models.VertexSelectedEventArgs args)
      {
         switch(_linkCreationState)
         {
            case LinkCreateState.None:
               {

                  break;
               }
            case LinkCreateState.SelectedSourceNode:
               {
                  if (OnNodeHovered != null)
                  {
                     bool valid = false;
                     Guid id = Guid.Empty;

                     SelectedNodeArgs e = new SelectedNodeArgs(valid, id);

                     OnNodeHovered.Invoke(this, e);
                  }
                  break;
               }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      public delegate void PendingNewLink(object sender, SelectedLinkArgs args);

      /// <summary>
      /// 
      /// </summary>
      public event PendingNewLink OnPendingNewLink;

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      private void UnselectAllNodes()
      {
         // Unselect all other nodes
         foreach (VertexControl vc in VertexList.Values)
         {
            HighlightBehaviour.SetHighlighted(vc, false);
            ExtendedHighlightBehavior.SetHighlightedChild(vc, false);
            ExtendedHighlightBehavior.SetHighlightedParent(vc, false);
            ExtendedHighlightBehavior.SetAvailableNodeForLink(vc, false);
            ExtendedHighlightBehavior.SetUnavailableNodeForLink(vc, false);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void UnselectAllLinks()
      {
         // Unselect all other links
         foreach (EdgeControl ec in this.EdgesList.Values)
         {
            HighlightBehaviour.SetHighlighted(ec, false);
            ExtendedHighlightBehavior.SetHighlightedChildLink(ec, false);
            ExtendedHighlightBehavior.SetHighlightedParentLink(ec, false);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void RemoveSelectedNode()
      {
         if (_selectedNode != null)
         {
            // Remove its links
            List<DataEdge> children = GetChildEdges(_selectedNode);
            List<DataEdge> parents = GetParentEdges(_selectedNode);

            foreach (DataEdge child in children)
            {
               ExtendedHighlightBehavior.SetHighlightedChild(VertexList[child.Target], false);
               this.RemoveEdge(child);
            }

            foreach (DataEdge parent in parents)
            {
               ExtendedHighlightBehavior.SetHighlightedParent(VertexList[parent.Source], false);
               this.RemoveEdge(parent);
            }

            this.RemoveVertex(_selectedNode);

            //TODO maybe refresh is required?
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void RemoveSelectedLink()
      {
         if (_selectedLink != null)
         {
            VertexControl parent = VertexList[this._selectedLink.Source];
            VertexControl child = VertexList[this._selectedLink.Target];

            // Unhighlight nodes
            ExtendedHighlightBehavior.SetHighlightedParent(parent, false);
            ExtendedHighlightBehavior.SetHighlightedChild(child, false);

            this.RemoveEdge(_selectedLink);

            //TODO maybe refresh is required?
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="node"></param>
      /// <returns></returns>
      private List<DataEdge> GetChildEdges(DataVertex node)
      {
         List<DataEdge> children = new List<DataEdge>();

         foreach (DataEdge possibleChild in EdgesList.Keys)
         {
            if (possibleChild.ParentId == node.ReplyId)
            {
               children.Add(possibleChild);
            }
         }

         return children;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="node"></param>
      /// <returns></returns>
      private List<DataEdge> GetParentEdges(DataVertex node)
      {
         List<DataEdge> parents = new List<DataEdge>();

         foreach (DataEdge possibleParent in EdgesList.Keys)
         {
            if (possibleParent.ChildId == node.ReplyId)
            {
               parents.Add(possibleParent);
            }
         }

         return parents;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="node"></param>
      private void HighlightChildren(DataVertex node)
      {
         List<DataEdge> childrenEdges = GetChildEdges(node);
         _selectedNodesChildren.Clear();

         foreach(DataEdge child in childrenEdges)
         {
            EdgeControl ec = this.EdgesList[child];
            VertexControl vc = ec.Target;

            _selectedNodesChildren.Add(vc.Vertex as DataVertex);

            ExtendedHighlightBehavior.SetHighlightedChildLink(ec, true);
            ExtendedHighlightBehavior.SetHighlightedChild(vc, true);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="node"></param>
      private void HighlightParents(DataVertex node)
      {
         List<DataEdge> parentEdges = GetParentEdges(node);
         _selectedNodesParents.Clear();

         foreach (DataEdge parent in parentEdges)
         {
            EdgeControl ec = this.EdgesList[parent];
            VertexControl vc = ec.Source;

            _selectedNodesParents.Add(vc.Vertex as DataVertex);

            ExtendedHighlightBehavior.SetHighlightedParentLink(ec, true);
            ExtendedHighlightBehavior.SetHighlightedParent(vc, true);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void HighlightAllAvailableForLink(DataVertex exceptNode)
      {
         foreach (VertexControl vc in VertexList.Values)
         {
            if (vc.Vertex.Equals(exceptNode) == false)
            {
               ExtendedHighlightBehavior.SetAvailableNodeForLink(vc, true);
            }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void BeginLinkCreation()
      {
         _linkSourceVertex = _selectedNode;
         _linkTargetVertex = null;
         _linkCreationState = LinkCreateState.SelectedSourceNode;

         UnselectAllNodes();

         // Highlight current node
         HighlightBehaviour.SetHighlighted(VertexList[_selectedNode], true);

         HighlightAllAvailableForLink(_selectedNode);

         // Hhighlight available and unavailable nodes
         List<DataEdge> children = GetChildEdges(_selectedNode);
         List<DataEdge> parents = GetParentEdges(_selectedNode);

         foreach (DataEdge childLink in children)
         {
            var childNode = VertexList[childLink.Target];

            ExtendedHighlightBehavior.SetAvailableNodeForLink(childNode, false);
            ExtendedHighlightBehavior.SetUnavailableNodeForLink(childNode, true);
         }

         foreach (DataEdge parentLink in parents)
         {
            var parentNode = VertexList[parentLink.Source];

            ExtendedHighlightBehavior.SetAvailableNodeForLink(parentNode, false);
            ExtendedHighlightBehavior.SetUnavailableNodeForLink(parentNode, true);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void CancelLinkCreation()
      {
         _linkSourceVertex = null;
         _linkTargetVertex = null;
         _linkCreationState = LinkCreateState.None;

         HighlightSelectedNodeAndItsLinks();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="linkType"></param>
      public void FinalizeLinkCreation(ReplyField linkType)
      {
         _linkCreationState = LinkCreateState.SelectedTargetNode;
         var parentNode = _linkSourceVertex;
         var childNode = _linkTargetVertex;

         switch (linkType)
         {
            case ReplyField.Child:
               {
                  parentNode = _linkSourceVertex;
                  childNode = _linkTargetVertex;
                  _selectedNodesChildren.Add(_linkTargetVertex);

                  break;
               }
            case ReplyField.Parent:
               {
                  parentNode = _linkTargetVertex;
                  childNode = _linkSourceVertex;
                  _selectedNodesParents.Add(_linkTargetVertex);

                  break;
               }
            default:
               {
                  throw new InvalidFieldException();
               }
         }

         var dataEdge = new DataEdge(parentNode, childNode)
         {
            Text = string.Format("{0} -> {1}", parentNode, childNode)
         };

         var edgeControl = new EdgeControl(VertexList[parentNode], VertexList[childNode], dataEdge);

         AddEdge(dataEdge, edgeControl);

         _linkCreationState = LinkCreateState.None;
         _linkSourceVertex = null;
         _linkTargetVertex = null;

         // Highlight new link
         switch(linkType)
         {
            case ReplyField.Child:
               {
                  ExtendedHighlightBehavior.SetHighlightedChildLink(edgeControl, true);
                  break;
               }
            case ReplyField.Parent:
               {
                  ExtendedHighlightBehavior.SetHighlightedParentLink(edgeControl, true);
                  break;
               }
         }

         HighlightSelectedNodeAndItsLinks();
      }

      /// <summary>
      /// 
      /// </summary>
      private void HighlightSelectedNodeAndItsLinks()
      {
         UnselectAllNodes();

         HighlightBehaviour.SetHighlighted(VertexList[_selectedNode], true);

         foreach (DataVertex child in _selectedNodesChildren)
         {
            var childNode = VertexList[child];

            ExtendedHighlightBehavior.SetHighlightedChild(childNode, true);
         }

         foreach (DataVertex parent in _selectedNodesParents)
         {
            var parentNode = VertexList[parent];

            ExtendedHighlightBehavior.SetHighlightedParent(parentNode, true);
         }
      }

      #endregion
   }
}
