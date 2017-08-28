using Ennui.Api.Xml;

namespace Ennui.Api
{
    public interface IFastTravelData : IApiResource
    {
        IXmlTravelPoint XmlConfig { get; }

        string IslandName { get; }
    }
}
