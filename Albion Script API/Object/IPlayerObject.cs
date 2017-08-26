using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents a player within the game world.
	/// </summary>
	public interface IPlayerObject : IEntityObject
    {
        /// <summary>
        /// Retrieves this player's guid.
        /// </summary>
        /// <value>This player's guid.</value>
        Guid Guid { get; }

        /// <summary>
        /// Retrieves whether or not this player has pvp enabled.
        /// </summary>
        /// <value><c>true</c> if this player has pvp enabled; otherwise, <c>false</c>.</value>
        bool IsPvpEnabled { get; }

        /// <summary>
        /// Retrieves whether or not this player is on a mount.
        /// </summary>
        /// <value><c>true</c> if this player is mounted; otherwise, <c>false</c>.</value>
        bool IsMounted { get; }

        /// <summary>
        /// Retrieves the name of the guild that this player is in.
        /// </summary>
        /// <value>The guild that this player is in.</value>
        string Guild { get; }

        /// <summary>
        /// Retrieves the tag for the guild that this player is in.
        /// </summary>
        /// <value>The tag for the guild that this player is in.</value>
        string GuildTag { get; }
    }
}
