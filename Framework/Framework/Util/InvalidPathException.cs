using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidPathException class.
    /// </summary>
    public class InvalidPathException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidPathException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid path (null or \"\").";

        /// <summary>
        /// InvalidPathException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidPathException constructor.
        /// </summary>
        public InvalidPathException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
