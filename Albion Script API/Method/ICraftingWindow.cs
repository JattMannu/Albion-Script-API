using System.Collections.Generic;

namespace Ennui.Api.Method
{
    public interface ICraftingWindow : IApiModule, IWidget
    {
        List<ICraftingItem> Selections { get; }

        bool Craft(ICraftingItem item);
    }
}
