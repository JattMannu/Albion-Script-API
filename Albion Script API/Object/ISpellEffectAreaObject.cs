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
        /// This spell effect's spell xml config.
        /// </summary>
        IXmlSpellConfig SpellXmlConfig { get; }

        /// <summary>
        /// This spell's context. Can be used for resolving AOE mesh among other things.
        /// 
        /// Go down this rabbit whole at your own risk, it's internal stuff.
        /// </summary>
        ISpellEffectAreaObjectContext Context { get; }
    }
}