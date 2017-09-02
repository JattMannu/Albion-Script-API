using Ennui.Api.Object;

namespace Ennui.Api.Method
{
    public interface ILootWindow : IWidget
    {
        ILootObject LootObject { get; }
    }
}
