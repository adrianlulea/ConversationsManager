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
   public static class ExtendedHighlightBehavior
   {
      #region Attached properties

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty HighlightedChildProperty = DependencyProperty.RegisterAttached("HighlightedChild", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty HighlightedParentProperty = DependencyProperty.RegisterAttached("HighlightedParent", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty HoveredParentProperty = DependencyProperty.RegisterAttached("HoveredParent", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty HighlightedChildLinkProperty = DependencyProperty.RegisterAttached("HighlightedChildLink", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty HighlightedParentLinkProperty = DependencyProperty.RegisterAttached("HighlightedParentLink", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));

      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty AvailableNodeForLinkProperty = DependencyProperty.RegisterAttached("AvailableNodeForLink", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));
      
      /// <summary>
      /// 
      /// </summary>
      public static readonly DependencyProperty UnavailableNodeForLinkProperty = DependencyProperty.RegisterAttached("UnavailableNodeForLink", typeof(bool), typeof(ExtendedHighlightBehavior), new PropertyMetadata(false));
      
      #endregion

      #region Methods

      #region HighlightedChildProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetHighlightedChild(DependencyObject obj)
      {
         return (bool)obj.GetValue(HighlightedChildProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetHighlightedChild(DependencyObject obj, bool value)
      {
         obj.SetValue(HighlightedChildProperty, value);
      }

      #endregion

      #region HighlightedParentProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetHighlightedParent(DependencyObject obj)
      {
         return (bool)obj.GetValue(HighlightedParentProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetHighlightedParent(DependencyObject obj, bool value)
      {
         obj.SetValue(HighlightedParentProperty, value);
      }

      #endregion

      #region HoveredParentProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetHoveredParent(DependencyObject obj)
      {
         return (bool)obj.GetValue(HoveredParentProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetHoveredParent(DependencyObject obj, bool value)
      {
         obj.SetValue(HoveredParentProperty, value);
      }

      #endregion

      #region HighlightedChildLinkProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetHighlightedChildLink(DependencyObject obj)
      {
         return (bool)obj.GetValue(HighlightedChildLinkProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetHighlightedChildLink(DependencyObject obj, bool value)
      {
         obj.SetValue(HighlightedChildLinkProperty, value);
      }

      #endregion

      #region HighlightedParentLinkProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetHighlightedParentLink(DependencyObject obj)
      {
         return (bool)obj.GetValue(HighlightedParentLinkProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetHighlightedParentLink(DependencyObject obj, bool value)
      {
         obj.SetValue(HighlightedParentLinkProperty, value);
      }

      #endregion

      #region AvailableNodeForLinkProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetAvailableNodeForLink(DependencyObject obj)
      {
         return (bool)obj.GetValue(AvailableNodeForLinkProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetAvailableNodeForLink(DependencyObject obj, bool value)
      {
         obj.SetValue(AvailableNodeForLinkProperty, value);
      }

      #endregion

      #region UnavailableNodeForLinkProperty

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool GetUnavailableNodeForLink(DependencyObject obj)
      {
         return (bool)obj.GetValue(UnavailableNodeForLinkProperty);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public static void SetUnavailableNodeForLink(DependencyObject obj, bool value)
      {
         obj.SetValue(UnavailableNodeForLinkProperty, value);
      }

      #endregion

      #endregion
   }
}
