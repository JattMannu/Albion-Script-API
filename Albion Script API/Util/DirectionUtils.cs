using System.Collections;
using System.Collections.Generic;

namespace Ennui.Api.Util
{
    /// <summary>
	/// Provides a set of static utilities that are too inspecific for their own utility classes.
	/// </summary>
    public class DirectionUtils
    {
        /// <summary>
        /// Represents a direction.
        /// </summary>
        public enum Direction
        {
            /// <summary>
            /// A direction pointing north.
            /// </summary>
            North = 0,
            /// <summary>
            /// A direction pointing north east.
            /// </summary>
            NorthEast,
            /// <summary>
            /// A direction pointing east.
            /// </summary>
            East,
            /// <summary>
            /// A direction pointing south east.
            /// </summary>
            SouthEast,
            /// <summary>
            /// A direction pointing south.
            /// </summary>
            South,
            /// <summary>
            /// A direction pointing south west.
            /// </summary>
            SouthWest,
            /// <summary>
            /// A direction pointing west.
            /// </summary>
            West,
            /// <summary>
            /// A direction pointing north west.
            /// </summary>
            NorthWest,
            /// <summary>
            /// None! No direction at all.
            /// </summary>
            None,
        }
        
        /// <summary>
        /// Calculates the direction between the first coordinates, and the second ones.
        /// </summary>
        /// <returns>The <see cref="DirectionUtils"/> between the two points.</returns>
        /// <param name="x0">The x coordinate of the first point.</param>
        /// <param name="y0">The y coordinate of the first point.</param>
        /// <param name="x1">The x coordinate of the second point.</param>
        /// <param name="y1">The y coordinate of the second point.</param>
        public static Direction DirectionBetween(int x0, int y0, int x1, int y1)
        {
            int xDiff = x1 - x0;
            int yDiff = y1 - y0;
            if (xDiff == 0)
            {
                if (yDiff == 0) return Direction.None;
                else if (yDiff > 0) return Direction.North;
                else if (yDiff < 0) return Direction.South;
            }
            else if (yDiff == 0)
            {
                if (xDiff == 0) return Direction.None;
                else if (xDiff > 0) return Direction.East;
                else if (xDiff < 0) return Direction.West;
            }
            else
            {
                if (xDiff > 0 && yDiff > 0) return Direction.NorthEast;
                else if (xDiff > 0 && yDiff < 0) return Direction.SouthEast;
                else if (xDiff < 0 && yDiff > 0) return Direction.NorthWest;
                else if (xDiff < 0 && yDiff < 0) return Direction.SouthWest;
            }
            return Direction.None;
        }

        /// <summary>
        /// Calculates the direction between the first coordinates, and the second ones.
        /// </summary>
        /// <returns>The <see cref="DirectionUtils"/> between the two points.</returns>
        /// <param name="x0">The x coordinate of the first point.</param>
        /// <param name="y0">The y coordinate of the first point.</param>
        /// <param name="x1">The x coordinate of the second point.</param>
        /// <param name="y1">The y coordinate of the second point.</param>
        public static Direction DirectionBetween(float x0, float y0, float x1, float y1)
        {
            var xDiff = x1 - x0;
            var yDiff = y1 - y0;
            if (xDiff.NearlyEquals(0.0f))
            {
                if (yDiff == 0) return Direction.None;
                else if (yDiff > 0) return Direction.North;
                else if (yDiff < 0) return Direction.South;
            }
            else if (yDiff.NearlyEquals(0.0f))
            {
                if (xDiff.NearlyEquals(0.0f)) return Direction.None;
                else if (xDiff > 0) return Direction.East;
                else if (xDiff < 0) return Direction.West;
            }
            else
            {
                if (xDiff > 0 && yDiff > 0) return Direction.NorthEast;
                else if (xDiff > 0 && yDiff < 0) return Direction.SouthEast;
                else if (xDiff < 0 && yDiff > 0) return Direction.NorthWest;
                else if (xDiff < 0 && yDiff < 0) return Direction.SouthWest;
            }
            return Direction.None;
        }
    }
}
