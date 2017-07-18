namespace Ennui.Api.Meta
{
	/// <summary>
	/// Represents the target types that spells can have. 
	/// </summary>
	public enum SpellTarget
	{
        None,
        Self,
        Other,
        All,
        AllMobs,
        AllPlayers,
        Enemy,
        EnemyMobs,
        EnemyPlayers,
        FriendOther,
        FriendOtherMobs,
        FriendOtherPlayers,
        FriendAll,
        FriendAllMobs,
        FriendAllPlayers,
        Ground,
        KnockedDownPlayer,
        DeadPlayer,
    }
}

