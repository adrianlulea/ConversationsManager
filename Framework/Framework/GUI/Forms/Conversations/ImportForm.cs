using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Util;
using Framework.GUI.Controls.Conversations;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// Import form.
    /// </summary>
    public partial class ImportForm : Form
    {
        #region Variables

        /// <summary>
        /// Conversations control.
        /// </summary>
        private ImportedConversationsControl _conversations = null;

        #endregion

        #region Properties

        /// <summary>
        /// Get conversations control.
        /// </summary>
        public ImportedConversationsControl Conversations
        {
            get { return _conversations; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default import constructor.
        /// </summary>
        public ImportForm()
        {
            // Initalize component
            InitializeComponent();

            // Load default conversations control
            LoadControl(ImportControlEnum.Conversations);
        }

        /// <summary>
        /// Import from file.
        /// </summary>
        /// <param name="path">File path.</param>
        public ImportForm(string path)
        {
            // Initialize component
            InitializeComponent();

            // Load default importing control
            LoadControl(ImportControlEnum.ImportFromFile);
        }

        #endregion

        #region Events



        #endregion

        #region Methods

        /// <summary>
        /// Load control by import control enumeration.
        /// </summary>
        /// <param name="control">Import control enumeration.</param>
        private void LoadControl(ImportControlEnum control)
        {
            switch (control)
            {
                case ImportControlEnum.Conversations:
                    {
                        if (_conversations == null)
                        {
                            _conversations = new ImportedConversationsControl();
                            _conversations.Dock = DockStyle.Fill;
                            this.hostPanel.Controls.Add(_conversations);
                        }
                        else
                        {
                            _conversations.BringToFront();
                        }
                        break;
                    }
                case ImportControlEnum.ImportFromFile:
                    {
                        throw new Exception("Not implemented yet.");
                    }
            }
        }

        #endregion
    }
}
