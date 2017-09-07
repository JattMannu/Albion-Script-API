namespace Ennui.Api.Xml
{
    /// <summary>
	/// Represents a proxy for an xml item. 
	/// 
	/// This holds an instance of the xml item, which is 
	/// actually a more specific type of configuration, that is then
	/// downcasted, and stored for use later.
	/// </summary>
    public interface IItemProxyConfig
    {
        /// <summary>
		/// Retrieves the loaded item config.
		/// </summary>
		/// <value>The loaded item config.</value>
        IItemConfig XmlItemConfig { get; }
    }
}
