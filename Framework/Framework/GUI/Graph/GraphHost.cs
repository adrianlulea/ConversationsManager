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

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      public GraphHost()
      {
         this.VertexSelected += GraphHost_VertexSelected;
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
         // Unselect all other nodes
         foreach (VertexControl vc in VertexList.Values)
         {
            HighlightBehaviour.SetHighlighted(vc, false);
         }
         
         // Select current control
         HighlightBehaviour.SetHighlighted(args.VertexControl, true);

         if (OnSelectedNodeChanged != null)
         {
            SelectedNodeArgs e = new SelectedNodeArgs(true, ((DataVertex)args.VertexControl.Vertex).ReplyId);

            OnSelectedNodeChanged.Invoke(this, e);
         }
      }

      #endregion
   }
}
