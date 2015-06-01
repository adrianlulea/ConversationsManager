using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Data.Conversations;
using Framework.Util;

namespace Framework.GUI.Forms.Conversations
{
    /// <summary>
    /// View reply form.
    /// </summary>
    public partial class ViewReplyForm : Form
    {
        #region Members

        /// <summary>
        /// Internal representation of the reply's data.
        /// </summary>
        private InternalReplyData _data;

        /// <summary>
        /// Flag whether or not data has changed.
        /// </summary>
        private bool _dataChanged;

        /// <summary>
        /// Flag whether or not author has changed.
        /// </summary>
        private bool _authorChanged;

        /// <summary>
        /// Flag whether or not text has changed.
        /// </summary>
        private bool _textChanged;

        /// <summary>
        /// Flag whether or not the form is initializing.
        /// </summary>
        private bool _initializing;

        /// <summary>
        /// Reply's author.
        /// </summary>
        private string _author;

        /// <summary>
        /// Reply's text.
        /// </summary>
        private string _text;

        #endregion

        #region Properties

        /// <summary>
        /// Get data changed flag.
        /// </summary>
        public bool DataChanged
        {
            get { return _dataChanged; }
        }

        /// <summary>
        /// Get author changed flag.
        /// </summary>
        public bool AuthorChanged
        {
            get { return _authorChanged; }
        }

        /// <summary>
        /// Get text changed flag.
        /// </summary>
        public bool ReplyTextChanged
        {
            get { return _textChanged; }
        }

        /// <summary>
        /// Get internal representation of the reply's data.
        /// </summary>
        public InternalReplyData Data
        {
            get { return _data; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default ViewReplyForm constructor.
        /// </summary>
        /// <param name="data">Internal representation of the reply's data</param>
        public ViewReplyForm(InternalReplyData data)
        {
            _initializing = true;

            // Set data
            _data = data;

            // Initialize GUI
            InitializeComponent();

            // Initialize data
            InitializeData();

            _initializing = false;
        }

        #endregion

        #region Events

        /// <summary>
        /// Author or Text text changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autorOrText_TextChanged(object sender, EventArgs e)
        {
            if (_initializing)
            {
                return;
            }

            Control tb = (Control)sender;
            int tag = int.Parse(tb.Tag.ToString());
            ReplyField field = GetField(tag);
            ToggleSaveChangesButton(field, tb.Text);
        }

        /// <summary>
        /// Save changes button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _dataChanged = true;

            if (_authorChanged)
            {
                _data.Author = authorTextBox.Text;
            }
            if (_textChanged)
            {
                _data.Text = replyTextBox.Text;
            }

            saveChangesButton.Enabled = false;
        }

        /// <summary>
        /// Close button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize data on the form.
        /// </summary>
        private void InitializeData()
        {
            _dataChanged = false;
            _authorChanged = false;
            _textChanged = false;
            authorTextBox.Text = _data.Author;
            replyTextBox.Text = _data.Text;
        }

        /// <summary>
        /// Get field from tag.
        /// </summary>
        /// <param name="tag">Tag</param>
        /// <exception cref="InvalidFieldException">Tag is invalid.</exception>
        /// <returns></returns>
        private ReplyField GetField(int tag)
        {
            switch (tag)
            {
                case 0:
                    {
                        return ReplyField.Author;
                    }
                case 1:
                    {
                        return ReplyField.Text;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }
        
        /// <summary>
        /// Toggle save changes button depending on the field and it's new data.
        /// </summary>
        /// <param name="field">Field</param>
        /// <param name="data">Field's new data.</param>
        /// <exception cref="InvalidFieldException">Field is invalid.</exception>
        private void ToggleSaveChangesButton(ReplyField field, string data)
        {
            switch (field)
            {
                case ReplyField.Author:
                    {
                        _authorChanged = (_data.Author != data);
                        _author = data;
                        break;
                    }
                case ReplyField.Text:
                    {
                        _textChanged = (_data.Text != data);
                        _text = data;
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }

            bool dataChanged = (_authorChanged || _textChanged);
            bool dataIsValid = ((_author == "" || _text == "") == false);

            saveChangesButton.Enabled = (dataChanged && dataIsValid);
        }

        #endregion
    }
}
