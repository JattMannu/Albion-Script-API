using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for logging.
	/// </summary>
	public interface ILogging : IApiModule
    {
        /// <summary>
        /// Logs the specified text to the debug output of the operating system.
        /// </summary>
        /// <param name="message">The text to log.</param>
        /// <param name="level">The level to log the message at.</param> 
        void Log(string message, LogLevel level = LogLevel.Trace);
    }
}
