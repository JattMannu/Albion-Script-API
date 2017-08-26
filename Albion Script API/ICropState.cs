namespace Ennui.Api
{
    /// <summary>
    /// Holds information about a planted crop.
    /// </summary>
    public interface ICropState
    {
        /// <summary>
        /// The amount of time remaining until this crop finishes growing.
        /// </summary>
        INanoTime TimeRemaining { get; }

        /// <summary>
        /// The total amount of time before this crop is grown.
        /// </summary>
        INanoTime TotalDuration { get; }
    }
}
