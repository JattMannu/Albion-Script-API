using System;
using System.Text;
using System.Threading;

namespace Ennui.Api.Util
{
    /// <summary>
	/// Provides a set of static utilities that relate to time.
	/// </summary>
	public class Time
    {
        /// <summary>
        /// Determines wether we should keep sleeping, or should break out of the sleeping early.
        /// </summary>
        public delegate bool SleepCondition();

        /// <summary>
        /// Sleeps until timeout in ms has been waited, or the provided cond returns true.
        /// </summary>
        /// <returns><c>true</c>, if the cond returned true, <c>false</c> otherwise.</returns>
        /// <param name="cond">The condition that must be met to return early.</param>
        /// <param name="timeout">The amount of time in milliseconds that will be waited before returning.</param>
        public static bool SleepUntil(SleepCondition cond, long timeout)
        {
            var timer = new Timer();
            while (timer.ElapsedMs < timeout)
            {
                if (cond())
                {
                    return true;
                }
                Thread.Sleep(50);
            }
            return false;
        }
        
        /// <summary>
        /// Formats an elapsed amount of milliseconds into a user friendly string.
        /// </summary>
        /// <returns>The elapsed time in a user friendly string.</returns>
        /// <param name="ms">The amount of elapsed time in milliseconds.</param>
        public static string FormatElapsed(long ms)
        {
            var sgn = "";
            if (ms < 0)
            {
                sgn = "-";
                ms = Math.Abs(ms);
            }

            var sb = new StringBuilder();
            StringUtils.NumberToStringPad(sb, sgn, 0, (ms / 3600000));
            StringUtils.NumberToStringPad(sb, ":", 2, ((ms % 3600000) / 60000));
            StringUtils.NumberToStringPad(sb, ":", 2, ((ms % 60000) / 1000));
            return sb.ToString();
        }

        /// <summary>
        /// Calculates the amount per hour, based on the total amount, and total time since total amount was initialized.
        /// </summary>
        /// <returns>The amount that has been averaged per hour.</returns>
        /// <param name="amount">The total amount.</param>
        /// <param name="runtime">The time in ms since total amount was initialized.</param>
        public static float CalcPerHour(float amount, long runtime)
        {
            return (amount * 3600000.0f) / runtime;
        }
    }
}
