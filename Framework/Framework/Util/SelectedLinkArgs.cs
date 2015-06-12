using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Util
{
   /// <summary>
   /// 
   /// </summary>
   public class SelectedLinkArgs : EventArgs
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private bool _valid;

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
      /// 
      /// </summary>
      public bool Valid
      {
         get { return _valid; }
      }

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
      /// 
      /// </summary>
      /// <param name="valid"></param>
      /// <param name="parent"></param>
      /// <param name="child"></param>
      public SelectedLinkArgs(bool valid, Guid parent, Guid child)
      {
         this._valid = valid;
         this._parentId = parent;
         this._childId = child;
      }

      #endregion
   }
}
