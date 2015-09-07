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
   public class SelectedAlgorithmEventArgs : EventArgs
   {
      #region Members

      /// <summary>
      /// Algorithm's name.
      /// </summary>
      private string _algorithmName;

      /// <summary>
      /// Algorithm's library.
      /// </summary>
      private string _libraryName;

      /// <summary>
      /// Valid data.
      /// </summary>
      private bool _valid;

      /// <summary>
      /// Gets flag if data is valid
      /// </summary>
      public bool Valid
      {
         get { return _valid; }
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets algorithm's name.
      /// </summary>
      public string AlgorithmName
      {
         get { return _algorithmName; }
      }

      /// <summary>
      /// Gets algorithm's library.
      /// </summary>
      public string LibraryName
      {
         get { return _libraryName; }
      }



      #endregion

      #region Constructors

      /// <summary>
      /// Create selected algorithm event arguments.
      /// </summary>
      /// <param name="name">Algorithm's name.</param>
      /// <param name="library">Algorithm's library name.</param>
      /// <param name="valid">Flag whether data is valid or not.</param>
      public SelectedAlgorithmEventArgs(string name, string library, bool valid)
      {
         _algorithmName = name;
         _libraryName = library;
         _valid = valid;
      }

      #endregion
   }
}
