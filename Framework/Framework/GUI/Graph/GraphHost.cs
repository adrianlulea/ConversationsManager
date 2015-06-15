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
      private DataEdge _selectedLink;

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      public GraphHost()
      {
         _selectedNode = null;
         _selectedLink = null;

         this.VertexSelected += GraphHost_VertexSelected;
         this.EdgeSelected += GraphHost_EdgeSelected;
         this.VertexDoubleClick += GraphHost_VertexDoubleClick;
         this.EdgeDoubleClick += GraphHost_EdgeDoubleClick;
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
      }

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

         foreach(DataEdge child in childrenEdges)
         {
            EdgeControl ec = this.EdgesList[child];
            VertexControl vc = ec.Target;

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

         foreach (DataEdge parent in parentEdges)
         {
            EdgeControl ec = this.EdgesList[parent];
            VertexControl vc = ec.Source;

            ExtendedHighlightBehavior.SetHighlightedParentLink(ec, true);
            ExtendedHighlightBehavior.SetHighlightedParent(vc, true);
         }
      }

      #endregion
   }
}
