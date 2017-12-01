namespace Ennui.Api
{
    /// <summary>
    /// Represents a floating point number stored in a long! Because we're SI and we're fucking retarded!
    /// </summary>
    public interface IPreciseNumber
    {
        /// <summary>
        /// The internal number used for precision. Implementation details undefined.
        /// </summary>
        long InternalNumber { get; }

        /// <summary>
        /// This precise number converted back into a normal data type.
        /// </summary>
        long Normal { get; }
    }
}
