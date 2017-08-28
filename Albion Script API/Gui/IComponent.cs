using Ennui.Api.Util;

namespace Ennui.Api.Gui
{
    public interface IComponent : IApiResource
    {
        void Add(IComponent child);

        void SetSize(int width, int height);

        Vector2<float> GetSize();

        void SetPosition(int x, int y, int z);

        void SetAnchor(Vector2<float> min, Vector2<float> max);

        void SetPivot(Vector2<float> pivot);

        void SetScale(Vector3<float> scale);

        void Destroy();

        void DestroyChildren();
    }
}
