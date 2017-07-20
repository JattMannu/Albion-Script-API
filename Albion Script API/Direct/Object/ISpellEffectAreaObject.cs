using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    public interface ISpellEffectAreaObject : ISimulationObject
    {
        IXmlSpellConfig GetSpellXmlConfig();
    }
}
