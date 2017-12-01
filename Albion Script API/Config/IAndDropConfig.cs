using System.Collections;
using System.Collections.Generic;

namespace Ennui.Api.Xml
{
    public delegate T DropConverter<T>(object o);

    /// <summary>
	/// Represents a config for a mob drop that does nothing except
	/// hold configs for other mob drops.
	/// </summary>
	public interface IAndDropConfig : IDropConfig
    {
        /// <summary>
        /// Retrieves a list of internal drop objects that this drop contains.
        /// </summary>
        /// <value>A list of internal drop objects that this drop contains.</value>
        IList Drops { get; }

        /// <summary>
        /// Traverses the drop tree starting at this drop, and returns any
        /// drops matching the provided type.
        /// </summary>
        /// <param name="type">The name of the type to search for.</param>
        /// <param name="wrapper">The function that will handle wrapping of the drops.</param>
        /// <typeparam name="T">The wrapped type.</typeparam>
        List<T> Find<T>(string type, DropConverter<T> wrapper) where T : IDropConfig;
    }
}
