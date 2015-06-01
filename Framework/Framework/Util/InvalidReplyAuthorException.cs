using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidReplyAuthorException class.
    /// </summary>
    public class InvalidReplyAuthorException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidReplyAuthorException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid author (null or \"\").";

        /// <summary>
        /// InvalidReplyAuthorException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidReplyAuthorException constructor.
        /// </summary>
        public InvalidReplyAuthorException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
