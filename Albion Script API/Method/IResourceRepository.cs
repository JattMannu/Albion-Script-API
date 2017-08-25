using System.Collections.Generic;

using Ennui.Api.Direct.Xml;

namespace Ennui.Api.Method
{
    public interface IResourceRepository
    {
        List<IXmlItemConfig> AllXmlItemConfigs { get; }
        IXmlItemConfig ItemConfigById(int uniqueId);
        IXmlItemConfig ItemConfigByUniqueName(string uniqueName);
    }
}
