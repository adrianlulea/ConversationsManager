using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Util;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// InternalReplyData class.
    /// </summary>
    public class InternalReplyData
    {
        #region Members

        /// <summary>
        /// Reply's timestamp.
        /// </summary>
        private DateTime _timestamp;

        /// <summary>
        /// Reply's author.
        /// </summary>
        private string _author;

        /// <summary>
        /// Reply's text.
        /// </summary>
        private string _text;

        /// <summary>
        /// Reply's list of children.
        /// </summary>
        private List<Guid> _children;

        /// <summary>
        /// Reply's list of parents.
        /// </summary>
        private List<Guid> _parents;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets reply's time stamp. Null value is not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyTimestampException">Null value is not accepted for reply's timestamp.</exception>
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set
            {
                TestValidField(ReplyField.Timestamp, value);
                _timestamp = value;
            }
        }

        /// <summary>
        /// Gets or sets reply's author. Null or empty string values are not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyAuthorException">Null or empty string("") values are not accepted for reply's author.</exception>
        public string Author
        {
            get { return _author; }
            set
            {
                TestValidField(ReplyField.Author, value);
                _author = value;
            }
        }

        /// <summary>
        /// Gets or sets reply's text. Null or empty string values are not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyTextException">Null or empty string("") values are not accepted for reply's text.</exception>
        public string Text
        {
            get { return _text; }
            set
            {
                TestValidField(ReplyField.Text, value);
                _text = value;
            }
        }

        /// <summary>
        /// Get reply's list of children IDs.
        /// </summary>
        public List<Guid> Children
        {
            get { return _children; }
        }

        /// <summary>
        /// Get reply's list of parent IDs.
        /// </summary>
        public List<Guid> Parents
        {
            get { return _parents; }
        }

        /// <summary>
        /// Get number of children.
        /// </summary>
        public int ChildCount
        {
            get { return _children.Count; }
        }

        /// <summary>
        /// Get number of parents.
        /// </summary>
        public int ParentCount
        {
            get { return _parents.Count; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Internal representation of a reply's data by timestamp, author and text.
        /// </summary>
        /// <param name="timestamp">Reply's timestamp.</param>
        /// <param name="author">Reply's author.</param>
        /// <param name="text">Reply's text.</param>
        /// <exception cref="InvalidReplyTimestampException">Timestamp value is invalid.</exception>
        /// <exception cref="InvalidReplyAuthorException">Author value is invalid.</exception>
        /// <exception cref="InvalidReplyTextException">Text value is invalid.</exception>
        public InternalReplyData(DateTime timestamp, string author, string text)
        {
            // Test fields
            TestValidField(ReplyField.Timestamp, timestamp);
            TestValidField(ReplyField.Author, author);
            TestValidField(ReplyField.Text, text);

            // Assign fields
            _timestamp = timestamp;
            _author = author;
            _text = text;
            _children = new List<Guid>();
            _parents = new List<Guid>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Test valid field and throw exception accordingly.
        /// </summary>
        /// <param name="field">Reply field to test.</param>
        /// <param name="value">Value given to reply field.</param>
        /// <exception cref="InvalidReplyTimestampException">Timestamp value is invalid.</exception>
        /// <exception cref="InvalidReplyAuthorException">Author value is invalid.</exception>
        /// <exception cref="InvalidReplyTextException">Text value is invalid.</exception>
        /// <exception cref="InvalidFieldException">Given invalid field.</exception>
        private void TestValidField(ReplyField field, object value)
        {
            switch (field)
            {
                case ReplyField.Timestamp:
                    {
                        if (value == null)
                        {
                            throw new InvalidReplyTimestampException();
                        }
                        break;
                    }
                case ReplyField.Author:
                    {
                        if (value == null || (string)value == "")
                        {
                            throw new InvalidReplyAuthorException();
                        }
                        break;
                    }
                case ReplyField.Text:
                    {
                        if (value == null || (string)value == "")
                        {
                            throw new InvalidReplyTextException();
                        }
                        break;
                    }
                default:
                    {
                        throw new InvalidFieldException();
                    }
            }
        }

        /// <summary>
        /// Add child by id. Duplicates are not allowed.
        /// </summary>
        /// <param name="id">Child id.</param>
        /// <exception cref="DuplicateReplyChildException">Duplicate children are not allowed.</exception>
        /// <exception cref="ReplyCircularDependencyException">Circular dependencies are not allowed.</exception>
        public void AddChild(Guid id)
        {
            if (_children.Contains(id))
            {
                throw new DuplicateReplyChildException();
            }

            if (_parents.Contains(id))
            {
                throw new ReplyCircularDependencyException();
            }

            _children.Add(id);
        }

        /// <summary>
        /// Add parent by id. Duplicates are not allowed.
        /// </summary>
        /// <param name="id">Parent id.</param>
        /// <exception cref="DuplicateReplyParentException">Duplicate parents are not allowed.</exception>
        /// <exception cref="ReplyCircularDependencyException">Circular dependencies are not allowed.</exception>
        public void AddParent(Guid id)
        {
            if (_parents.Contains(id))
            {
                throw new DuplicateReplyParentException();
            }

            if (_children.Contains(id))
            {
                throw new ReplyCircularDependencyException();
            }

            _parents.Add(id);
        }

        /// <summary>
        /// Remove child by id.
        /// </summary>
        /// <param name="id">Child id.</param>
        public void RemoveChild(Guid id)
        {
            _children.Remove(id);
        }

        /// <summary>
        /// Remove parent by id.
        /// </summary>
        /// <param name="id">Parent id.</param>
        public void RemoveParent(Guid id)
        {
            _parents.Remove(id);
        }

        #endregion
    }
}
