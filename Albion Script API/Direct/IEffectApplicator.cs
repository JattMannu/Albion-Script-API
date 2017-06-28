using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Handles the applying of spells to entities.
	/// </summary>
	public interface IEffectApplicator
    {
        /// <summary>
        /// Retrieves a list of all spells actively being applied to the parent entity.
        /// </summary>
        /// <value>A list of all spells actively being applied to the parent entity.</value>
        List<IActiveSpell> ActiveEffects { get; }
    }
}
