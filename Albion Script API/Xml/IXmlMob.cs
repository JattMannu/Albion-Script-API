namespace Ennui.Api.Xml
{
    /// <summary>
	/// Holds configuration information about a mob.
	/// </summary>
	public interface IXmlMob
    {
        /// <summary>
        /// Retrieves the drops that the mob has.
        /// </summary>
        /// <value>The drops that the mob has.</value>
        IXmlAndDrop Drops { get; }
    }
}
