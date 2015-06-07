using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidStateException class.
    /// </summary>
    [Serializable]
    public class InvalidStateException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidStateException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid state (not 0 or 1).";

        /// <summary>
        /// InvalidStateException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidStateException constructor.
        /// </summary>
        public InvalidStateException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
