﻿using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Represents a spell that has beenactivated.
    /// </summary>
    public interface IActiveSpell
    {
        /// <value>
        /// The config for the spell.
        /// </value>
        IXmlSpellConfig Config { get; }

        /// <value>
        /// The name of this spell.
        /// </value>
        string Name { get; }

        /// <value>
        /// The max stack count of this spell.
        /// </value>
        int MaxStack { get; }

        /// <value>
        /// The progress percent that this spell is from finishing.
        /// </value>
        float Progress { get; }

        /// <value>
        /// The charges that this spell has.
        /// </value>
        int Charges { get; }
    }
}
