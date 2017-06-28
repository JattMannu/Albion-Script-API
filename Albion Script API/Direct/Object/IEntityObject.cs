using Ennui.Api.Builder;
using Ennui.Api.Direct.View;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Instanceresents an entity in the game scene.
	/// </summary>
	public interface IEntityObject : IMovingObject
    {
        /// <summary>
        /// Retrieves this entity's view.
        /// </summary>
        /// <value>This entity's view.</value>
        IEntityObjectView EntityView { get; }

        /// <summary>
        /// Retrieves this entity's name.
        /// </summary>
        /// <value>This entity's name.</value>
        string Name { get; }

        ITimestampProperty HealthProperty { get; }

        /// <summary>
        /// Retrieves this entity's current health.
        /// </summary>
        /// <value>This entity's current health.</value>
        float CurrentHealth { get; }

        /// <summary>
        /// Retrieves this entity's maximum health.
        /// </summary>
        /// <value>This entity's max health.</value>
        float MaxHealth { get; }

        /// <summary>
        /// Retrieve's this entity's current health percentage.
        /// </summary>
        /// <value>This entity's health percentage.</value>
        float HealthPercentage { get; }

        ITimestampProperty EnergyProperty { get; }

        /// <summary>
        /// Retrieves this entity's current energy.
        /// </summary>
        /// <value>This entity's current energy.</value>
        float CurrentEnergy { get; }

        /// <summary>
        /// Retrieves this entity's maximum energy.
        /// </summary>
        /// <value>This entity's max energy.</value>
        float MaxEnergy { get; }

        /// <summary>
        /// Retrieves this entity's maximum load
        /// </summary>
        /// <value>This entity's max load.</value>
        float MaxCarryWeight { get; }

        /// <summary>
        /// Retrieves this entity's movement speed.
        /// </summary>
        /// <value>This entity's movement speed.</value>
        float MovementSpeed { get; }

        IStateQueue ActionStateQueue { get; }

        /// <summary>
        /// Retrieves this entity's current action state.
        /// </summary>
        /// <value>This entity's current action state.</value>
        ActionState CurrentActionState { get; }

        /// <summary>
        /// Checks if this entity is currently harvesting anything.
        /// </summary>
        /// <value><c>true</c> if this entity is harvesting; otherwise, <c>false</c>.</value>
        bool IsHarvesting { get; }

        IStateQueue MovementStateQueue { get; }

        /// <summary>
        /// Retrieves this entity's movement state.
        /// </summary>
        /// <value>This entity's movement state.</value>
        MovementState CurrentMovementState { get; }

        /// <summary>
        /// Checks if this entity is currently moving
        /// </summary>
        /// <value><c>true</c> if this entity is moving; otherwise, <c>false</c>.</value>
        bool IsMoving { get; }

        IEffectApplicator EffectApplicator { get; }

        /// <summary>
        /// Retrieves the list of effects currently applied to this entity.
        /// </summary>
        /// <value>The list of effects currently applied to this entity.</value>
        List<IActiveSpell> Effects { get; }

        ActiveSpellFilterChain EffectChain { get; }

        /// <summary>
        /// Retrieves the unique id of the entity that this entity has targeted.
        /// </summary>
        /// <value>The unique id of the entity that this entity has targeted.</value>
        long AttackTargetId { get; }

        /// <summary>
        /// Retrieves the entity that this entity has targeted.
        /// </summary>
        /// <value>The entity that this entity has targeted.</value>
        IEntityObject AttackTarget { get; }

        /// <summary>
        /// Checks if this entity is under attack by another entity.
        /// </summary>
        /// <value><c>true</c> if this entity is under attack; otherwise, <c>false</c>.</value>
        bool IsUnderAttack { get; }

        /// <summary>
        /// Retrieves a list of entities that are attacking this entity.
        /// </summary>
        /// <value>A list of entities that are attacking this entity.</value>
        List<IEntityObject> UnderAttackBy { get; }

        /// <summary>
        /// Retrieves the event handler of the provided type.
        /// </summary>
        /// <returns>The event handler of the provided type.</returns>
        /// <param name="t">The type of the event handler to grab.</param>
        object GetEventHandler(Type t);

        /// <summary>
        /// Retrieves the event handler that handles spell casting for this entity.
        /// </summary>
        /// <value>The event handler that handles spell casting for this entity.</value>
        ICastSpellEventHandler CastSpellEventHandler { get; }

        IPlaceItemEventHandler PlaceItemEventHandler { get; }

        /// <summary>
        /// Checks if this entity can cast the spell in the provided slot.
        /// </summary>
        /// <returns><c>true</c>, if the spell is ready to cast, <c>false</c> otherwise.</returns>
        /// <param name="slot">Slot.</param>
        bool IsReadyToCast(CharacterSpellSlot slot);

        /// <summary>
        /// Gets or sets the last known position for this entity. 
        /// 
        /// This value is where the server had us pinpointed in the scene on the last update. By changing this, and forcing
        /// a movement update, we can actually teleport.
        /// </summary>
        /// <value>The last known position.</value>
        Vector3<float> LastKnownPosition { get; }

        /// <summary>
        /// Retrieves this entity's internal xml config object.
        /// </summary>
        /// <value>This entity's internal xml config object.</value>
        object XmlConfig { get; }
    }
}
