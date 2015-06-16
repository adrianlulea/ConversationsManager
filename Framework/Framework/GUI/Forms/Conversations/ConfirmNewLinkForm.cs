using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Data.Conversations;

namespace Framework.GUI.Forms.Conversations
{
   /// <summary>
   /// 
   /// </summary>
   public partial class ConfirmNewLinkForm : Form
   {
      #region Members

      #endregion

      #region Constructors

      /// <summary>
      /// 
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="child"></param>
      public ConfirmNewLinkForm(InternalReplyData parent, InternalReplyData child)
      {
         InitializeComponent();

         PopulateParentData(parent);
         PopulateChildData(child);
      }

      #endregion

      #region Methods

      /// <summary>
      /// 
      /// </summary>
      /// <param name="data"></param>
      private void PopulateParentData(InternalReplyData data)
      {
         parentAuthorTextBox.Text = data.Author;
         parentTextRichTextBox.Text = data.Text;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="data"></param>
      private void PopulateChildData(InternalReplyData data)
      {
         childAuthorTextBox.Text = data.Author;
         childTextRichTextBox.Text = data.Text;
      }

      #endregion

      #region Event Handlers

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void createLinkButton_Click(object sender, EventArgs e)
      {
         this.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.Close();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void cancelButton_Click(object sender, EventArgs e)
      {
         this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.Close();
      }

      #endregion
   }
}
