namespace Ennui.Api.Direct.Object
{
    public interface IExitObject : IWorldObject
    {
        IBoundCluster BoundCluster { get; }
    }
}
