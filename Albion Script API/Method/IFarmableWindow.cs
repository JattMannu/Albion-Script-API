using Ennui.Api.Object;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Represents a specific status that can be returned from attempting to drop an item
    /// onto a farmable window.
    /// </summary>
    public enum FarmableDropStatus
    {
        /// <summary>
        /// Represents a successfull drop.
        /// </summary>
        OK,
        /// <summary>
        /// Represents a drop attempt where the animal is already full.
        /// </summary>
        NOT_HUNGRY,
        /// <summary>
        /// Represents a drop attempt where an invalid item was fed to an animal.
        /// </summary>
        INVALID_FOOD,
        /// <summary>
        /// Represents a drop where the storage of the object was already full.
        /// </summary>
        FULL,
    }

    public interface IFarmableWindow : IWidget
    {
        /// <summary>
        /// The farmable object that the ui is open for.
        /// </summary>
        IFarmableObject FarmableObject { get; }

        /// <summary>
        /// Picks the focused harvestable up off the ground.
        /// </summary>
        /// <returns>If the object was picked up.</returns>
        bool Pickup();

        /// <summary>
        /// Takes the grown items out of the farmable object.
        /// </summary>
        void TakeGrown();

        /// <summary>
        /// Takes the harvest items out of the farmable object.
        /// </summary>
        void TakeHarvest();

        /// <summary>
        /// Takes the product items out of the farmable object.
        /// </summary>
        void TakeProduct();

        /// <summary>
        /// Triggers the boost effect on the selected farmable object.
        /// </summary>
        void Boost();

        /// <summary>
        /// Moves an item stack onto the farmable object.
        /// 
        /// The effect this has is dependent on what type of object it is (i.e. feeding animations.)
        /// </summary>
        /// <param name="stack">The stack to move onto the animal.</param>
        FarmableDropStatus DropItem(IItemStack stack);
    }
}
