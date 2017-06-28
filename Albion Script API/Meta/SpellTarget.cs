namespace Ennui.Api.Meta
{
	/// <summary>
	/// Represents the target types that spells can have. 
	/// </summary>
	public enum SpellTarget
	{
		/// <summary>
		/// Represents a spell that can not target anything.
		/// </summary>
		None,
		/// <summary>
		/// Represents a spell that targets the local player.
		/// </summary>
		Self,
		/// <summary>
		/// Represents a spell that targets.. something.
		/// </summary>
		Other,
		/// <summary>
		/// Represents a spell that can target anything.
		/// </summary>
		All,
		/// <summary>
		/// Represents a spell that can target all mobs.
		/// </summary>
		AllMobs,
		/// <summary>
		/// Represents a spell that can target all players.
		/// </summary>
		AllPlayers,
		/// <summary>
		/// Represents a spell taht can target enemies.
		/// </summary>
		Enemy,
		/// <summary>
		/// Represents a spell that can target enemy mobs.
		/// </summary>
		EnemyMobs,
		/// <summary>
		/// Represents a spell that can target enemy players.
		/// </summary>
		EnemyPlayers,
		/// <summary>
		/// Represents a spell that can target.. some friends?
		/// </summary>
		FriendOther,
		/// <summary>
		/// Represents a spell that can target other friendly mobs
		/// </summary>
		FriendOtherMobs,
		/// <summary>
		/// Represents a spell that can target other friendly players
		/// </summary>
		FriendOtherPlayers,
		/// <summary>
		/// Represents a spell that can target all friends
		/// </summary>
		FriendAll,
		/// <summary>
		/// Represents a spell that can target all friendly mobs.
		/// </summary>
		FriendAllMobs,
		/// <summary>
		/// Represents a spell that can target all friendly players.
		/// </summary>
		FriendAllPlayers,
		/// <summary>
		/// Represents a spell that can target the ground (aoe?)
		/// </summary>
		Ground,
		/// <summary>
		/// Represents a spell that can target a knocked down player.
		/// </summary>
		KnockedDownPlayer,
		/// <summary>
		/// Represents a spell that can target dead players.
		/// </summary>
		DeadPlayer
	}
}

