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
    /// BasicInformationControl class.
    /// </summary>
    public partial class BasicInformationControl : UserControl
    {
        #region Members

        #endregion

        #region Properties

        /// <summary>
        /// Get or set reply's timestamp.
        /// </summary>
        public DateTime Timestamp
        {
            get { return timestampPicker.Value; }
            set
            {
				//TODO see if this has major impact or not
                //if (value != null)
                //{
                    timestampPicker.Value = value;
                //}
            }
        }

        /// <summary>
        /// Get or set reply's author.
        /// </summary>
        public string Author
        {
            get { return usernameTextBox.Text; }
            set
            {
                if (value != null)
                {
                    usernameTextBox.Text = value;
                }
            }
        }

        /// <summary>
        /// Get or set reply's text.
        /// </summary>
        public string Reply
        {
            get { return replyText.Text; }
            set
            {
                if (value != null)
                {
                    replyText.Text = value;
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default BasicInformationControl constructor.
        /// </summary>
        public BasicInformationControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Timestamp = DateTime.Now;
        }

        #endregion

        #region Events

        #region Own Created Events

        #region OnInvalidInformation

        /// <summary>
        /// Invalid information delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void InvalidInformation(object sender, EventArgs e);

        /// <summary>
        /// OnInvalidInformation event.
        /// </summary>
        public event InvalidInformation OnInvalidInformation;

        #endregion

        #region OnValidInformation

        /// <summary>
        /// ValidInformation delegate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ValidInformation(object sender, EventArgs e);

        /// <summary>
        /// OnValidInformation event.
        /// </summary>
        public event ValidInformation OnValidInformation;

        #endregion

        #endregion

        /// <summary>
        /// Text changed event handler.
        /// </summary>
        /// <param name="sender">Textbox</param>
        /// <param name="e">Arguments.</param>
        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || replyText.Text == "")
            {
                InvalidateInformation();
            }
            else
            {
                ValidateInformation();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Reset information on control and invalidate information.
        /// </summary>
        public void ResetInformation()
        {
            timestampPicker.Value = DateTime.Now;
            usernameTextBox.Text = "";
            replyText.Text = "";

            InvalidateInformation();
        }

        /// <summary>
        /// Invalidate information by invoking the OnInvalidInformation event.
        /// </summary>
        private void InvalidateInformation()
        {
            if (OnInvalidInformation != null)
            {
                OnInvalidInformation.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Validate information by invoking the OnValidInformation event.
        /// </summary>
        private void ValidateInformation()
        {
            if (OnValidInformation != null)
            {
                OnValidInformation.Invoke(this, new EventArgs());
            }
        }

        #endregion
    }
}
