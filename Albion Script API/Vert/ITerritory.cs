using Ennui.Api.Util;

namespace Ennui.Api.Vert
{
    /// <summary>
    /// Represents a guild controlled region within a map cluster.
    /// </summary>
    public interface ITerritory
    {
        /// <summary>
        /// The unique id of this Territory.
        /// </summary>
         string Id { get; set; }

        /// <summary>
        /// The display name of this Territory.
        /// </summary>
         string Name { get; set; }

        /// <summary>
        /// The position of the center of this Territory within the 3d scene.
        /// </summary>
         Vector2<float> Center { get; set; }

        /// <summary>
        /// The size of this Territory within the 3d scene (area = center - size / 2, center + size / 2)
        /// </summary>
         Vector2<float> Size { get; set; }
    }
}
