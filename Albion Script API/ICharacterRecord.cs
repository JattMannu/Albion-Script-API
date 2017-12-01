namespace Ennui.Api
{
    /// <summary>
    /// Contains information about a character on an account.
    /// </summary>
	public interface ICharacterRecord
    {
        /// <summary>
        /// The index of this record.
        /// </summary>
        int Index { get; }
        
        /// <value>
        /// The name of the character.
        /// </value>
        string Name { get; }
        
        /// <value>
        /// The name of the cluster that the character is in.
        /// </value>
        string ClusterName { get; }
    }
}
