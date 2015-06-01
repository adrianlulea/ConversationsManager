using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// ReplyCircularDependencyException class.
    /// </summary>
    public class ReplyCircularDependencyException : BaseException
    {
        #region Constants

        /// <summary>
        /// ReplyCircularDependencyException text.
        /// </summary>
        private const string EXCEPTION_TEXT = "Illegal circular dependency.";

        /// <summary>
        /// ReplyCircularDependencyException severity.
        /// </summary>
        private const ExceptionSeverity EXCEPTION_SEVERITY = ExceptionSeverity.Error;

        #endregion

        #region Constructors

        /// <summary>
        /// Default ReplyCircularDependencyException constructor.
        /// </summary>
        public ReplyCircularDependencyException()
            : base(EXCEPTION_TEXT, EXCEPTION_SEVERITY)
        {

        }

        #endregion
    }
}
