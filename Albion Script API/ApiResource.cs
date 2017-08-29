namespace Ennui.Api
{
    public class ApiResource : CompositeApi, IApiResource
    {
        public ApiResource(IApi api) : base(api)
        {
        }
    }
}
