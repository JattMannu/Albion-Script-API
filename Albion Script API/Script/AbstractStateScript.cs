using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Script
{
    /// <summary>
	/// Represents a script implementation that has individual, clearly defined states.
	/// </summary>
	public abstract class AbstractStateScript : AbstractScript
    {
        /// <summary>
        /// Switches to a different state.
        /// </summary>
        /// <param name="key">The key of the script to enter.</param>
        public abstract void EnterState(string key);

        /// <summary>
        /// Switches to a different state.
        /// </summary>
        /// <param name="script">The script to enter.</param>
        public abstract void EnterState(StateScript script);
    }
}
