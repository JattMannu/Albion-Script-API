namespace Ennui.Api.Util
{
    /// <summary>
	/// Default timer implementation using stopwatch.
	/// </summary>
	public class Timer : ITimer
    {
        private System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
        
        public long ElapsedMs
        {
            get
            {
                return watch.ElapsedMilliseconds;
            }
        }
        
        public void Stop()
        {
            watch.Stop();
        }
    }
}
