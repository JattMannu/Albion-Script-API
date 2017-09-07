namespace Ennui.Api.Xml
{
    /// <summary>
	/// Contains configuration information about a drop from a mob
	/// that drops a resource node.
	/// </summary>
	public interface IHarvestableDropConfig : IDropConfig
    {
        /// <summary>
        /// Retrieves the type of resource node that is dropped.
        /// 
        /// This is in the following format:
        /// 	TYPE_THEME (e.g. Hide_Swamp)
        /// </summary>
        /// <value>The type of resource node that is dropped.</value>
        string Type { get; }

        /// <summary>
        /// Retrieves the tier of resource node that is dropped.
        /// </summary>
        /// <value>The tier of resource node that is dropped.</value>
        int Tier { get; }
    }
}
