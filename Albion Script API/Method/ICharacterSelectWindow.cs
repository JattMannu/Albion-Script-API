using System.Collections.Generic;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with the character selection in game.
	/// </summary>
    public interface ICharacterSelectWindow : IApiModule, IWidget
    {
        /// <summary>
        /// Attempts to login to the character in the provided record.
        /// </summary>
        /// <returns><c>true</c>, if with was login was successful, <c>false</c> otherwise.</returns>
        /// <param name="record">The record for the character that we want to login with.</param>
         bool LoginWith(ICharacterRecord record);

        /// <summary>
        /// Retrieves a list of every character record belonging
        /// to the currently logged into account.
        /// </summary>
        /// <value>A list of every character record belonging to the currently logged into account.</value>
         List<ICharacterRecord> Records { get; }

        /// <summary>
        /// Retrieves the character record with the provided character name.
        /// </summary>
        /// <returns>The character record with the provided name, or null if one was not found.</returns>
        /// <param name="name">The name of the character to search for.</param>
         ICharacterRecord RecordByName(string name);
    }
}
