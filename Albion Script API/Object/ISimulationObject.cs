using System;

using Ennui.Api.Util;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents an object in the game scene. All objects derive from this.
	/// </summary>
	public interface ISimulationObject : IApiResource, Locatable
    {

        /// <summary>
        /// This simulation object's unique id within the scene.
        /// </summary>
        long ObjectId { get; }

        /// <summary>
        /// The unique of this object's view.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// If this object is valid for use.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// The location that this object is on within the game's collision grid.
        /// </summary>
        Vector2<int> GridLocation { get; }

        /// <summary>
        /// This object's 3d position within the scene.
        /// </summary>
        [Obsolete("Use Locatable#Location instead")]
        Vector3<float> ThreadSafeLocation { get; }

        /// <summary>
        /// The screen position of this object, or null if it's not on the screen.
        /// </summary>
        Vector2<float> ScreenLocation { get; }

        /// <summary>
        /// Tells the local player to attack this object.
        /// </summary>
        bool Attack();
    }

}