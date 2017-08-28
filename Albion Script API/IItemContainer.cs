using System.Collections.Generic;

namespace Ennui.Api
{
    public interface IItemContainer
    {
       List<IItemStack> ItemList { get; }
    }
}
