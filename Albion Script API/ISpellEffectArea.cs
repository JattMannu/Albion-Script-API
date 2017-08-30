using Ennui.Api.Util;
using System.Collections.Generic;

namespace Ennui.Api
{
    public interface ISpellEffectArea
    {
        IGeometryDescriptor GeometryDescriptor { get; }

        /// <summary>
        /// Builds meshes based on this spell effect area's geometry.
        /// </summary>
        /// <returns>A list of built meshes.</returns>
        List<IMesh> BuildMeshes();

        /// <summary>
        /// The tiles that are within this spell effect area.
        /// </summary>
        /// <returns>A list of all tiles within this effect area.</returns>
        List<Vector2<int>> TilesConsumed();
    }
}
