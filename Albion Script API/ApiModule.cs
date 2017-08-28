namespace Ennui.Api
{
    public abstract class ApiModule : ApiResource, IApiModule
    {
        public ApiModule(IApi api) : base(api)
        {
            this.Api = api;
        }
    }
}
