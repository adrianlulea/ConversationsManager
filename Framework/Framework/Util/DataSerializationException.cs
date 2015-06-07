using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// DataSerializationException class.
    /// </summary>
    [Serializable]
    public class DataSerializationException : BaseException
    {
        #region Constants

        /// <summary>
        /// DataSerializationException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Unable to serialize data.";

        /// <summary>
        /// DataSerializationException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default DataSerializationException constructor.
        /// </summary>
        public DataSerializationException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
