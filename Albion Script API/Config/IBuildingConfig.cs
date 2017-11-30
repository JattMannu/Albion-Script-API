namespace Ennui.Api.Xml
{
    /// <summary>
    /// Contains configuration information about a type of building.
    /// </summary>
    public interface IBuildingConfig
    {
        /// <summary>
        /// The unique name of the building.
        /// </summary>
        string UniqueName { get; }
    }
}
