using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Xml
{
    public interface IXmlEquipmentItemConfig : IXmlItemConfig
    {
        float GetStat(PlayerAttribute attribute);
    }
}
