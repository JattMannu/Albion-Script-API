using Ennui.Api.Direct.Xml;

namespace Ennui.Api.Direct
{
    public interface IFastTravelData : IApiResource
    {
        IXmlTravelPoint XmlConfig { get; }

        string IslandName { get; }
    }
}
