using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for intertacting with in game hotkeys.
	/// </summary>
    public interface IHotkeys : IApiModule
    {
        /// <summary>
		/// Removes all hotkeys from the manager, and preserves them in a dictionary.
		/// </summary>
		bool Unhook();

        /// <summary>
        /// Removes all hotkeys from the preserve dictionary, and adds them back to the
        /// hotkey manager.
        /// </summary>
        bool Rehook();
    }
}
