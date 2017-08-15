using System.Collections.Generic;

namespace Ennui.Api.Direct
{
    public interface IGeometryNode : IGeometry
    {
        List<IGeometry> Children { get; }
    }
}
