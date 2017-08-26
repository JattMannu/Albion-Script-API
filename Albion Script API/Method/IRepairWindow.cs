namespace Ennui.Api.Method
{
    public interface IRepairWindow : IApiModule
    {
        /// <summary>
        /// Checks if the repair item screen is currently open.
        /// </summary>
        /// <value><c>true</c> if is open; otherwise, <c>false</c>.</value>
        bool IsOpen { get; }

        /// <summary>
        /// Attempts to repair all of the items on the local player.
        /// </summary>
        /// <returns><c>true</c>, if all was repaired, <c>false</c> otherwise.</returns>
        bool RepairAll();
    }
}
