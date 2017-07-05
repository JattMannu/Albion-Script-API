using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Script
{
    /// <summary>
    /// Provides a set of static utilities for loading scripts from files.
    /// <see cref="IScript"/>
    /// <see cref="NetScriptLoader"/>
    /// </summary>
    public interface IScriptLoader
    {
        /// <summary>
        /// Parses all Script implementations from the file at the provided path.
        /// </summary>
        /// <returns>All Script implementations from the file at the provided path.</returns>
        /// <param name="path">The path to the script.</param>
        List<AbstractScript> LoadFromFile(string path);

        /// <summary>
        /// Loads all Script implementations from the provided file's url, then returns the first one.
        /// </summary>
        /// <returns>The first Script implementation from the provided file's url.</returns>
        /// <param name="url">The url of the file to parse.</param>
        AbstractScript LoadFirstFromURL(string url);
    }
}
