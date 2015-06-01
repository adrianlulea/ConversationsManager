using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// DataDeserializationException class.
    /// </summary>
    public class DataDeserializationException : BaseException
    {
        #region Constants

        /// <summary>
        /// DataDeserializationException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Unable to deserialize data.";

        /// <summary>
        /// DataDeserializationException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default DataDeserializationException constructor.
        /// </summary>
        public DataDeserializationException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
