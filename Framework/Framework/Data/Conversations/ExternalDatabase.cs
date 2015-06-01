using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// ExternalConversationDatabase serializable class.
    /// </summary>
    [Serializable]
    public class ExternalDatabase
    {
        #region Members

        /// <summary>
        /// List of replies.
        /// </summary>
        private List<ExternalReply> _replies;

        #endregion

        #region Properties

        /// <summary>
        /// Get list of external replies.
        /// </summary>
        public List<ExternalReply> Replies
        {
            get { return _replies; }
        }

        /// <summary>
        /// Gets internal representation of the external representation of the database.
        /// </summary>
        public InternalDatabase InternalRepresentation
        {
            get { return ExternalDatabase.ToInternal(this); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default empty ExternalDatabase constructor.
        /// </summary>
        public ExternalDatabase()
        {
            _replies = new List<ExternalReply>();
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="internalDatabase">Internal representation of data.</param>
        public ExternalDatabase(InternalDatabase internalDatabase)
        {
            List<InternalReply> internalReplies = internalDatabase.Replies;
            _replies = new List<ExternalReply>();

            foreach (InternalReply internalReply in internalReplies)
            {
                ExternalReply externalReply = new ExternalReply(internalReply);

                _replies.Add(externalReply);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get internal representation of external representation of the database.
        /// </summary>
        /// <param name="externalDatabase">External representation of data.</param>
        /// <returns>Internal representation of data.</returns>
        private static InternalDatabase ToInternal(ExternalDatabase externalDatabase)
        {
            InternalDatabase internalDatabase = new InternalDatabase(externalDatabase);

            return internalDatabase;
        }

        #endregion
    }
}
