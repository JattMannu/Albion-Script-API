using Ennui.Api.Xml;

namespace Ennui.Api
{
    public interface IFastTravelData : IApiResource
    {
        ITravelPointConfig XmlConfig { get; }

        string IslandName { get; }
    }
}
