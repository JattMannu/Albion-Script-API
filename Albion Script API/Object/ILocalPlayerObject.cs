using Ennui.Api.Filter;
using Ennui.Api.Meta;
using Ennui.Api.Util;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents the local player in the scene.
	/// </summary>
	public interface ILocalPlayerObject : IPlayerObject
    {
        /// <summary>
        /// Attempts to attack the target that we have selected.
        /// </summary>
        /// <returns><c>true</c>, if the selected object was attacked, <c>false</c> otherwise.</returns>
        bool AttackSelectedObject();

        /// <summary>
        /// Sets our selected target to the provided one.
        /// </summary>
        /// <returns><c>true</c>, if the object was successfully selected, <c>false</c> otherwise.</returns>obj	/// <param name="obj">The object to select.</param>
        bool SetSelectedObject(ISimulationObject obj);

        /// <summary>
        /// Changes the name of this local playeobj
        /// </summary>
        /// <param name="name">The new name to assign to this local player.</param>
        void SetName(string name);

        /// <summary>
        /// Retrieves all of the local player's Spells.
        /// </summary>
        /// <summary>Thobjocal player's Spells.</value>
        ISpell[] Spells { get; }

        /// <summary>
        /// Retrieves the Spell in the provided slot.
        /// </summary>
        /// <returns>The Spell within the provided slot.</returns>
        /// <param name="slot">The slot to grab the Spell from.</param>
        ISpell SpellInSlot(CharacterSpellSlot slot);

        /// <summary>
        /// Constructs a chain containing all Spells belonging to the local player.
        /// </summary>
        /// <value>A chain containing all Spells belonging to the local player.</value>
        SpellFilterChain SpellChain { get; }

        /// <summary>
        /// Gets this player's current crafting focus.
        /// </summary>
        /// <value>This player's current crafting focus.</value>
        float CurrentCraftingFocus { get; }

        /// <summary>
        /// Gets this player's maximum crafting focus.
        /// </summary>
        /// <value>This player's maximum crafting focus.</value>
        float MaxCraftingFocus { get; }

        /// <summary>
        /// Calculates the amount of damage that this local player deals.
        /// </summary>
        /// <value>The amount of damage that this local player deals.</value>
        float Damage { get; }

        /// <summary>
        /// Gets the item container for this player's inventory.
        /// </summary>
        /// <value>The item container for this player's inventory.</value>
        IItemContainerProxy InventoryContainer { get; }

        /// <summary>
        /// Gets the item container for this player's equipment.
        /// </summary>
        /// <value>The item container for this player's equipment.</value>
        IItemContainerProxy EquipmentContainer { get; }

        /// <summary>
        /// Attempts to cast a spell on this local player.
        /// </summary>
        /// <returns><c>true</c>, if the Spell was successfully casted, <c>false</c> otherwise.</returns>
        /// <param name="slot">The slot of the Spell that we wanted to cast.</param>
        bool CastOnSelf(CharacterSpellSlot slot);

        /// <summary>
        /// Attempts to cast a spell on the provided entity.
        /// </summary>
        /// <returns><c>true</c>, if the Spell was successfully cast, <c>false</c> otherwise.</returns>
        /// <param name="slot">The slot of the Spell to cast.</param>
        /// <param name="obj">The entity to cast the spell on.</param>
        bool CastOn(CharacterSpellSlot slot, IEntityObject obj);

        /// <summary>
        /// Attempts to cast a spell at the provided location.
        /// </summary>
        /// <returns><c>true</c>, if the Spell was successfully cast, <c>false</c> otherwise.</returns>
        /// <param name="slot">The slot of the Spell to cast.</param>
        /// <param name="pos">The position to cast the spell at.</param>
        bool CastAt(CharacterSpellSlot slot, Vector3<float> pos);

        /// <summary>
        /// Toggles whether this local player is on a mount or not, and waits for the mount to complete.
        /// </summary>
        /// <returns><c>true</c>, if mounting was successfully toggled, <c>false</c> otherwise.</returns>
        bool ToggleMount();

        /// <summary>
        /// Toggles the mount to on or off.
        /// </summary>
        /// <returns><c>true</c>, if mounting was successfully toggled, <c>false</c> otherwise.</returns>
        /// <param name="enabled">Whether to mount or unmount.</param>
        bool ToggleMount(bool enabled);

        /// <summary>
        /// Attempts to mount the provided mount.
        /// </summary>
        /// <returns><c>true</c>, if mounting was successful.</returns>
        /// <param name="mount">The mount to mount.</param>
        bool Mount(IMountObject mount);

        /// <summary>
        /// Calculates the weight that this local player is currently holding.
        /// </summary>
        /// <value>The weight that this local player is currently holding..</value>
        float TotalHoldWeight { get; }

        /// <summary>
        /// Calculates the percentage from the max load (not max, but it reduces movement speed),
        /// that this local player is.
        /// </summary>
        /// <value>The percentage from the max load that this local player is.</value>
        float WeighedDownPercent { get; }

        /// <summary>
        /// Gets or sets this local player's current move destination.
        /// </summary>
        /// <value>This local player's current move destination.</value>
        Vector3<float> MoveDestination { get; set; }

        /// <summary>
        /// The location of the bobber when fishing.
        /// </summary>
        Vector2<float> BobberLocation { get; }

        /// <summary>
        /// The local player's current fishing state.
        /// </summary>
        FishingState FishingState { get; }

        /// <summary>
        /// Begins fishing at the provided coordinates.
        /// </summary>
        /// <param name="scenePos">The scene position to start fishing at.</param>
        void BeginFishing(Vector2<float> scenePos);

        /// <summary>
        /// Reels in the fish immediately if a fishing minigame is occuring.
        /// </summary>
        /// <param name="success">If the reel was a success or not.</param>
        void ReelIn(bool success);
    }
}
