using System;

namespace Ennui.Api
{
    /// <summary>
	/// Provides meta data for a script that is loaded from disk.
	/// </summary>
	public class LocalScript : Attribute
    {
        private string name;
        private string description;
        private string version;
        private string category;

        /// <summary>
        /// Gets or sets the name of the script.
        /// </summary>
        /// <value>The name of the script.</value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the description of the script.
        /// </summary>
        /// <value>The description of the script.</value>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Gets or sets the version of the script.
        /// </summary>
        /// <value>The version of the script.</value>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }

        /// <summary>
        /// Gets or sets the category of the script.
        /// </summary>
        /// <value>The category of the script.</value>
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalScript"/> class.
        /// </summary>
        /// <param name="name">The name of the script.</param>
        /// <param name="description">The description of the script.</param>
        /// <param name="version">The version of the script.</param>
        /// <param name="category">The category of the script.</param>
        public LocalScript(string name, string description, string version, string category)
        {
            this.Name = name;
            this.Description = description;
            this.Version = version;
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalScript"/> class.
        /// </summary>
        public LocalScript()
        {
            this.Name = "Unknown";
            this.Description = "";
            this.Version = "0.0.0";
            this.Category = "Misc";
        }
    }
}
