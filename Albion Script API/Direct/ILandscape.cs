using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Holds information about a landscape.
	/// </summary>
    public interface ILandscape
    {
        /// <summary>
		/// Calculates the height of the tile at the provided coordinates.
		/// </summary>
		/// <returns>The height of the tile at the provided coordinates.</returns>
		/// <param name="pos">The coordinates to get the height at.</param>
		float GetTileHeight(Vector2<float> pos);
    }
}
