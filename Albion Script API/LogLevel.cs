using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Represents different levels of logging used by the bot.
	/// </summary>
	public enum LogLevel
    {
        /// <summary>
        /// Represents the lowest level of tracing. Use for tracking execution n stuff.
        /// </summary>
        Atom = 0,
        /// <summary>
        /// Represents the second lowest level of tracing. Used for printing the most miniscule of details.
        /// </summary>
        Trace = 1,
        /// <summary>
        /// Represents an informitive level of logging. Not particularly useful, but informative.
        /// </summary>
        Info = 2,
        /// <summary>
        /// Represents a worisome level of logging. This indiciates a potential, not software breaking, issue.
        /// </summary>
        Warning = 3,
        /// <summary>
        /// Represents the highest level of logging. You should always hear what these messages have to say. Your software is blowing the fuck up afterall.
        /// </summary>
        Error = 4,
    }
}
