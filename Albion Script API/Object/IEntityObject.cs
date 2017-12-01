using System;
using System.Collections.Generic;

using Ennui.Api.Filter;
using Ennui.Api.Meta;
using Ennui.Api.Util;
using Ennui.Api.Config;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Instanceresents an entity in the game scene.
	/// </summary>
	public interface IEntityObject : IMovingObject
    {
        /// <summary>
        /// This entity's name.
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// This entity's current health.
        /// </summary>
        float CurrentHealth { get; }
        
        /// <summary>
        /// This entity's max health.
        /// </summary>
        float MaxHealth { get; }

        /// <summary>
        /// This entity's health percentage.
        /// </summary>
        float HealthPercentage { get; }

        /// <summary>
        /// This entity's current energy.
        /// </summary>
        float CurrentEnergy { get; }
        
        /// <summary>
        /// This entity's max energy.
        /// </summary>
        float MaxEnergy { get; }
        
        /// <summary>
        /// This entity's energy percentage.
        /// </summary>
        float EnergyPercentage { get; }

        /// <summary>
        /// This entity's max load.
        /// </summary>
        float MaxCarryWeight { get; }
        
        /// <summary>
        /// This entity's movement speed.
        /// </summary>
        float MovementSpeed { get; }

        /// <summary>
        /// This entity's current action state.
        /// </summary>
        ActionState CurrentActionState { get; }

        /// <summary>
        /// <c>true</c> if this entity is harvesting; otherwise, <c>false</c>.
        /// </summary>
        bool IsHarvesting { get; }

        /// <summary>
        /// This entity's movement state.
        /// </summary>
        MovementState CurrentMovementState { get; }

        /// <summary>
        /// <c>true</c> if this entity is moving; otherwise, <c>false</c>.
        /// </summary>
        bool IsMoving { get; }
        
        /// <summary>
        /// The list of effects currently applied to this entity.
        /// </summary>
        List<IActiveSpell> Effects { get; }

        /// <summary>
        /// A chain containing all of this entity's applied effects.
        /// </summary>
        ActiveSpellFilterChain EffectChain { get; }

        /// <summary>
        /// The unique id of the entity that this entity has targeted.
        /// </summary>
        long AttackTargetId { get; }
        
        /// <summary>
        /// The entity that this entity has targeted.
        /// </summary>
        IEntityObject AttackTarget { get; }
        
        /// <summary>
        /// <c>true</c> if this entity is under attack; otherwise, <c>false</c>.
        /// </summary>
        bool IsUnderAttack { get; }
        
        /// <summary>
        /// A list of entities that are attacking this entity.
        /// </summary>
        List<IEntityObject> UnderAttackBy { get; }

        /// <summary>
        /// Checks if this entity can cast the spell in the provided slot.
        /// </summary>
        /// <returns><c>true</c>, if the spell is ready to cast, <c>false</c> otherwise.</returns>
        /// <param name="slot">Slot.</param>
        bool IsReadyToCast(CharacterSpellSlot slot);

        /// <summary>
        /// The last known position.
        /// </summary>
        Vector3<float> LastKnownPosition { get; }

        /// <summary>
        /// This entity's config.
        /// </summary>
        IEntityConfig EntityConfig { get; }
    }
}
