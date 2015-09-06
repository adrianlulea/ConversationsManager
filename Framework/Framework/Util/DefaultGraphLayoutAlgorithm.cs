using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX.PCL.Common.Enums;

namespace Framework.Util
{
   /// <summary>
   /// 
   /// </summary>
   [Serializable]
   public class DefaultGraphLayoutAlgorithm
   {
      #region Members

      /// <summary>
      /// Existing layout algorithm.
      /// </summary>
      private LayoutAlgorithmTypeEnum _defaultLayoutAlgorithm;

      /// <summary>
      /// Existing overlap removal algorithm.
      /// </summary>
      private OverlapRemovalAlgorithmTypeEnum _defaultOverlapRemovalAlgorithm;

      /// <summary>
      /// Existing overlap removal algorithm used horizontal gap.
      /// </summary>
      private int _overlapRemovalAlgorithmHorizontalGap;

      /// <summary>
      /// Existing overlap removal algorithm used vertical gap.
      /// </summary>
      private int _overlapRemovalAlgorithmVerticalGap;

      #endregion

      #region Properties

      /// <summary>
      /// Get or set existing layout algorithm.
      /// </summary>
      public LayoutAlgorithmTypeEnum DefaultLayoutAlgorithm
      {
         get { return _defaultLayoutAlgorithm; }
         set { _defaultLayoutAlgorithm = value; }
      }

      /// <summary>
      /// Get or set existing overlap removal algorithm.
      /// </summary>
      public OverlapRemovalAlgorithmTypeEnum DefaultOverlapRemovalAlgorithm
      {
         get { return _defaultOverlapRemovalAlgorithm; }
         set { _defaultOverlapRemovalAlgorithm = value; }
      }

      /// <summary>
      /// Get or set existing overlap removal algorithm used horizontal gap.
      /// </summary>
      public int OverlapRemovalAlgorithmHorizontalGap
      {
         get { return _overlapRemovalAlgorithmHorizontalGap; }
         set { _overlapRemovalAlgorithmHorizontalGap = value; }
      }

