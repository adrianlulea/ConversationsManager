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
   public class DataVertex : VertexBase
   {
      #region Properties

      /// <summary>
      /// Some string property for example purposes
      /// </summary>
      public string Text { get; set; }

      #endregion

      #region Constructors

      /// <summary>
      /// Default parameterless constructor for this class
      /// (required for YAXLib serialization)
      /// </summary>
      public DataVertex()
         : this("")
      {
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="text"></param>
      public DataVertex(string text = "")
      {
         Text = text;
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

      #endregion

      #endregion
   }
}
