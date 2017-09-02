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

        private string IndexToSearchString(int index)
        {
            if (index <= 0)
            {
                return string.Empty;
            }
            return "" + (index + 1);
        }

        public void BuyCheapest(int categoryIndex, int subCategoryIndex, int echantmentLevelIndex, int qualityIndex, int tierIndex, string uniqueName)
        {
            var item = ResourceRepository.ItemConfigByUniqueName(uniqueName);
            Market.DemandRequests(
                IndexToSearchString(categoryIndex), 
                IndexToSearchString(subCategoryIndex), 
                IndexToSearchString(echantmentLevelIndex), 
                FilterType.One, 
                IndexToSearchString(qualityIndex), 
                FilterType.One, 
                IndexToSearchString(tierIndex), 
                new short[] { (short)item.UniqueId }, 
                false, 
                (auctions) =>
            {
                IAuctionListing cheapest = null;
                foreach (var auction in auctions)
                {
                    if (cheapest == null || auction.UnitPriceSilver <= cheapest.UnitPriceSilver)
                    {
                        cheapest = auction;
                    }
                }
                Market.BuyOffer(cheapest.Id, cheapest.Amount);
            });
        }
        
    }
}
