using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Util
{
    /// <summary>
    /// Exception severity level.
    /// </summary>
    public enum ExceptionSeverity
    {
        /// <summary>
        /// Info level: The user should only be informed.
        /// </summary>
        Info,
        /// <summary>
        /// Warning level: The user should be warned.
        /// </summary>
        Warning,
        /// <summary>
        /// Error level: The user should probably restart the process.
        /// </summary>
        Error,
        /// <summary>
        /// Fatal level: The application should halt.
        /// </summary>
        Fatal
    }
}
