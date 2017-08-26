namespace Ennui.Api.Meta
{
    /// <summary>
    /// Whenever the local player tries to harvest a resource, it does a handful of checks, and returns
    /// a numerical value depending on the state. Invalid means a failure of some sort (e.g. player doesn't own mob.)
    /// </summary>
    public enum HarvestableSetupState
    {
        Owned = 7,
        Invalid = 100,
    }
}
