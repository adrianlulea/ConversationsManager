using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// Base Exception.
    /// </summary>
    public class BaseException : Exception
    {
        #region Constants

        /// <summary>
        /// Default exception text.
        /// </summary>
        private const string UNKNOWN_EXCEPTION = "Unknown exception.";
        
        #endregion

        #region Members

        /// <summary>
        /// Exception's text.
        /// </summary>
        private string _text = BaseException.UNKNOWN_EXCEPTION;

        /// <summary>
        /// Exception's severity.
        /// </summary>
        private ExceptionSeverity _severity = ExceptionSeverity.Info;

        #endregion

        #region Constructors

        /// <summary>
        /// BaseException constructor.
        /// </summary>
        /// <param name="text">Exception's text. Default value is "Unknown exception."</param>
        /// <param name="severity">Exception's severity level. Default value is Info.</param>
        public BaseException(string text = BaseException.UNKNOWN_EXCEPTION, ExceptionSeverity severity = ExceptionSeverity.Info)
        {
            _text = text;
            _severity = severity;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get exception's text.
        /// </summary>
        public string Text
        {
            get { return _text; }
        }

        /// <summary>
        /// Get exception's severity.
        /// </summary>
        public ExceptionSeverity Severity
        {
            get { return _severity; }
        }

        #endregion
    }
}