      /// <summary>
      /// Get or set existing overlap removal algorithm used vertical gap.
      /// </summary>
      public int OverlapRemovalAlgorithmVerticalGap
      {
         get { return _overlapRemovalAlgorithmVerticalGap; }
         set { _overlapRemovalAlgorithmVerticalGap = value; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// Default Graph Layout
      /// </summary>
      public DefaultGraphLayoutAlgorithm()
      {
         _defaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.EfficientSugiyama;
         _defaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
         _overlapRemovalAlgorithmHorizontalGap = 50;
         _overlapRemovalAlgorithmVerticalGap = 50;
      }

      #endregion

      #region Methods

      #region DefaultLayoutAlgorithm

      /// <summary>
      /// Get string value from enumeration
      /// </summary>
      /// <param name="layoutAlgorithm"></param>
      /// <returns></returns>
      public static string LayoutAlgorithmToString(LayoutAlgorithmTypeEnum layoutAlgorithm)
      {
         switch (layoutAlgorithm)
         {
            case LayoutAlgorithmTypeEnum.BoundedFR: { return "Bounded FR"; }
            case LayoutAlgorithmTypeEnum.Circular: { return "Circular"; }
            case LayoutAlgorithmTypeEnum.CompoundFDP: { return "Compound FDP"; }
            case LayoutAlgorithmTypeEnum.Custom: { return "Custom"; }
            case LayoutAlgorithmTypeEnum.EfficientSugiyama: { return "Efficient Sugiyama"; }
            case LayoutAlgorithmTypeEnum.FR: { return "FR"; }
            case LayoutAlgorithmTypeEnum.ISOM: { return "ISOM"; }
            case LayoutAlgorithmTypeEnum.KK: { return "KK"; }
            case LayoutAlgorithmTypeEnum.LinLog: { return "LinLog"; }
            case LayoutAlgorithmTypeEnum.SimpleRandom: { return "Simple Random"; }
            case LayoutAlgorithmTypeEnum.Sugiyama: { return "Sugiyama"; }
            case LayoutAlgorithmTypeEnum.Tree: { return "Tree"; }
            default: { return ""; }
         }
      }

      /// <summary>
      /// Get LayoutAlgorithm enumeration from string
      /// </summary>
      /// <param name="layoutAlgorithm"></param>
      /// <returns></returns>
      public static LayoutAlgorithmTypeEnum LayoutAlgorithmFromString(string layoutAlgorithm)
      {
         Dictionary<string, LayoutAlgorithmTypeEnum> stringEnumLayoutAlgorithmHash = new Dictionary<string, LayoutAlgorithmTypeEnum>();

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.BoundedFR),
                                           LayoutAlgorithmTypeEnum.BoundedFR);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Circular),
                                           LayoutAlgorithmTypeEnum.Circular);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.CompoundFDP),
                                           LayoutAlgorithmTypeEnum.CompoundFDP);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Custom),
                                           LayoutAlgorithmTypeEnum.Custom);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.EfficientSugiyama),
                                           LayoutAlgorithmTypeEnum.EfficientSugiyama);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.FR),
                                           LayoutAlgorithmTypeEnum.FR);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.ISOM),
                                           LayoutAlgorithmTypeEnum.ISOM);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.KK),
                                           LayoutAlgorithmTypeEnum.KK);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.LinLog),
                                           LayoutAlgorithmTypeEnum.LinLog);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.SimpleRandom),
                                           LayoutAlgorithmTypeEnum.SimpleRandom);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Sugiyama),
                                           LayoutAlgorithmTypeEnum.Sugiyama);

         stringEnumLayoutAlgorithmHash.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Tree),
                                           LayoutAlgorithmTypeEnum.Tree);

         if (stringEnumLayoutAlgorithmHash.ContainsKey(layoutAlgorithm))
         {
            return stringEnumLayoutAlgorithmHash[layoutAlgorithm];
         }
         else
         {
            throw new Exception("Invalid Default Layout Algorithm.");
         }
      }

      /// <summary>
      /// Get list of available default layout algorithms
      /// </summary>
      /// <returns></returns>
      public static List<string> LayoutDefaultAlgorithmList()
      {
         List<string> layoutDefaultAlgorithms = new List<string>();

         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.BoundedFR));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Circular));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.CompoundFDP));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.EfficientSugiyama));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.FR));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.ISOM));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.KK));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.LinLog));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.SimpleRandom));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Sugiyama));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Tree));
         layoutDefaultAlgorithms.Add(LayoutAlgorithmToString(LayoutAlgorithmTypeEnum.Custom));

         return layoutDefaultAlgorithms;
      }

      #endregion

      #region DefaultOverlapRemovalAlgorithm

      /// <summary>
      /// Get string value from enumeration
      /// </summary>
      /// <param name="overlapRemovalAlgorithm"></param>
      /// <returns></returns>
      public static string OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum overlapRemovalAlgorithm)
      {
         switch(overlapRemovalAlgorithm)
         {
            case OverlapRemovalAlgorithmTypeEnum.None: { return "None"; }
            case OverlapRemovalAlgorithmTypeEnum.FSA: { return "FSA"; }
            case OverlapRemovalAlgorithmTypeEnum.OneWayFSA: { return "One Way FSA"; }
            default: { return ""; }
         }
      }

      /// <summary>
      /// Get overlap removal algorithm from string
      /// </summary>
      /// <param name="overlapRemovalAlgorithm"></param>
      /// <returns></returns>
      public static OverlapRemovalAlgorithmTypeEnum OverlapRemovalAlgorithmFromString(string overlapRemovalAlgorithm)
      {
         Dictionary<string, OverlapRemovalAlgorithmTypeEnum> stringEnumOverlapRemovalAlgorithmHash = new Dictionary<string, OverlapRemovalAlgorithmTypeEnum>();

         stringEnumOverlapRemovalAlgorithmHash.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.FSA),
                                                   OverlapRemovalAlgorithmTypeEnum.FSA);

         stringEnumOverlapRemovalAlgorithmHash.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.None),
                                                   OverlapRemovalAlgorithmTypeEnum.None);

         stringEnumOverlapRemovalAlgorithmHash.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.OneWayFSA),
                                                   OverlapRemovalAlgorithmTypeEnum.OneWayFSA);

         if (stringEnumOverlapRemovalAlgorithmHash.ContainsKey(overlapRemovalAlgorithm))
         {
            return stringEnumOverlapRemovalAlgorithmHash[overlapRemovalAlgorithm];
         }
         else
         {
            throw new Exception("Invalid Default Overlap Removal Algorithm.");
         }
      }

      /// <summary>
      /// Get list of available default overlap removal algorithms
      /// </summary>
      /// <returns></returns>
      public static List<string> OverlapRemovalDefaultAlgorithmList()
      {
         List<string> overlapRemovalDefaultAlgorithms = new List<string>();

         overlapRemovalDefaultAlgorithms.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.None));
         overlapRemovalDefaultAlgorithms.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.FSA));
         overlapRemovalDefaultAlgorithms.Add(OverlapRemovalAlgorithmToString(OverlapRemovalAlgorithmTypeEnum.OneWayFSA));

         return overlapRemovalDefaultAlgorithms;
      }

      #endregion

      #endregion
   }
}
