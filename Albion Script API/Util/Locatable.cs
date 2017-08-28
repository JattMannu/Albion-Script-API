using Ennui.Api.Util;

namespace Ennui.Api.Util
{
    /// <summary>
	/// Represents something that has a location within the 3d world.
	/// </summary>
    public interface Locatable
    {
        /// <summary>
        /// Retrieves this locatable's location.
        /// </summary>
        /// <value>The location.</value>
        Vector3<float> Location { get; }
    }
}
