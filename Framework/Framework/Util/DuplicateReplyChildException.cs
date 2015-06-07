using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// DuplicateReplyChildException class.
    /// </summary>
    [Serializable]
    public class DuplicateReplyChildException : BaseException
    {
        #region Constants

        /// <summary>
        /// DuplicateReplyChildException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Child already in list of children.";

        /// <summary>
        /// DuplicateReplyChildException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default DuplicateReplyChildException constructor.
        /// </summary>
        public DuplicateReplyChildException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
