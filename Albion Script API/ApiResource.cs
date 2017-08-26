namespace Ennui.Api
{
    public class ApiResource : MutableApi, IApiResource
    {
        public IApi Api { get; set; }

        public ApiResource(IApi api)
        {
            this.Api = api;
            if (api != null)
            {
                this.Set(api);
            }
        }
    }
}
