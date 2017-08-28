using Ennui.Api.View;
using Ennui.Api.Meta;
using Ennui.Api.Util;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents a world object that the local player can harvest
	/// this object for something in return.
	/// </summary>
    public interface IHarvestableObject : IWorldObject
    {
        IObjectConfig ObjectConfig { get; }

        /// <summary>
        /// The view for this harvestable object.
        /// </summary>
        IHarvestableObjectView HarvestableObjectView { get; }

        /// <summary>
        /// The bounds that a player needs to be inside of to gather resources from this object.
        /// </summary>
        IArea<float> InteractBounds { get; }

        /// <summary>
        /// The bounds of this object in the 3d scene.
        /// </summary>
        IArea<float> Bounds { get; }

        /// <summary>
        /// The internal harvestable component being used by the game.
        /// </summary>
        IHarvestable Harvestable { get; }

        /// <summary>
        /// If this object is depleted of resources.
        /// </summary>
        bool Depleted { get; }

        /// <summary>
        /// The amount of charges remaining in this object.
        /// </summary>
        int Charges { get; }

        /// <summary>
        /// The tier of resource that this object provides.
        /// </summary>
        int Tier { get; }

        /// <summary>
        /// The effective tier of the resource.
        /// </summary>
        int EffectiveTier { get; }

        /// <summary>
        /// The type of resource that this object provides.
        /// </summary>
        ResourceType Type { get; }

        /// <summary>
        /// The rare state of this object.
        /// </summary>
        int RareState { get; }

        /// <summary>
        /// The setup state for this harvestable.
        /// </summary>
        HarvestableSetupState SetupState { get; }
    }
}
