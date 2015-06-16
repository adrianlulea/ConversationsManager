using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Util
{
   /// <summary>
   /// Graph link creating state
   /// </summary>
   public enum LinkCreateState
   {
      /// <summary>
      /// No link creating in progress
      /// </summary>
      None,
      /// <summary>
      /// Started link creating process, source node selected
      /// </summary>
      SelectedSourceNode,
      /// <summary>
      /// Finished link creating process, target node selected
      /// </summary>
      SelectedTargetNode
   }
}
