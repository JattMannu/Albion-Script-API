using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Represents a set of static utilities for reading collision data from the game.
	/// </summary>
    public interface ICollision : IApiModule
    {
        /// <summary>
		/// Converts the provided 3d coordinates to a location on the collision grid
		/// </summary>
		/// <returns>The location that the 3d coordinates are on the collision grid.</returns>
		/// <param name="x">The x coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		Vector2<int> LocToGrid(float x, float z);

        /// <summary>
        /// Converts the provided grid location to 3d coordinates.
        /// </summary>
        /// <returns>The location that the collision grid tile is in 3d coordinates.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="center">If the returned coordinates will be in the center of the collision grid tile.</param>
        Vector3<float> GridToLoc(int x, int y, bool center);

        /// <summary>
        /// Determines whether or not there is a clear path from start to end.
        /// </summary>
        /// <returns>If a path is clear.</returns>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        bool IsStraightPathClear(Vector2<int> start, Vector2<int> end);

        /// <summary>
        /// Determines whether or not there is a clear path from start to end.
        /// </summary>
        /// <returns>If a path is clear.</returns>
        /// <param name="flags">The clipping flags.</param>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        bool IsStraightPathClear(bool[,] flags, Vector2<int> start, Vector2<int> end);
    }
}
