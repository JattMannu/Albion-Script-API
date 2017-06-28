namespace Ennui.Api.Meta
{
	/// <summary>
	/// Each spell in the game is tied to an equipment slot. This describes each slot.
	/// </summary>
	public enum CharacterSpellSlot : short
	{
		/// <summary>
		/// Represents the spell in the main hand weapon 1 slot.
		/// </summary>
		MainHand1,
		/// <summary>
		/// Represents the spell in the main hand weapon 2 slot.
		/// </summary>
		MainHand2,
		/// <summary>
		/// Represents the spell in the off hand weapon 1 slot.
		/// </summary>
		OffHandOrMainHand3,
		/// <summary>
		/// Represents the spell in the armor slot.
		/// </summary>
		Armor,
		/// <summary>
		/// Represents the spell in the head slot.
		/// </summary>
		Head,
		/// <summary>
		/// Represents the spell in the shoes slot.
		/// </summary>
		Shoes,
		/// <summary>
		/// Represents the spell in the potion slot.
		/// </summary>
		Potion,
		/// <summary>
		/// Represents the spell in the food slot.
		/// </summary>
		Food,
		/// <summary>
		/// Represents the spell in the mount slot.
		/// </summary>
		Mount,
		/// <summary>
		/// Represents the spell in the escape dungeon slot...?
		/// </summary>
		EscapeDungeon,
		/// <summary>
		/// Represents the spell in the change pvp stance slot.
		/// </summary>
		ChangePvpStance,
		/// <summary>
		/// Represents the spell in the coup de grace slot.
		/// </summary>
		CoupDeGrace,
		/// <summary>
		/// Represents the number of spell slots.
		/// </summary>
		NumEntries,
		/// <summary>
		/// Represents an invalid spell slot.
		/// </summary>
		Invalid = -1
	}
}

