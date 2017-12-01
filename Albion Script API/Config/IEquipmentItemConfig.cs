using Ennui.Api.Meta;

namespace Ennui.Api.Xml
{
    public interface IEquipmentItemConfig : IItemConfig
    {
        float GetStat(PlayerAttribute attribute);
    }
}
