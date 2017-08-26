namespace Ennui.Api.Util
{
    /// <summary>
	/// Represents a timer. It counts elapsed time n stuff.
	/// </summary>
	public interface ITimer
    {
        /// <summary>
        /// Calculates the amount of elapsed milliseconds that have passed.
        /// </summary>
        /// <value>The amount of elapsed milliseconds that have passed.</value>
        long ElapsedMs { get; }

        /// <summary>
        /// Stops counting times.
        /// </summary>
        void Stop();
    }
}
