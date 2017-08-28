using Ennui.Api.Meta;

namespace Ennui.Api.Example
{
    public class MarketExample : ApiResource
    {
        public MarketExample(IApi api) : base(api)
        {
        }

        public void PrintOffers(string uniqueName)
        {
            var item = ResourceRepository.ItemConfigByUniqueName(uniqueName);
            Market.DemandOffers("", "", "", FilterType.One, "", FilterType.One, "", new short[] { (short) item.UniqueId }, false, (auctions) =>
            {
                foreach (var auction in auctions)
                {
                    Logging.Log("Offer listing: " + auction);
                }
            });
        }

        public void PrintRequests(string uniqueName)
        {
            var item = ResourceRepository.ItemConfigByUniqueName(uniqueName);
            Market.DemandRequests("", "", "", FilterType.One, "", FilterType.One, "", new short[] { (short)item.UniqueId }, false, (auctions) =>
            {
                foreach (var auction in auctions)
                {
                    Logging.Log("Request listing: " + auction);
                }
            });
        }
    }
}
