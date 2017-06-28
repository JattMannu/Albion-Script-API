using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IActiveSpell
    {
        /// <summary>
        /// Gets the config for the spell.
        /// </summary>
        /// <value>The config for the spell.</value>
        IXmlSpellConfig Config { get; }

        /// <summary>
        /// Gets the name of this spell.
        /// </summary>
        /// <value>The name of this spell.</value>
        string Name { get; }

        /// <summary>
        /// Gets the max stack count of this spell.
        /// </summary>
        /// <value>The max stack count of this spell.</value>
        int MaxStack { get; }

        /// <summary>
        /// Gets the progress percent that this spell is from finishing.
        /// </summary>
        /// <value>The progress percent that this spell is from finishing.</value>
        float Progress { get; }

        /// <summary>
        /// Gets the charges that this spell has.
        /// </summary>
        /// <value>The charges that this spell has.</value>
        int Charges { get; }
    }
}
