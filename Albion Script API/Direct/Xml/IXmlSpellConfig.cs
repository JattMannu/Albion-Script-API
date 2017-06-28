using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Xml
{
    public interface IXmlSpellConfig : IXmlUiSpellConfig
    {
        /// <summary>
        /// Retrieves the type that this spell can target.
        /// </summary>
        /// <value>The type that this spell can target.</value>
        SpellTarget Target { get; }

        /// <summary>
        /// Retrieves the category that the spell is in.
        /// </summary>
        /// <value>The category that the spell is in.</value>
        SpellCategory Category { get; }

        /// <summary>
        /// Retrieves the maximum amount of times that this spell can be stacked.
        /// </summary>
        /// <value>The maximum amount of times that this spell can be stacked.</value>
        int MaxStack { get; }

        /// <summary>
        /// Retrieves the amount of energy required to cost this spell.
        /// </summary>
        /// <value>The amount of energy required to cast this spell.</value>
        int EnergyCost { get; }

    }
}
