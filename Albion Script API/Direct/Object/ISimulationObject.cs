using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Represents an object in the game scene. All objects derive from this.
	/// </summary>
	public interface ISimulationObject : IApiResource, Locatable
    {
        /// <summary>
        /// Gets this simulation object's view.
        /// </summary>
        /// <value>This simulation object's view.</value>
        ISimulationObjectView SimulationView { get; }

        /// <summary>
        /// Gets this simulation object's unique id within the scene.
        /// </summary>
        long ObjectId { get; }

        /// <summary>
        /// Gets the unique id of this object's view.
        /// </summary>
        /// <value>The unique of this object's view.</value>
        long Id { get; }

        /// <summary>
        /// Tests if this object is valid for use.
        /// </summary>
        /// <value>If this object is valid for use.</value>
        bool IsValid { get; }

        /// <summary>
        /// Calculates the location that this object is on within
        /// the game's collision grid.
        /// </summary>
        /// <value>The location that this object is on within the game's collision grid.</value>
        Vector2<int> GridLocation { get; }

        /// <summary>
        /// Retrieve's this object's 3d position within the scene.
        /// </summary>
        /// <value>This object's 3d position within the scene.</value>
        Vector3<float> ThreadSafeLocation { get; }

        /// <summary>
        /// Calculates this object's position on the game screen.
        /// </summary>
        /// <value>The screen position of this object, or null if it's not on the screen.</value>
        Vector2<float> ScreenLocation { get; }

        /// <summary>
        /// Tells the local player to attack this object.
        /// </summary>
        bool Attack();
    }

}