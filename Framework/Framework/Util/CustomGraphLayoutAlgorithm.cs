using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX.PCL.Common.Interfaces;
using GraphX.PCL.Logic.Algorithms.LayoutAlgorithms;
using QuickGraph;
using Framework.GUI.Graph;
using LayoutCustomAlgorithm;

namespace Framework.Util
{
   /// <summary>
   /// 
   /// </summary>
   public class CustomGraphLayoutAlgorithm : IExternalLayout<DataVertex>
   {
      #region Members

      /// <summary>
      /// 
      /// </summary>
      private ILayoutAlgorithm _customLayoutAlgorithm;

      /// <summary>
      /// 
      /// </summary>
      private IDictionary<DataVertex, GraphX.Measure.Point> _vertexPositions = new Dictionary<DataVertex, GraphX.Measure.Point>();

      /// <summary>
      /// 
      /// </summary>
      private readonly IVertexAndEdgeListGraph<DataVertex, DataEdge> _graph;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public IExternalLayout<DataVertex> LayoutAlgorithm
      {
         get { return this; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="layout"></param>
      public CustomGraphLayoutAlgorithm(ILayoutAlgorithm layout, IVertexAndEdgeListGraph<DataVertex, DataEdge> graph)
      {
         _customLayoutAlgorithm = layout;
      }

      #endregion

      #region Methods

      #region IExternalLayout

      /// <summary>
      /// 
      /// </summary>
      /// <param name="cancellationToken"></param>
      public void Compute(System.Threading.CancellationToken cancellationToken)
      {
         //TODO
      }

      /// <summary>
      /// 
      /// </summary>
      public bool NeedVertexSizes
      {
         get { return true; }
      }

      /// <summary>
      /// 
      /// </summary>
      public bool SupportsObjectFreeze
      {
         get { return true; }
      }

      /// <summary>
      /// 
      /// </summary>
      public IDictionary<DataVertex, GraphX.Measure.Point> VertexPositions
      {
         get { return _vertexPositions; }
      }

      /// <summary>
      /// 
      /// </summary>
      public IDictionary<DataVertex, GraphX.Measure.Size> VertexSizes
      {
         get;
         set;
      }

      #endregion

      #endregion

      #region Events



      #endregion

   }
}
