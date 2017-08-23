namespace Ennui.Api.Direct
{
    public interface IAuctionListing
    {
        string ItemTypeId { get; }

        int Amount { get; }

        int Tier { get; }

        int QualityLevel { get; }
    }
}
