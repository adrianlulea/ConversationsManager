using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.GUI.Forms.Conversations;

namespace Framework.GUI.Controls.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class CreateNewDatabaseDetailsControl : UserControl
   {
      #region Members

      /// <summary>
      /// Link to parent form
      /// </summary>
      private SavedDataManagerForm _parent;

      /// <summary>
      /// 
      /// </summary>
      private string _conversationToImportPath = "";

      #endregion

      #region Properties

      /// <summary>
      /// Get flag if a Parser has been selected.
      /// </summary>
      public bool IsParserSelected
      {
         get { return this.parserList.SelectedItems.Count == 1; }
      }

      /// <summary>
      /// Get flag if a conversation for import has been selected.
      /// </summary>
      public bool IsConversationSelected
      {
         get { return this._conversationToImportPath != ""; }
      }

      /// <summary>
      /// Get flag if we are importing a conversation or not.
      /// </summary>
      public bool ImportingConversation
      {
         get { return this.importFromFileCheckBox.Checked; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parent">Link to parent form</param>
      public CreateNewDatabaseDetailsControl(SavedDataManagerForm parent)
      {
         this._parent = parent;
         InitializeComponent();
      }

      #endregion

      #region Event Handlers

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void importFromFileCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         EnableDisableImportFromFile(importFromFileCheckBox.Checked);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void browseFileToImportButton_Click(object sender, EventArgs e)
      {
         if (conversationImportFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            this._conversationToImportPath = conversationImportFileDialog.FileName;
         }
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      /// <param name="enable"></param>
      private void EnableDisableImportFromFile(bool enable)
      {
         parserGroupBox.Enabled = enable;
         browseFileToImportButton.Enabled = enable;

         this._parent.ValidateNewDatabase();
      }

      #endregion
   }
}
