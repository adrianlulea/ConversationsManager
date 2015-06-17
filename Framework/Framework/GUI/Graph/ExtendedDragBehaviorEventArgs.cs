using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public class ExtendedDragBehaviorEventArgs : EventArgs
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private Point _startingPoint;

      /// <summary>
      /// 
      /// </summary>
      private Point _endingPoint;

      /// <summary>
      /// 
      /// </summary>
      private bool _endingPointValid;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public Point StartingPoint
      {
         get { return _startingPoint; }
      }

      /// <summary>
      /// 
      /// </summary>
      public Point EndingPoint
      {
         get { return _endingPoint; }
      }

      /// <summary>
      /// 
      /// </summary>
      public bool EndingPointValid
      {
         get { return _endingPointValid; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="start"></param>
      /// <param name="end"></param>
      /// <param name="validEndpoint"></param>
      public ExtendedDragBehaviorEventArgs(Point start, Point end, bool validEndpoint = false)
      {
         _startingPoint = start;
         _endingPoint = end;
         _endingPointValid = validEndpoint;
      }

      #endregion
   }
}
