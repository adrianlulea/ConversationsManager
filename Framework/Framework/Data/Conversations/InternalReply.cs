using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Util;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// InternalReply class.
    /// </summary>
    public class InternalReply
    {
        #region Members

        /// <summary>
        /// Reply's unique identification.
        /// </summary>
        private Guid _id;

        /// <summary>
        /// Internal representation of a reply's data.
        /// </summary>
        private InternalReplyData _data;

        #endregion

        #region Properties

        /// <summary>
        /// Get reply's ID.
        /// </summary>
        public Guid Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Get internal reply's data.
        /// </summary>
        public InternalReplyData Data
        {
            get { return _data; }
        }

        /// <summary>
        /// Gets or sets reply's time stamp. Null value is not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyTimestampException">Null value is not accepted for reply's timestamp.</exception>
        public DateTime Timestamp
        {
            get { return _data.Timestamp; }
            set { _data.Timestamp = value; }
        }

        /// <summary>
        /// Gets or sets reply's author. Null or empty string values are not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyAuthorException">Null or empty string("") values are not accepted for reply's author.</exception>
        public string Author
        {
            get { return _data.Author; }
            set { _data.Author = value; }
        }

        /// <summary>
        /// Gets or sets reply's text. Null or empty string values are not accepted.
        /// </summary>
        /// <exception cref="InvalidReplyTextException">Null or empty string("") values are not accepted for reply's text.</exception>
        public string Text
        {
            get { return _data.Text; }
            set { _data.Text = value; }
        }

        /// <summary>
        /// Get reply's list of children IDs.
        /// </summary>
        public List<Guid> Children
        {
            get { return _data.Children; }
        }

        /// <summary>
        /// Get reply's list of parent IDs.
        /// </summary>
        public List<Guid> Parents
        {
            get { return _data.Parents; }
        }

        /// <summary>
        /// Get number of children.
        /// </summary>
        public int ChildCount
        {
            get { return _data.ChildCount; }
        }

        /// <summary>
        /// Get number of parents.
        /// </summary>
        public int ParentCount
        {
            get { return _data.ParentCount; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Internal representation of a reply by id, timestamp, author and text.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <param name="timestamp">Reply's timestamp.</param>
        /// <param name="author">Reply's author.</param>
        /// <param name="text">Reply's text.</param>
        /// <exception cref="InvalidReplyTimestampException">Timestamp value is invalid.</exception>
        /// <exception cref="InvalidReplyAuthorException">Author value is invalid.</exception>
        /// <exception cref="InvalidReplyTextException">Text value is invalid.</exception>
        public InternalReply(Guid id, DateTime timestamp, string author, string text)
        {
            _id = id;
            _data = new InternalReplyData(timestamp, author, text);
        }

        /// <summary>
        /// Internal representation of a reply by id and reply data.
        /// </summary>
        /// <param name="id">Reply's id.</param>
        /// <param name="data">Reply's data.</param>
        public InternalReply(Guid id, InternalReplyData data)
        {
            _id = id;
            _data = data;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add child by id. Duplicates are not allowed.
        /// </summary>
        /// <param name="id">Child id.</param>
        /// <exception cref="DuplicateReplyChildException">Duplicate children are not allowed.</exception>
        /// <exception cref="ReplyCircularDependencyException">Circular dependencies are not allowed.</exception>
        public void AddChild(Guid id)
        {
            _data.AddChild(id);
        }

        /// <summary>
        /// Add parent by id. Duplicates are not allowed.
        /// </summary>
        /// <param name="id">Parent id.</param>
        /// <exception cref="DuplicateReplyParentException">Duplicate parents are not allowed.</exception>
        /// <exception cref="ReplyCircularDependencyException">Circular dependencies are not allowed.</exception>
        public void AddParent(Guid id)
        {
            _data.AddParent(id);
        }

        /// <summary>
        /// Remove child by id.
        /// </summary>
        /// <param name="id">Child id.</param>
        public void RemoveChild(Guid id)
        {
            _data.RemoveChild(id);
        }

        /// <summary>
        /// Remove parent by id.
        /// </summary>
        /// <param name="id">Parent id.</param>
        public void RemoveParent(Guid id)
        {
            _data.RemoveParent(id);
        }

        #endregion
    }
}
