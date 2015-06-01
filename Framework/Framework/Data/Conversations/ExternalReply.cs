using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Data.Conversations
{
    /// <summary>
    /// ExternalReply serializable class.
    /// </summary>
    [Serializable]
    public class ExternalReply
    {
        #region Members

        /// <summary>
        /// Reply's unique identification.
        /// </summary>
        private Guid _id;

        /// <summary>
        /// External representation of a reply's data.
        /// </summary>
        private ExternalReplyData _data;

        #endregion

        #region Properties

        /// <summary>
        /// Get reply's ID.
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Get external reply's data.
        /// </summary>
        public ExternalReplyData Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// Gets internal representation of the external representation of the reply data.
        /// </summary>
        public InternalReply InternalRepresentation
        {
            get { return ExternalReply.ToInternal(this); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public ExternalReply()
        {
            _id = Guid.Empty;
            _data = new ExternalReplyData();
        }

        /// <summary>
        /// Default constructor by internal representation of a reply.
        /// </summary>
        /// <param name="internalReply">Internal representation of a reply</param>
        public ExternalReply(InternalReply internalReply)
        {
            _id = internalReply.Id;
            _data = new ExternalReplyData(internalReply.Data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get internal representation of external representation of the reply data.
        /// </summary>
        /// <param name="externalReplyData"></param>
        /// <returns></returns>
        private static InternalReply ToInternal(ExternalReply externalReplyData)
        {
            InternalReply internalReply = new InternalReply(externalReplyData.Id,
                                                            externalReplyData.Data.InternalRepresentation);

            return internalReply;
        }

        #endregion
    }
}
