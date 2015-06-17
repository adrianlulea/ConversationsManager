using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public class CreateLinkDragEventArgs : EventArgs
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private DataVertex _startingNode;

      /// <summary>
      /// 
      /// </summary>
      private DataVertex _endingNode;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public DataVertex StartingNode
      {
         get { return _startingNode; }
      }

      /// <summary>
      /// 
      /// </summary>
      public DataVertex EndingNode
      {
         get { return _endingNode; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="startNode"></param>
      /// <param name="endNode"></param>
      public CreateLinkDragEventArgs(DataVertex startNode, DataVertex endNode)
      {
         _startingNode = startNode;
         _endingNode = endNode;
      }

      #endregion
   }
}
