using Ennui.Api.Direct.View;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Represents a utility class that handles input from the local player.
	/// </summary>
	public interface ILocalInputHandler
    {
        /// <summary>
        /// Gets or sets the selected object identifier.
        /// </summary>
        /// <value>The selected object identifier.</value>
        long SelectedObjectId
        {
            get;
            set;
        }

        /// <summary>
        /// Attacks the target that the local player currently has selected.
        /// </summary>
        void AttackCurrentTarget();

        /// <summary>
        /// Queues a move action for the local player.
        /// </summary>
        /// <param name="pos">The position to move to.</param>
        void DoMoveClicked(Vector3<float> pos);

        /// <summary>
        /// Queues an interact action for the local player.
        /// </summary>
        /// <param name="view">The view to interact with.</param>
        /// <param name="collider">The name of the collider the player clicked on.</param>
        void DoObjectViewClicked(IWorldObjectView view, string collider);

        /// <summary>
        /// Queues an interact action for the local player using no collider.
        /// </summary>
        /// <param name="view">The view to interact with.</param>
        void DoObjectViewClicked(IWorldObjectView view);

        /// <summary>
        /// Casts a spell on the local player.
        /// </summary>
        /// <param name="slot">The slot of the spell to cast.</param>
        void CastOnSelf(CharacterSpellSlot slot);

        /// <summary>
        /// Casts a spell on another entity.
        /// </summary>
        /// <param name="slot">The slot of the spell to cast.</param>
        /// <param name="view">The view to cast the spell on.</param>
        void CastOn(CharacterSpellSlot slot, IEntityObjectView view);

        /// <summary>
        /// Casts a spell at a position within the 3d scene.
        /// </summary>
        /// <param name="slot">The slot of the spell to cast.</param>
        /// <param name="pos">The position to cast the spell at.</param>
        void CastAt(CharacterSpellSlot slot, Vector3<float> pos);

        void UpdateQueuedAction();
    }
}