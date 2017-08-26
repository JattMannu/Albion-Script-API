using System.Collections.Generic;

namespace Ennui.Api
{
    public interface IGeometryNode : IGeometry
    {
        List<IGeometry> Children { get; }
    }
}
