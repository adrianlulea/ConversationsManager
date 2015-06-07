using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidReplyTimestampException class.
    /// </summary>
    [Serializable]
    public class InvalidReplyTimestampException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidReplyTimestampException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid timestamp (null).";

        /// <summary>
        /// InvalidReplyTimestampException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidReplyTimestampException constructor.
        /// </summary>
        public InvalidReplyTimestampException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
