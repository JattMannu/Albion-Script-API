namespace Ennui.Api
{
    /// <summary>
    /// Represents a resource that is bound to an API.
    /// </summary>
    public interface IApiResource
    {
        /// <summary>
        /// The API that this resource is bound to.
        /// </summary>
        IApi Api { get; set; }
    }
}
