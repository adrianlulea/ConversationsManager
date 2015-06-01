using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidReplyIDException class.
    /// </summary>
    public class InvalidReplyIDException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidReplyIDException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid text (null or \"\").";

        /// <summary>
        /// InvalidReplyIDException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidReplyIDException constructor.
        /// </summary>
        public InvalidReplyIDException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
