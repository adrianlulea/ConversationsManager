using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// DuplicateReplyParentException class.
    /// </summary>
    [Serializable]
    public class DuplicateReplyParentException : BaseException
    {
        #region Constants

        /// <summary>
        /// DuplicateReplyParentException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Parent already in list of parents.";

        /// <summary>
        /// DuplicateReplyParentException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default DuplicateReplyParentException constructor.
        /// </summary>
        public DuplicateReplyParentException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
