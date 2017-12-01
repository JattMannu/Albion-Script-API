namespace Ennui.Api.Meta
{
	/// <summary>
	/// Represents the possible action states that an entity can perform.
	/// </summary>
	public enum ActionState
	{
		/// <summary>
		/// Represents an entity doing no action.
		/// </summary>
		Idle = 0,
		/// <summary>
		/// Represents an entity attacking.
		/// </summary>
		Attacking = 2,
		/// <summary>
		/// Represents an entity casting a spell.
		/// </summary>
		Casting = 3,
		/// <summary>
		/// Represents an entity channeling.
		/// </summary>
		Channeling = 4,
		/// <summary>
		/// Represents an entity attacking a building.
		/// </summary>
		AttackingBuilding = 8,
		/// <summary>
		/// Represents an entity claiming an orb.
		/// </summary>
		OrbClaiming = 9,
		/// <summary>
		/// Represents an entity entering an exit.
		/// </summary>
		EnteringExit = 10,
		/// <summary>
		/// Represents an entity harvesting a resource.
		/// </summary>
		Harvesting = 11,
		/// <summary>
		/// Represents an entity repairing.
		/// </summary>
		Repairing = 12,
		/// <summary>
		/// Represents an entity installing a resource.
		/// </summary>
		InstallingResource = 14,
		/// <summary>
		/// Represents an entity placing a placeable object.
		/// </summary>
		PlacingPlaceable = 15,
        /// <summary>
        /// Represents an entity that's knocked down on the ground.
        /// </summary>
        KnockedDown = 17,
		/// <summary>
		/// Represents an entity using a mount.
		/// </summary>
		Mounting = 21,
		/// <summary>
		/// Represents an entity using a treasure chest.
		/// </summary>
		UsingTreasureChest = 24,
	}
}

