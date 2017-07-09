namespace Ennui.Api
{
    /// <summary>
	/// Represents a timer. It counts elapsed time n stuff.
	/// </summary>
	public class Timer : ITimer
    {
        private System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

        /// <summary>
        /// Calculates the amount of elapsed milliseconds that have passed.
        /// </summary>
        /// <value>The amount of elapsed milliseconds that have passed.</value>
        public long ElapsedMs
        {
            get
            {
                return watch.ElapsedMilliseconds;
            }
        }

        /// <summary>
        /// Stops counting times.
        /// </summary>
        public void Stop()
        {
            watch.Stop();
        }
    }
}
