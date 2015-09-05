using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class SplitViewManagerHost : UserControl
   {
      #region Members

      /// <summary>
      /// Link to Normal view
      /// </summary>
      private ConversationsManagerHost _normal;

      /// <summary>
      /// Link to Graph view
      /// </summary>
      private GraphManagerHost _graph;

      #endregion

      #region Properties

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="normalHost"></param>
      /// <param name="graphHost"></param>
      public SplitViewManagerHost(ConversationsManagerHost normalHost, GraphManagerHost graphHost)
      {
         _normal = normalHost;
         _graph = graphHost;

         // Default Dock = DockStyle.Fill
         Dock = DockStyle.Fill;

         InitializeComponent();

         InitializeSplitHost();
      }

      #endregion

      #region Event Handlers

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      private void InitializeSplitHost()
      {
         this.normalPanelHost.Controls.Add(_normal);
         this.graphPanelHost.Controls.Add(_graph);
      }

      #endregion
   }
}
