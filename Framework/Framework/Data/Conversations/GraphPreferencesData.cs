using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Util;

namespace Framework.Data.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   [Serializable]
   public class GraphPreferencesData
   {
      #region Members

      /// <summary>
      /// Default graph layout algorithm parameters.
      /// </summary>
      private DefaultGraphLayoutAlgorithm _defaultGraphLayoutAlgorithm;

      /// <summary>
      /// Custom graph layout algorithm name
      /// </summary>
      private string _customAlgorithmName;

      /// <summary>
      /// Custom graph layout algorithm library
      /// </summary>
      private string _customAlgorithmLibrary;

      /// <summary>
      /// Flag wether we always refresh the entire graph (when adding, removing nodes/links)
      /// </summary>
      private bool _alwaysRefreshEntireGraph;

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets default graph layout algorithm parameters.
      /// </summary>
      public DefaultGraphLayoutAlgorithm DefaultGraphLayoutAlgorithm
      {
         get { return _defaultGraphLayoutAlgorithm; }
         set { _defaultGraphLayoutAlgorithm = value; }
      }

      /// <summary>
      /// Gets or sets flag wether we always refresh the entire graph (when adding, removing nodes/links)
      /// </summary>
      public bool AlwaysRefreshEntireGraph
      {
         get { return _alwaysRefreshEntireGraph; }
         set { _alwaysRefreshEntireGraph = value; }
      }

      /// <summary>
      /// Gets or sets custom graph layout algorithm name
      /// </summary>
      public string CustomAlgorithmName
      {
         get { return _customAlgorithmName; }
         set { _customAlgorithmName = value; }
      }

      /// <summary>
      /// Gets or sets custom graph layout algorithm library
      /// </summary>
      public string CustomAlgorithmLibrary
      {
         get { return _customAlgorithmLibrary; }
         set { _customAlgorithmLibrary = value; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      public GraphPreferencesData()
      {
         _defaultGraphLayoutAlgorithm = new DefaultGraphLayoutAlgorithm();
         _alwaysRefreshEntireGraph = true;
         _customAlgorithmName = "None";
         _customAlgorithmLibrary = "None";
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="copyFrom"></param>
      public GraphPreferencesData(GraphPreferencesData copyFrom)
      {
         _defaultGraphLayoutAlgorithm = new DefaultGraphLayoutAlgorithm();

         _defaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm = copyFrom.DefaultGraphLayoutAlgorithm.DefaultLayoutAlgorithm;
         _defaultGraphLayoutAlgorithm.DefaultOverlapRemovalAlgorithm = copyFrom.DefaultGraphLayoutAlgorithm.DefaultOverlapRemovalAlgorithm;
         _defaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmHorizontalGap = copyFrom.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmHorizontalGap;
         _defaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmVerticalGap = copyFrom.DefaultGraphLayoutAlgorithm.OverlapRemovalAlgorithmVerticalGap;

         _alwaysRefreshEntireGraph = copyFrom.AlwaysRefreshEntireGraph;
         _customAlgorithmName = copyFrom.CustomAlgorithmName;
         _customAlgorithmLibrary = copyFrom.CustomAlgorithmLibrary;
      }

      #endregion

      #region Methods

      /// <summary>
      /// Test if two preferences use the same algorithm settings.
      /// </summary>
      /// <param name="first"></param>
      /// <param name="second"></param>
      /// <returns></returns>
      public static bool SameAlgorithmPreferencesUsed(GraphPreferencesData first, GraphPreferencesData second)
      {
         DefaultGraphLayoutAlgorithm firstDefaultAlgorithm = first.DefaultGraphLayoutAlgorithm;
         // We treat the case when the application has just started
         DefaultGraphLayoutAlgorithm secondDefaultAlgorithm = (second == null) ? first.DefaultGraphLayoutAlgorithm : second.DefaultGraphLayoutAlgorithm;

         if (firstDefaultAlgorithm.DefaultLayoutAlgorithm != secondDefaultAlgorithm.DefaultLayoutAlgorithm)
         {
            return false;
         }

         if (firstDefaultAlgorithm.DefaultOverlapRemovalAlgorithm != secondDefaultAlgorithm.DefaultOverlapRemovalAlgorithm)
         {
            return false;
         }

         if (firstDefaultAlgorithm.OverlapRemovalAlgorithmHorizontalGap != secondDefaultAlgorithm.OverlapRemovalAlgorithmHorizontalGap)
         {
            return false;
         }

         if (firstDefaultAlgorithm.OverlapRemovalAlgorithmVerticalGap != secondDefaultAlgorithm.OverlapRemovalAlgorithmVerticalGap)
         {
            return false;
         }

         return true;
      }

      #endregion
   }
}
