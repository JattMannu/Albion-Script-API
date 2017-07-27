using Ennui.Api.Meta;

namespace Ennui.Api.Direct.Xml
{
    public interface IXmlExpedition
    {
        string UniqueName { get; }

        ExpeditionGroup Group { get; }

        int Tier { get; }
    }
}
