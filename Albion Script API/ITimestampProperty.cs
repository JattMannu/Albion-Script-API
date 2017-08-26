using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Holds a value, and the time when the value was last updated.
	/// </summary>
	public interface ITimestampProperty
    {
        /// <summary>
        /// Retrieves the current value of this property.
        /// </summary>
        /// <value>The current value of this property.</value>
        float Value { get; }
    }
}
