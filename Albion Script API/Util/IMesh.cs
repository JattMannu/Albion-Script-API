using System.Collections.Generic;

namespace Ennui.Api.Util
{
    /// <summary>
    /// Represents a mesh.
    /// </summary>
    public interface IMesh
    {
        /// <summary>
        /// The vertices of the mesh.
        /// </summary>
        List<Vector3<float>> Vertices { get; }

        /// <summary>
        /// The triangle (vertex pointer) of the mesh.
        /// </summary>
        List<int> Triangles { get; }
    }
}
