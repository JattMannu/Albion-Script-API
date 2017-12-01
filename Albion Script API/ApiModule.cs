namespace Ennui.Api
{
    /// <summary>
    /// A default API module implementation.
    /// 
    /// This implementation has a backing API, which uses composition.
    /// </summary>
    public abstract class ApiModule : ApiResource, IApiModule
    {
        public ApiModule(IApi api) : base(api)
        {
            
        }
    }
}
