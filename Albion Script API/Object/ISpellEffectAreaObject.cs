using Ennui.Api.Util;
using Ennui.Api.Xml;
using System.Collections.Generic;

namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a spell area indicator within the scene.
    /// </summary>
    public interface ISpellEffectAreaObject : ISimulationObject
    {
        /// <summary>
        /// This spell effect area object's area.
        /// </summary>
        ISpellEffectArea SpellEffectArea { get; }

        /// <summary>
        /// This spell effect's spell config.
        /// </summary>
        ISpellConfig SpellConfig { get; }
    }
}