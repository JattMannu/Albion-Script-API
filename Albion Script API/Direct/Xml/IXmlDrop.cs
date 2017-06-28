﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Xml
{
    /// <summary>
	/// Contains configuration information about a mob drop.
	/// </summary>
    public interface IXmlDrop
    {
        /// <summary>
        /// Gets the chance of this drop happening.
        /// </summary>
        /// <value>The chance of this drop happening.</value>
        float Chance { get; }

        /// <summary>
        /// Gets the weight of the drop.
        /// </summary>
        /// <value>The weight of the drop.</value>
        float Weight { get; }

        /// <summary>
        /// Checks if this drop can be dropped multiple times at once.
        /// </summary>
        /// <value>If this drop can be dropped multiple times at once.</value>
        bool CanDropMultipleTimes { get; }
    }
}