namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for resolving bot resources.
	/// </summary>
    public interface IBotResources : IApiModule
    {
        /// <summary>
        /// Resolves a file relative to our storage directory.
        /// </summary>
        /// <returns>The path to the file.</returns>
        /// <param name="path">The relative path to resolve.</param>
        string ResolveResource(string path);
    }
}
