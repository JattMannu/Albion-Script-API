namespace Ennui.Api.Direct
{
    public interface IGeometryDescriptor
    {
        IGeometryNode Outline { get; }
        IGeometryNode Fill { get; }
    }
}
