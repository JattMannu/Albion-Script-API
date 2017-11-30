using Ennui.Api.Meta;
using Ennui.Api.Util;
using System.Collections.Generic;

namespace Ennui.Api
{
    /// <summary>
    /// Represents a spell effect area within the scene.
    /// </summary>
    public interface ISpellEffectArea
    {
        /// <summary>
        /// Builds meshes based on this spell effect area's geometry.
        /// </summary>
        /// <param name="meshScale">The scale to use when building the meshes.</param>
        /// <returns>A list of built meshes.</returns>
        List<IMesh> BuildMeshes(float meshScale = 1.0f);

        /// /// <summary>
        /// The tiles that are within this spell effect area.
        /// </summary>
        /// <param name="meshScale">The scale to use when building the meshes.</param>
        /// <returns>A list of all tiles within this effect area.</returns>
        List<Vector2<int>> TilesConsumed(float meshScale = 1.5f);
    }
}
