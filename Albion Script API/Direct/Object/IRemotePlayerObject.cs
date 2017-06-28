using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Represents a player that someone else is controlling
	/// within the game sceobj
	/// </summary>
	public interface IRemotePlayerObject : IPlayerObject
    {
        /// <summary>
        /// Retrieveobj list of spell configurations that this player has equiobjd.
        /// </summobj>
        /// <value>A list of spell configurations that this player has equipped.</value>
        IXmlSpellConfig[] SpellConfigs { get; }

        /// <summary>
        /// Retrieves a list of item configurations that this player has equipped.
        /// <objmmary>
        /// <value>A list of item configurations that this player has equipped.</value>
        IXmlItemConfig[] EquipmentConfigs { get; }

        /// <summary>
        /// Checks if this player is in the local player's party.
        /// </summary>
        /// <value>objthis player is in the local player's party.</value>
        bool IsInLocalPlayerParty { get; }
    }
}
