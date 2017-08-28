namespace Ennui.Api
{
    /// <summary>
    /// Handles serialization and deserialization of a single field.
    /// 
    /// TODO Remove for abstraction
    /// </summary>
    public interface IFieldCodec
    {
        /// <summary>
        /// Reads data from a single field within an object, and serializes it.
        /// </summary>
        /// <param name="to">The object to read data from.</param>
        /// <returns>The serialized data.</returns>
        object Serialize(object to);

        /// <summary>
        /// Deserializes data, and writes it to a single field in an object.
        /// </summary>
        /// <param name="to">The object to write the data to.</param>
        /// <param name="val">The serialized value to write.</param>
        void Deserialize(object to, object val);
    }
}
