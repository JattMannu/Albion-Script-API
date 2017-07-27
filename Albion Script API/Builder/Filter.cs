using System.Text;

namespace Ennui.Api.Builder
{
    /// <summary>
    /// Acts as a filter. Use it for filtering stuff.
    /// </summary>
    /// <typeparam name="T">The type of stuff to filter. One doesn't just filter cars and coffee grounds together.</typeparam>
    public interface Filter<T>
    {
        /// <summary>
        /// If the provided value should be F I L T E R E D!
        /// </summary>
        /// <param name="t">The value to check.</param>
        /// <returns><code>true</code> if we filter if, <code>false</code> if not :thonk:</returns>
        bool Ignore(T t);
    }
}
