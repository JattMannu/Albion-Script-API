using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api.Method
{
    public interface IResourceRepository
    {
        List<IItemConfig> AllXmlItemConfigs { get; }
        IItemConfig ItemConfigById(int uniqueId);
        IItemConfig ItemConfigByUniqueName(string uniqueName);
    }
}
