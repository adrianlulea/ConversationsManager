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
   public class SelectedNodeArgs : EventArgs
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private bool _valid;

      /// <summary>
      /// 
      /// </summary>
      private Guid _id;

      #endregion

      #region Properties

      /// <summary>
      /// Get valid flag
      /// </summary>
      public bool Valid
      {
         get { return this._valid; }
      }

      /// <summary>
      /// Get Id
      /// </summary>
      public Guid Id
      {
         get { return this._id; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="valid"></param>
      /// <param name="id"></param>
      public SelectedNodeArgs(bool valid, Guid id)
      {
         this._valid = valid;
         this._id = id;
      }

      #endregion
   }
}
