using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Framework.GUI.Controls.Conversations
{
    /// <summary>
    /// ImportedConversationControl control class.
    /// </summary>
    public partial class ImportedConversationsControl : UserControl
    {
        #region Variables

        #endregion

        #region Properties

        #endregion

        #region Constructors

        /// <summary>
        /// Default ImportedConversationsControl constructor.
        /// </summary>
        public ImportedConversationsControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Add reply click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addReply_Click(object sender, EventArgs e)
        {
            AddReply();
        }

        #endregion

        #region Methods 

        /// <summary>
        /// Add reply.
        /// </summary>
        private void AddReply()
        {

        }

        #endregion
    }
}
