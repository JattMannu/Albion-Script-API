using Ennui.Api.Meta;

namespace Ennui.Api.Xml
{
    public interface IExpeditionConfig
    {
        string UniqueName { get; }

        ExpeditionGroup Group { get; }

        int Tier { get; }
    }
}
