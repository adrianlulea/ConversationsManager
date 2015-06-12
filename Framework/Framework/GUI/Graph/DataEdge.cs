using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX;
using GraphX.PCL.Common.Models;

namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public class DataEdge : EdgeBase<DataVertex>
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private Guid _parentId;

      /// <summary>
      /// 
      /// </summary>
      private Guid _childId;

      #endregion

      #region Properties

      /// <summary>
      /// Custom string property for example
      /// </summary>
      public string Text { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public Guid ParentId
      {
         get { return _parentId; }
      }

      /// <summary>
      /// 
      /// </summary>
      public Guid ChildId
      {
         get { return _childId; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Default constructor. We need to set at least Source and Target properties of the edge.
      /// </summary>
      /// <param name="source">Source vertex data</param>
      /// <param name="target">Target vertex data</param>
      /// <param name="weight">Optional edge weight</param>
      public DataEdge(DataVertex source, DataVertex target, double weight = 1)
         : base(source, target, weight)
      {
         _parentId = source.ReplyId;
         _childId = target.ReplyId;
      }
      /// <summary>
      /// Default parameterless constructor (for serialization compatibility)
      /// </summary>
      public DataEdge()
         : base(null, null, 1)
      {
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Text;
      }

      #endregion
   }
}
