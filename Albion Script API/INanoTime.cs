namespace Ennui.Api
{
    /// <summary>
    /// Represents a timestamp that uses nanoseconds.
    /// </summary>
    public interface INanoTime
    {
        /// <summary>
        /// The time stored in a long as nanosecond format.
        /// </summary>
        long TimeInNanoSeconds { get; }
    }
}
