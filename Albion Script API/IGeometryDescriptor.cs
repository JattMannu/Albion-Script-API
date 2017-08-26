namespace Ennui.Api
{
    public interface IGeometryDescriptor
    {
        IGeometryNode Outline { get; }
        IGeometryNode Fill { get; }
    }
}
