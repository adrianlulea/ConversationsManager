using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutCustomAlgorithm
{
   /// <summary>
   /// Custom Layout algorithm interface.
   /// </summary>
   public interface ILayoutAlgorithm
   {
      /// <summary>
      /// Compute node positions
      /// </summary>
      /// <param name="orderedByTimestampNodes">List of Tuple(id, timestamp) node ids ordered by timestamp</param>
      /// <param name="nodeOrderedByTimestampChildrenListHash">Dictionary of (node ID, List of children ids ordered by timestamp)</param>
      /// <returns>Dictionary of (node ID, Tuple(x, y)) containing all the nodes and their positions in the graph</returns>
      Dictionary<Guid, Tuple<double, double>> ComputeNodePositions(List<Tuple<Guid, DateTime>> orderedByTimestampNodes, Dictionary<Guid, List<Guid>> nodeOrderedByTimestampChildrenListHash);
   }
}
