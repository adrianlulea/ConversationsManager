using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// InvalidFieldException class.
    /// </summary>
    [Serializable]
    public class InvalidFieldException : BaseException
    {
        #region Constants

        /// <summary>
        /// InvalidFieldException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Passed invalid field.";

        /// <summary>
        /// InvalidFieldException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default InvalidFieldException constructor.
        /// </summary>
        public InvalidFieldException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
