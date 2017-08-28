using Ennui.Api.Meta;

namespace Ennui.Api.Xml
{
    public interface IXmlEquipmentItemConfig : IXmlItemConfig
    {
        float GetStat(PlayerAttribute attribute);
    }
}
