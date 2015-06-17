using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using GraphX.PCL.Common.Exceptions;
using GraphX.Controls;

/*
 * Code ported from GraphX.Controls.DragBehavior
 */
namespace Framework.GUI.Graph
{
   /// <summary>
   /// 
   /// </summary>
   public static class ExtendedDragBehavior
   {
      #region Link creation static members

      /// <summary>
      /// 
      /// </summary>
      private static Point STARTING_DRAG_POSITION = new Point();

      #endregion

      #region Attached properties

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty IsCreateLinkOnDragAndDropProperty = DependencyProperty.RegisterAttached("IsCreateLinkOnDragAndDrop", typeof(bool), typeof(ExtendedDragBehavior), new PropertyMetadata(false, OnIsCreateLinkOnDragAndDropPropertyChanged));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty IsDraggingProperty = DependencyProperty.RegisterAttached("IsDragging", typeof(bool), typeof(ExtendedDragBehavior), new PropertyMetadata(false));

      #endregion

      #region IsCreateLinkOnDragAndDropProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetIsCreateLinkOnDragAndDrop(DependencyObject obj)
      {
         return (bool)obj.GetValue(IsCreateLinkOnDragAndDropProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetIsCreateLinkOnDragAndDrop(DependencyObject obj, bool value)
      {
         obj.SetValue(IsCreateLinkOnDragAndDropProperty, value);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="e"></param>
      private static void OnIsCreateLinkOnDragAndDropPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
      {
         var element = obj as IInputElement;

         if (element == null)
         {
            return;
         }

         if (e.NewValue is bool == false)
         {
            return;
         }

         if ((bool)e.NewValue)
         {
            // Register event handlers
            element.MouseLeftButtonDown += OnDragStarted;
            element.MouseLeftButtonUp += OnDragFinished;
         }
         else
         {
            // Unregister event handlers
            element.MouseLeftButtonDown -= OnDragStarted;
            element.MouseLeftButtonUp -= OnDragFinished;
         }
      }

      #endregion

      #region IsDraggingProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetIsDragging(DependencyObject obj)
      {
         return (bool)obj.GetValue(IsDraggingProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetIsDragging(DependencyObject obj, bool value)
      {
         obj.SetValue(IsDraggingProperty, value);
      }

      #endregion

      #region Dragging

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public static void OnDragStarted(object sender, System.Windows.Input.MouseButtonEventArgs e)
      {
         var obj = sender as DependencyObject;

         // Start dragging
         SetIsDragging(obj, true);

         VertexControl vc = obj as VertexControl;

         Point pos = vc.GetPosition();

         STARTING_DRAG_POSITION = pos;

         if (OnDragBehaviorDragStarted != null)
         {
            ExtendedDragBehaviorEventArgs args = new ExtendedDragBehaviorEventArgs(pos, new Point());
            OnDragBehaviorDragStarted.Invoke(sender, args);
         }

         // Capture the mouse
         var element = obj as IInputElement;

         if (element != null)
         {
            element.CaptureMouse();
            element.MouseMove += OnDragging;
         }

         e.Handled = false;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private static void OnDragging(object sender, System.Windows.Input.MouseEventArgs e)
      {
         var obj = sender as DependencyObject;

         if (GetIsDragging(obj) == false)
         {
            return;
         }

         // Get vertex at position
         VertexControl vc = obj as VertexControl;
         Point position = vc.GetPosition();

         if (OnDragBehaviorDragging != null)
         {
            ExtendedDragBehaviorEventArgs args = new ExtendedDragBehaviorEventArgs(STARTING_DRAG_POSITION, position);
            OnDragBehaviorDragging.Invoke(sender, args);
         }

         /*if (sender.GetType() == typeof(VertexControl))
         {
            var vertexControlObj = sender as VertexControl;
            var dataVertexObj = vertexControlObj.Vertex;
         }*/

         e.Handled = true;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private static void OnDragFinished(object sender, System.Windows.Input.MouseButtonEventArgs e)
      {
         var obj = sender as DependencyObject;

         // End dragging
         SetIsDragging(obj, false);

         var element = sender as IInputElement;

         // Get vartex at position
         VertexControl vc = obj as VertexControl;
         Point pos = vc.GetPosition();
         Point posMouse = e.GetPosition(vc);
         Point posSecond = new Point(pos.X + posMouse.X, pos.Y + posMouse.Y);

         Console.Out.WriteLine("Drag ended at pos(" + pos.ToString() + ") posMouse (" + posMouse.ToString() + ") posSecond (" + posSecond.ToString() + ")");

         if (OnDragBehaviorDragFinished != null)
         {
            ExtendedDragBehaviorEventArgs args = new ExtendedDragBehaviorEventArgs(STARTING_DRAG_POSITION, posSecond, true);
            OnDragBehaviorDragFinished.Invoke(sender, args);
         }

         if (element != null)
         {
            element.MouseMove -= OnDragging;
            element.ReleaseMouseCapture();
         }

         e.Handled = true;
      }

      #endregion

      #region SignalingEvents

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      public delegate void DragDelegate(object sender, ExtendedDragBehaviorEventArgs e);

      /// <summary>
      /// 
      /// </summary>
      public static event DragDelegate OnDragBehaviorDragStarted;

      /// <summary>
      /// 
      /// </summary>
      public static event DragDelegate OnDragBehaviorDragging;

      /// <summary>
      /// 
      /// </summary>
      public static event DragDelegate OnDragBehaviorDragFinished;

      #endregion
   }
}
