using System.Collections;
using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents an object.. that we can farm. Probably planted. Ok.
    /// </summary>
    public interface IFarmableObject : IBuildingObject
    {
        /// <summary>
        /// This farmable object's xml config
        /// </summary>
        IAbstractBuildingConfig XmlDynamicFarmable { get; }

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

        /// <summary>
        /// If this object can eat an item with the provided config.
        /// </summary>
        /// <param name="config">The config to check the validity of.</param>
        /// <returns>If this object can eat the item.</returns>
        bool CanEat(IItemConfig config);

        /// <summary>
        /// Determines if this object can eat the provided stack.
        /// </summary>
        /// <param name="stack">The stack to check against.</param>
        /// <returns>If this object can eat the stack.</returns>
        bool CanEat(IItemStack stack);
        
        /// <summary>
        /// Determines if this object has any empty slots for dropping items.
        /// </summary>
        /// <returns>If this object has any empty slots for dropping items.</returns>
        bool HasEmptySlot();
    }
}
