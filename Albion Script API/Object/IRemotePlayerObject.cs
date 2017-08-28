using Ennui.Api.Xml;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents a player that someone else is controlling
	/// within the game sceobj
	/// </summary>
	public interface IRemotePlayerObject : IPlayerObject
    {
        /// <summary>
        /// A list of spell configurations that this player has equiobjd.
        /// </summobj>
        IXmlSpellConfig[] SpellConfigs { get; }

        /// <summary>
        /// A list of item configurations that this player has equipped.
        /// <objmmary>
        IXmlItemConfig[] EquipmentConfigs { get; }

        /// <summary>
        /// If this player is in the local player's party.
        /// </summary
        bool IsInLocalPlayerParty { get; }

        /// <summary>
        /// If this player is potentially dangerous to the local player or not.
        /// </summary>
        bool IsDangerous { get; }
    }
}
