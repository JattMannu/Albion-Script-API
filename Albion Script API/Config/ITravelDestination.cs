namespace Ennui.Api.Xml
{
    /// <summary>
    /// Contains configuration information for a travel destination.
    /// </summary>
    public interface ITravelDestinationConfig
    {
        /// <summary>
        /// The internal cluster name of the target destination.
        /// </summary>
        string InternalClusterName { get; }
    }
}
