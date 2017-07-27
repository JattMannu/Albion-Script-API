using Ennui.Api.Direct.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents an object.. that we can farm. Probably planted. Ok.
    /// </summary>
    public interface IFarmableObject : IBuildingObject
    {
        /// <summary>
        /// This farmable object's xml config
        /// </summary>
        IXmlAbstractBuilding XmlDynamicFarmable { get; }

        /// <summary>
        /// The raw states of this farmable. 
        /// 
        /// TODO Remove for muh abstraction
        /// </summary>
        IList RawStates { get; }

        /// <summary>
        /// The states of everything planted in this farmabel.
        /// </summary>
        List<ICropState> States { get; }

        /// <summary>
        /// The state of the first thing planted in this farmable.
        /// </summary>
        ICropState FirstState { get; }

        /// <summary>
        /// The state of the second thing planted in this farmable.
        /// </summary>
        ICropState SecondState { get; }

        /// <summary>
        /// The percentage that everything is doen growing.
        /// </summary>
        float PercentageDone { get; }
    }
}
