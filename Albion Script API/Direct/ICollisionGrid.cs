using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Interfaces to the class in game that handles collision information.
	/// </summary>
	public interface ICollisionGrid
    {
        /// <summary>
        /// Gets the width of this grid.
        /// </summary>
        /// <value>The width of this grid.</value>
        int Width { get; }

        /// <summary>
        /// Gets the height of this grid.
        /// </summary>
        /// <value>The height of this grid.</value>
        int Height { get; }

        /// <summary>
        /// Gets the offset used for translating scene coordinates, to grid coordinates.
        /// </summary>
        /// <value>The offset used for translating scene coordinates, to grid coordinates.</value>
        IScenePosition Offset { get; }

        /// <summary>
        /// Gets the x offset used for translating scene coordinates, to grid coordinates.
        /// </summary>
        /// <value>The x offset used for translating scene coordinates, to grid coordinates.</value>
        float OffsetX { get; }

        /// <summary>
        /// Gets the y offset used for translating scene coordinates, to grid coordinates.
        /// </summary>
        /// <value>The y offset used for translating scene coordinates, to grid coordinates.</value>
        float OffsetY { get; }

        /// <summary>
        /// Gets the clipping flags used by the game.
        /// </summary>
        /// <value>The clipping flags used by the game.</value>
        byte[] Flags { get; }

        /// <summary>
        /// Gets the clipping flags used by the game, and converts them
        /// to a 2d grid.
        /// </summary>
        /// <value>The game's clipping flags in a 2d grid.</value>
        FixedArrayWrapper<byte> GridFlags { get; }

        /// <summary>
        /// Grabs the flags, and converts them so that they can be used for clearance based clipping.
        /// 
        /// This is meant for the local player, so the clearance is only checked up to a depth of 2.
        /// </summary>
        /// <returns>The clipping flags, usable as is for 2 depth clearance clipping.</returns>
        /// <param name="flags">The flags to convert.</param>
        void ToClearance(FixedArrayWrapper<byte> flags);

        /// <summary>
        /// Retrieves the clipping flag at the provided 2d coordinate from a 1d array.
        /// </summary>
        /// <returns>The clipping flag at the provided 2d coordinate.</returns>
        /// <param name="b">The clipping flags.</param>
        /// <param name="x">The x coordinate to grab he clipping flag from.</param>
        /// <param name="y">The y coordinate to grab he clipping flag from.</param>
        /// <param name="width">The width of the clipping grid.</param>
        byte Extract2DFlag(byte[] b, int x, int y, int width);

        /// <summary>
        /// Retrieves the clipping flag at the provided location.
        /// </summary>
        /// <returns>The clipping flag at the provided location.</returns>
        /// <param name="x">The x coordinate to grab the clipping flag from.</param>
        /// <param name="y">The y coordinate to grab the clipping flag from.</param>
        byte GetFlagAt(int x, int y);

        /// <summary>
        /// Transforms a 3d scene position to a position on this grid.
        /// </summary>
        /// <returns>The grid position of the provided scene position.</returns>
        /// <param name="vec">The 3d scene position.</param>
        Vector2<int> TranslateTo(Vector3<float> vec);
        /// <summary>
        /// Transforms a 3d scene position to a position on this grid.
        /// </summary>
        /// <returns>The grid position of the provided scene position.</returns>
        /// <param name="x">The 3d scene x coordinate.</param>
        /// <param name="z">The 3d scene z coordinate.</param>
        Vector2<int> TranslateTo(float x, float z);

        /// <summary>
        /// Transforms a grid position to a position within the 3d scene.
        /// </summary>
        /// <returns>The 3d scene position of the tile at the provided 2d coordinates.</returns>
        /// <param name="vec">The grid coordinates.</param>
        /// <param name="center">If the coordinate returned will be in the center of the tile</param>
        Vector3<float> TranslateFrom(Vector2<int> vec, bool center);

        /// <summary>
        /// Transforms a grid position to a position within the 3d scene.
        /// </summary>
        /// <returns>The 3d scene position of the tile at the provided 2d coordinates.</returns>
        /// <param name="x">The x grid coordinate.</param>
        /// <param name="y">The y grid coordinate.</param>
        /// <param name="center">If the coordinate returned will be in the center of the tile</param>
        Vector3<float> TranslateFrom(int x, int y, bool center);
    }
}
