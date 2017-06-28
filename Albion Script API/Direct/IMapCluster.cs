﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IMapCluster
    {
        /// <summary>
		/// Retrieves the name of this map cluster.
		/// </summary>
		/// <value>The name of this map cluster.</value>
        string Name { get; }

        /// <summary>
		/// Gets the internal name of this map cluster.
		/// </summary>
		/// <value>The internal name of this map cluster.</value>
        string InternalName { get; }
    }
}
