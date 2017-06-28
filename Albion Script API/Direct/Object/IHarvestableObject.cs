using Ennui.Api.Direct.View;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Represents a world object that the local player can harvest
	/// this object for something in return.
	/// </summary>
    public interface IHarvestableObject : IWorldObject
    {
        IObjectConfig ObjectConfig { get; }

        /// <summary>
        /// Gets the view for this harvestable object.
        /// </summary>
        /// <value>The view for this harvestable object.</value>
        IHarvestableObjectView HarvestableObjectView { get; }

        /// <summary>
        /// Calculates the bounds that a player needs to be inside of to gather resources
        /// from this object.
        /// </summary>
        /// <value>The bounds that a player needs to be inside of to gather resources from this object.</value>
        IArea<float> InteractBounds { get; }

        /// <summary>
        /// Calculates the bounds of this object in the 3d scene.
        /// </summary>
        /// <value>The bounds of this object in the 3d scene.</value>
        IArea<float> Bounds { get; }

        /// <summary>
        /// Gets the internal harvestable component being used by the game.
        /// </summary>
        /// <value>The internal harvestable component being used by the game.</value>
        IHarvestable Harvestable { get; }

        /// <summary>
        /// Checks if this object is depleted of resources.
        /// </summary>
        /// <value>If this object is depleted of resources.</value>
        bool Depleted { get; }

        /// <summary>
        /// Gets the amount of charges remaining in this object.
        /// </summary>
        /// <value>The amount of charges remaining in this object.</value>
        int Charges { get; }

        /// <summary>
        /// Gets the tier of resource that this object provides.
        /// </summary>
        /// <value>The tier of resource that this object provides.</value>
        int Tier { get; }

        /// <summary>
        /// The effective tier of this resource. For instance, a 4.2 resource
        /// will require a t4 tool to gather instead of a t3 tool, making it effectively
        /// a t5 resource.
        /// </summary>
        /// <value>The effective tier of the resource.</value>
        int EffectiveTier { get; }

        /// <summary>
        /// Gets the type of resource that this object provides.
        /// </summary>
        /// <value>The type of resource that this object provides.</value>
        ResourceType Type { get; }

        /// <summary>
        /// Gets the rare state of this object.
        /// </summary>
        /// <value>The rare state of this object.</value>
        int RareState { get; }
    }
}
