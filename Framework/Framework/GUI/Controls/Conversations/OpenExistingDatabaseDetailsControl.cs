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
   public partial class OpenExistingDatabaseDetailsControl : UserControl
   {
      #region Members

      /// <summary>
      /// Link to parent form
      /// </summary>
      private SavedDataManagerForm _parent;

      #endregion

      #region Properties

      /// <summary>
      /// Get existing group box control
      /// </summary>
      public GroupBox ExistingGroupBox
      {
         get { return this.existingGroupBox; }
      }

      /// <summary>
      /// Get Tool Strip Menu
      /// </summary>
      public ToolStrip OpenExistingToolMenu
      {
         get { return this.toolStrip1; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ToolStripButton RenameButton
      {
         get { return this.renameButton; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ToolStripTextBox NewName
      {
         get { return this.newName; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ToolStripButton FinishRenamingButton
      {
         get { return this.finishRenamingButton; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ToolStripButton DeleteButton
      {
         get { return this.deleteButton; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ListView SavedDataList
      {
         get { return this.savedDataList; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ColumnHeader NameHeader
      {
         get { return this.nameHeader; }
      }

      /// <summary>
      /// 
      /// </summary>
      public ColumnHeader SizeHeader
      {
         get { return this.sizeHeader; }
      }

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parent">Link to parent form</param>
      public OpenExistingDatabaseDetailsControl(SavedDataManagerForm parent)
      {
         this._parent = parent;
         InitializeComponent();
      }

      #endregion
   }
}
