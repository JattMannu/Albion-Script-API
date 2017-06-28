using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Contains information about a specific character tied to an account (on the character selection screen.)
	/// <see cref="ICharacterSelectWindow"/>
	/// </summary>
	public interface ICharacterRecord
    {
        int Index { get; }

        /// <summary>
        /// Retrieves the name of the character.
        /// </summary>
        /// <value>The name of the character.</value>
        string Name { get; }

        /// <summary>
        /// Retrieves the name of the cluster that the character is in.
        /// </summary>
        /// <value>The name of the cluster that the character is in.</value>
        string ClusterName { get; }
    }
}
