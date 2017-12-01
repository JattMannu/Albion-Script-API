namespace Ennui.Api.Method
{
    public interface IRepairWindow : IApiModule, IWidget
    {
        /// <summary>
        /// Attempts to repair all of the items on the local player.
        /// </summary>
        /// <returns><c>true</c>, if all was repaired, <c>false</c> otherwise.</returns>
        bool RepairAll();
    }
}
