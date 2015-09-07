using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX;
using GraphX.PCL.Common.Models;
using System.Drawing;

namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public class DataVertex : VertexBase
   {

      #region Members

      /// <summary>
      /// 
      /// </summary>
      private Guid _replyId;

      #endregion
      
      #region Properties

      /// <summary>
      /// Some string property for example purposes
      /// </summary>
      public string Text { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public Guid ReplyId
      {
         get { return _replyId; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Default parameterless constructor for this class
      /// (required for YAXLib serialization)
      /// </summary>
      public DataVertex()
         : this(Guid.Empty, "")
      {
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="text"></param>
      /// <param name="id"></param>
      public DataVertex(Guid id, string text = "")
      {
         Text = text;
         _replyId = id;
      }

      #endregion

      #region Methods

      #region Calculated or static props

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return Text;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public override bool Equals(object obj)
      {
         return this._replyId.Equals(((DataVertex)obj).ReplyId);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public override int GetHashCode()
      {
         return this._replyId.GetHashCode();
      }

      #endregion

      #endregion
   }
}
