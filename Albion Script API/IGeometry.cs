namespace Ennui.Api
{
    public interface IGeometry
    {
        IGeometryNode AsNode();

        IGeometryArc AsArc();

        IGeometryCircle AsCircle();

        IGeometryRectangle AsRectangle();
    }
}
