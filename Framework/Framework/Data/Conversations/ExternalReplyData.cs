using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// ExternalReplyData serializable class.
    /// </summary>
    [Serializable]
    public class ExternalReplyData
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
        /// Gets reply's time stamp.
        /// </summary>
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        /// <summary>
        /// Gets reply's author.
        /// </summary>
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        /// <summary>
        /// Gets reply's text.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// Get reply's list of children IDs.
        /// </summary>
        public List<Guid> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        /// <summary>
        /// Get reply's list of parent IDs.
        /// </summary>
        public List<Guid> Parents
        {
            get { return _parents; }
            set { _parents = value; }
        }

        /// <summary>
        /// Gets internal representation of the external representation of the reply data.
        /// </summary>
        public InternalReplyData InternalRepresentation
        {
            get { return ExternalReplyData.ToInternal(this); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default ExternalReplyData constructor.
        /// </summary>
        public ExternalReplyData()
        {
            _author = "";
            _text = "";
            _timestamp = new DateTime();
            _children = new List<Guid>();
            _parents = new List<Guid>();
        }

        /// <summary>
        /// Default constructor by internal representation of reply data.
        /// </summary>
        /// <param name="internalReplyData">Internal representation of reply data.</param>
        public ExternalReplyData(InternalReplyData internalReplyData)
        {
            _author = internalReplyData.Author;
            _text = internalReplyData.Text;
            _timestamp = internalReplyData.Timestamp;
            _children = internalReplyData.Children;
            _parents = internalReplyData.Parents;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get internal representation of external representation of the reply data.
        /// </summary>
        /// <param name="externalReplyData"></param>
        /// <returns></returns>
        private static InternalReplyData ToInternal(ExternalReplyData externalReplyData)
        {
            InternalReplyData internalReplyData = new InternalReplyData(externalReplyData.Timestamp,
                                                                        externalReplyData.Author,
                                                                        externalReplyData.Text);

            // Set parents
            foreach (Guid parent in externalReplyData.Parents)
            {
                internalReplyData.AddParent(parent);
            }

            // Set children
            foreach (Guid child in externalReplyData.Children)
            {
                internalReplyData.AddChild(child);
            }

            return internalReplyData;
        }

        #endregion
    }
}
