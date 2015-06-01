using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// FrameworkExceptionClass class.
    /// </summary>
    public class FrameworkExceptionClass : BaseException
    {
        #region Constants

        /// <summary>
        /// FrameworkExceptionClass text.
        /// </summary>
        private const string EXCEPTION_TEXT = "FrameworkExceptionClassText";

        /// <summary>
        /// FrameworkExceptionClass severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default FrameworkExceptionClass constructor.
        /// </summary>
        public FrameworkExceptionClass()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
