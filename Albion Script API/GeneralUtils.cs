using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Provides a set of static utilities that are too inspecific for their own utility classes.
	/// </summary>
    public class GeneralUtils
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
        /// Casts the provided dictionary to a generic dictionary with the provided types.
        /// </summary>
        /// <param name="dictionary">The dictionary to cast from.</param>
        /// <typeparam name="K">The dictionary key type.</typeparam>
        /// <typeparam name="V">The dictionary value type.</typeparam>
        public static Dictionary<K, V> Cast<K, V>(IDictionary dictionary)
        {
            var casted = new Dictionary<K, V>();
            foreach (DictionaryEntry entry in dictionary)
            {
                casted.Add((K)entry.Key, (V)entry.Value);
            }
            return casted;
        }

        /// <summary>
        /// Casts the provided list to a generic list with the provided type.
        /// </summary>
        /// <param name="list">The list to cast from.</param>
        /// <typeparam name="K">The element type.</typeparam>
        public static List<K> Cast<K>(IList list)
        {
            var casted = new List<K>();
            foreach (var obj in list)
            {
                casted.Add((K)obj);
            }
            return casted;
        }

        /// <summary>
        /// Checks if any of the provided objects are null.
        /// </summary>
        /// <returns><c>true</c> if any of the provided objects are null; otherwise, <c>false</c>.</returns>
        /// <param name="Objects">The objects to check for null.</param>
        public static bool IsAnyNull(params object[] Objects)
        {
            foreach (var o in Objects)
            {
                if (o == null) return true;
            }
            return false;
        }

        /// <summary>
        /// Calculates the direction between the first coordinates, and the second ones.
        /// </summary>
        /// <returns>The <see cref="GeneralUtils"/> between the two points.</returns>
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
        /// <returns>The <see cref="GeneralUtils"/> between the two points.</returns>
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
