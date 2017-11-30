namespace Ennui.Api
{
    /// <summary>
    /// Represents a module of an API.
    /// </summary>
    public interface IApiModule
    {
        /// <summary>
        /// The API that this module belongs to.
        /// </summary>
        IApi Api { get; set; }
    }
}
