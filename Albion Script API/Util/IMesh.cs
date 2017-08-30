using System.Collections.Generic;

namespace Ennui.Api.Util
{
    public interface IMesh
    {
        List<Vector3<float>> Vertices { get; }

        List<int> Triangles { get; }
    }
}
