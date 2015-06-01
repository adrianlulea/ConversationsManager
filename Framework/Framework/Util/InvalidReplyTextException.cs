using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidReplyTextException class.
    /// </summary>
    public class InvalidReplyTextException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidReplyTextException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid text (null or \"\").";

        /// <summary>
        /// InvalidReplyTextException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidReplyTextException constructor.
        /// </summary>
        public InvalidReplyTextException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
