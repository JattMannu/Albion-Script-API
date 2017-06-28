using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interacting with files.
	/// </summary>
	public interface IFiles : IApiModule
    {
        /// <summary>
        /// Checks if a directory exists.
        /// </summary>
        /// <returns>If the directory exists.</returns>
        /// <param name="directory">The directory we're checking the existence of.</param>
        bool DirectoryExists(string directory);

        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name="directory">The path of the directory to create.</param>
        void CreateDirectory(string directory);

        /// <summary>
        /// Checks if the file with the provided name exists.
        /// </summary>
        /// <param name="file">The path to the file that we're checking.</param>
        bool Exists(string file);

        /// <summary>
        /// Deletes the file at the provided path.
        /// </summary>
        /// <param name="file">The path of the file to delete.</param>
        void Delete(string file);

        /// <summary>
        /// Creates a file at the provided path.
        /// </summary>
        /// <param name="file">The path to create the file at.</param>
        void Create(string file);

        /// <summary>
        /// Reads all bytes from the file at the provided path.
        /// </summary>
        /// <returns>All bytes from the file at the provided path.</returns>
        /// <param name="file">File path of the file to read from.</param>
        byte[] ReadAllBytes(string file);

        /// <summary>
        /// Reads all bytes from the file at the provided path.
        /// </summary>
        /// <returns>All bytes from the file at the provided path.</returns>
        /// <param name="file">File path of the file to read from.</param>
        string ReadAllText(string file);

        /// <summary>
        /// Writes bytes to a file.
        /// </summary>
        /// <param name="file">The path of the file to write to.</param>
        /// <param name="b">The byte array to write.</param>
        void WriteBytes(string file, byte[] b);

        /// <summary>
        /// Writes text to a file.
        /// </summary>
        /// <param name="file">The path of the file to write to.</param>
        /// <param name="text">The text to write.</param>
        void WriteText(string file, string text);
    }
}
