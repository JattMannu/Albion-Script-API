using System.Collections;
using System.Collections.Generic;

namespace Ennui.Api.Util
{
    public static class DataSetUtils
    {
        /// <summary>
        /// Casts the provided dictionary to a generic dictionary with the provided types.
        /// </summary>
        /// <param name="dictionary">The dictionary to cast from.</param>
        /// <typeparam name="K">The dictionary key type.</typeparam>
        /// <typeparam name="V">The dictionary value type.</typeparam>
        public static Dictionary<K, V> Cast<K, V>(IDictionary dictionary)
        {
            var casted = new Dictionary<K, V>();
            foreach (DictionaryEntry entry in dictionary)
            {
                casted.Add((K)entry.Key, (V)entry.Value);
            }
            return casted;
        }

        /// <summary>
        /// Casts the provided list to a generic list with the provided type.
        /// </summary>
        /// <param name="list">The list to cast from.</param>
        /// <typeparam name="K">The element type.</typeparam>
        public static List<K> Cast<K>(IList list)
        {
            var casted = new List<K>();
            foreach (var obj in list)
            {
                casted.Add((K)obj);
            }
            return casted;
        }

        /// <summary>
        /// Checks if any of the provided objects are null.
        /// </summary>
        /// <returns><c>true</c> if any of the provided objects are null; otherwise, <c>false</c>.</returns>
        /// <param name="Objects">The objects to check for null.</param>
        public static bool IsAnyNull(params object[] Objects)
        {
            foreach (var o in Objects)
            {
                if (o == null) return true;
            }
            return false;
        }

        /// <summary>
        /// If this list is empty.
        /// </summary>
        /// <param name="list">The list to check if empty.</param>
        /// <returns>If the list is empty.</returns>
        public static bool IsEmpty(this IList list)
        {
            return list.Count == 0;
        }
    }
}
