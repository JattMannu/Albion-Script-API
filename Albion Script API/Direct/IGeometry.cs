namespace Ennui.Api.Direct
{
    public interface IGeometry
    {
        IGeometryNode AsNode();

        IGeometryArc AsArc();

        IGeometryCircle AsCircle();

        IGeometryRectangle AsRectangle();
    }
}
