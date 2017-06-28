using Ennui.Api.Direct.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    public interface IFarmableObject : IBuildingObject
    {
        IXmlAbstractBuilding XmlDynamicFarmable { get; }

        IList RawStates { get; }

        List<ICropState> States { get; }

        ICropState FirstState { get; }

        ICropState SecondState { get; }

        float PercentageDone { get; }
    }
}
