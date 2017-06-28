using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides utilities for interfacing with the internals of the bot.
	/// </summary>
    public interface IBot : IApiModule
    {
        /// <summary>
		/// Loads the graphs from the provided json file.
		/// </summary>
		/// <param name="data">The json data to load.</param>
		void LoadGraph(string data);

        /// <summary>
        /// Loads graph meta data by parsing the available information provided to us
        /// by the game itself. 
        /// 
        /// Things like the actual web must be hand made.
        /// </summary>
        void LoadGraphMeta();

        /// <summary>
        /// Reloads The Web (tm) from disk. This will undo any runtime changes.
        /// </summary>
        void LoadGraphs();
    }
}
