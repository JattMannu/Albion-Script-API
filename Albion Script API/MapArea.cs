using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Represents a 3d area that is tied to a cluster.
	/// </summary>
	public class MapArea : Area, IApiResource
    {
        private string clusterName;
        public IApi Api { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Ennui.Api.MapArea"/> class.
        /// </summary>
        /// <param name="clusterName">The name of the map cluster.</param>
        /// <param name="start">The start 3d coordinate of the area box.</param>
        /// <param name="end">The end 3d coordinate of the area box.</param>
        public MapArea(IApi api, string clusterName, Vector3<float> start, Vector3<float> end) : base(start, end)
        {
            this.Api = api;
            this.clusterName = clusterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ennui.Api.MapArea"/> class.
        /// </summary>
        /// <param name="clusterName">The name of the map cluster.</param>
        /// <param name="x0">The start x coordinate of the area box.</param>
        /// <param name="y0">The start y coordinate of the area box.</param>
        /// <param name="z0">The start z coordinate of the area box.</param>
        /// <param name="x1">The end x coordinate of the area box.</param>
        /// <param name="y1">The end y coordinate of the area box.</param>
        /// <param name="z1">The end z coordinate of the area box.</param>
        public MapArea(IApi api, string clusterName, float x0, float y0, float z0, float x1, float y1, float z1)
            : base(x0, y0, z0, x1, y1, z1)
        {
            this.Api = api;
            this.clusterName = clusterName;
        }

        /// <inheritdoc/>
        public override bool Contains(Vector3<float> loc)
        {
            var cluster = Api.Game.Cluster;
            if (cluster == null) return false;
            if (!clusterName.Equals(cluster.Name)) return false;
            return base.Contains(loc);
        }

        /// <inheritdoc/>
        public override bool ContainsIgnoreHeight(Vector3<float> loc)
        {
            var cluster = Api.Game.Cluster;
            if (cluster == null) return false;
            if (!clusterName.Equals(cluster.Name)) return false;
            return base.ContainsIgnoreHeight(loc);
        }

    }
}
