namespace Ennui.Api
{
    public interface IPlaceItemEventHandler
    {
        bool Place(long id, IScenePosition pos, float rotation);
    }
}
