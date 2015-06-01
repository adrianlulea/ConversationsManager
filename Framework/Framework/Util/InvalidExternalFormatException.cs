using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidExternalFormatException class.
    /// </summary>
    public class InvalidExternalFormatException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidExternalFormatException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Invalid external format.";

        /// <summary>
        /// InvalidExternalFormatException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidExternalFormatException constructor.
        /// </summary>
        public InvalidExternalFormatException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
