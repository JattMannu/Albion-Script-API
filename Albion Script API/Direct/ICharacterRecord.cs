﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Contains information about a character on an account.
    /// </summary>
	public interface ICharacterRecord
    {
        int Index { get; }
        
        /// <value>
        /// The name of the character.
        /// </value>
        string Name { get; }
        
        /// <value>
        /// The name of the cluster that the character is in.
        /// </value>
        string ClusterName { get; }
    }
}
