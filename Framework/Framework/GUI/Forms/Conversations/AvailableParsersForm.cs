using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.GUI.Controls.Conversations;

namespace Framework.GUI.Forms.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class AvailableParsersForm : Form
   {
      #region Members

      private ParserLibrariesControl _parserLibraries;

      #endregion

      #region Properties

      /// <summary>
      /// 
      /// </summary>
      public List<ListViewItem> Parsers
      {
         get { return _parserLibraries.Parsers; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parsersPath"></param>
      public AvailableParsersForm(string parsersPath)
      {
         InitializeComponent();
         InitializeParserLibrariesHost(parsersPath);
      }

      #endregion

      #region Event handlers

      private void doneButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      #endregion

      #region Methods

      private void InitializeParserLibrariesHost(string parsersPath)
      {
         _parserLibraries = new ParserLibrariesControl(parsersPath);
         parserLibrariesHost.Controls.Add(_parserLibraries);
      }

      #endregion
   }
}
