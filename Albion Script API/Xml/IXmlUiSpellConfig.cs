namespace Ennui.Api.Xml
{
    /// <summary>
	/// Holds configuration information about displaying
	/// a spell on the game's ui.
	/// </summary>
	public interface IXmlUiSpellConfig
    {
        /// <summary>
        /// Retrieves the unique name of the spell.
        /// </summary>
        /// <value>The unique name of the spell.</value>
        string UniqueName { get; }
    }
}
