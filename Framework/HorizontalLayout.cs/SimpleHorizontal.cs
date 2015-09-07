using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayoutCustomAlgorithm;

namespace HorizontalLayout
{
   /// <summary>
   /// 
   /// </summary>
   public class SimpleHorizontal : ILayoutAlgorithm
   {
      #region Members

      /// <summary>
      /// Node positions in graph.
      /// </summary>
      private Dictionary<Guid, Tuple<double, double>> _nodePositions;

      /// <summary>
      /// Nodes ordered by timestamp.
      /// </summary>
      private List<Tuple<Guid, DateTime>> _orderedByTimestampNodes;

      /// <summary>
      /// Nodes children lists ordered by timestamp (the children)
      /// </summary>
      private Dictionary<Guid, List<Guid>> _nodeOrderedByTimestampChildrenListHash;

      //TODO permit settings (new framework to implement)
      private double _horizontalSpaceBetweenNodes;
      private double _verticalSpaceBetweenNodes;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public double HorizontalSpaceBetweenNodes
      {
         get { return _horizontalSpaceBetweenNodes; }
         set { _horizontalSpaceBetweenNodes = value; }
      }

      /// <summary>
      /// 
      /// </summary>
      public double VerticalSpaceBetweenNodes
      {
         get { return _verticalSpaceBetweenNodes; }
         set { _verticalSpaceBetweenNodes = value; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      public SimpleHorizontal()
      {
         _nodePositions = new Dictionary<Guid,Tuple<double,double>>();
         _orderedByTimestampNodes = new List<Tuple<Guid, DateTime>>();
         _nodeOrderedByTimestampChildrenListHash = new Dictionary<Guid, List<Guid>>();

         _horizontalSpaceBetweenNodes = 100.0;
         _verticalSpaceBetweenNodes = 100.0;
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      private void ComputeHorizontalPositions()
      {
         double xPosition = 0.0;
         double yPosition = 0.0;

         foreach (Tuple<Guid, DateTime> node in _orderedByTimestampNodes)
         {
            Guid nodeId = node.Item1;
            DateTime nodeTimestamp = node.Item2;

            _nodePositions.Add(nodeId, new Tuple<double, double>(xPosition, yPosition));

            xPosition += _horizontalSpaceBetweenNodes;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      private void ComputeVerticalPositions()
      {
         foreach (Tuple<Guid, DateTime> node in _orderedByTimestampNodes)
         {
            Guid nodeId = node.Item1;
            DateTime nodeTimestamp = node.Item2;

            // Get children list
            List<Guid> nodeChildrenList = _nodeOrderedByTimestampChildrenListHash[nodeId];

            double verticalAdjustment = _verticalSpaceBetweenNodes;

            foreach (Guid child in nodeChildrenList)
            {
               Tuple<double, double> currentChildPositon = _nodePositions[child];

               // Apply vertical adjustment
               Tuple<double, double> newChildPosition = new Tuple<double, double>(currentChildPositon.Item1, currentChildPositon.Item2 + verticalAdjustment);

               _nodePositions[child] = newChildPosition;

               // Compute next child's vertical adjustment
               verticalAdjustment += _verticalSpaceBetweenNodes;
            }
         }
      }

      #region ILayoutAlgorithm

      /// <summary>
      /// 
      /// </summary>
      /// <param name="orderedByTimestampNodes"></param>
      /// <param name="nodeOrderedByTimestampChildrenListHash"></param>
      /// <returns></returns>
      public Dictionary<Guid, Tuple<double, double>> ComputeNodePositions(List<Tuple<Guid, DateTime>> orderedByTimestampNodes, 
                                                                          Dictionary<Guid, List<Guid>> nodeOrderedByTimestampChildrenListHash)
       {
          _orderedByTimestampNodes = orderedByTimestampNodes;
          _nodeOrderedByTimestampChildrenListHash = nodeOrderedByTimestampChildrenListHash;

          ComputeHorizontalPositions();

          ComputeVerticalPositions();

          return _nodePositions;
       }

      #endregion

      #endregion
   }
}
