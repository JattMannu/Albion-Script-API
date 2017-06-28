using Ennui.Api.Direct.Object;
using Ennui.Api.Direct.Xml;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Represents a spell. Buffs, heals, attacks, etc.
	/// </summary>
	public interface ISpell
    {
        /// <summary>
        /// Retrieves or puts the local player object that this spell belongs to.
        /// </summary>
        /// <value>The local player object that this spell belongs to.</value>
        ILocalPlayerObject Parent
        {
            get; set;
        }

        /// <summary>
        /// Retrieves the slot that this spell is in.
        /// </summary>
        /// <value>The slot that this spell is in.</value>
        CharacterSpellSlot Slot
        {
            get; set;
        }

        /// <summary>
        /// Checks if this spell slot is in use.
        /// </summary>
        bool InUse { get; }

        /// <summary>
        /// This spell's config file. It's read from an internal xml file by the game.
        /// </summary>
        /// <value>The spell's config file.</value>
        IXmlExtendedSpellConfig Config { get; }

        /// <summary>
        /// Retrieves the name of this spell.
        /// </summary>
        /// <value>The name of this spell.</value>
        string Name { get; }

        /// <summary>
        /// Retrieves the category that this spell is within.
        /// </summary>
        /// <value>The category that this spell is within.</value>
        SpellCategory Category { get; }

        /// <summary>
        /// Retrieves the type that this spell can target.
        /// </summary>
        /// <value>The type that this spell can target.</value>
        SpellTarget Target { get; }

        /// <summary>
        /// Retrieves the number of times this spell's effects can be stacked.
        /// </summary>
        /// <value>The number of times this spell's effects can be stacked.</value>
        int MaxStack { get; }

        /// <summary>
        /// Retrieves the amount of energy that it costs to cast this spell.
        /// </summary>
        /// <value>The amount of energy that it costs to cast this spell.</value>
        int EnergyCost { get; }

        /// <summary>
        /// Determines if this spell is currently available to be casted.
        /// </summary>
        /// <value><c>true</c> if this spell is ready to be casted; otherwise, <c>false</c>.</value>
        bool IsReadyToCast { get; }
    }
}
