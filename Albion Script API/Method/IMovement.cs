using Ennui.Api.Direct.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Represents a result of a path finding operation.
    /// </summary>
    public enum PathFindResult
    {
        /// <summary>
        /// Represents a success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Represents a failure.
        /// </summary>
        Failed = 1,
    }

    /// <summary>
    /// Represents configuration for a path finding operation.
    /// </summary>
    public class PathFindConfig
    {
        /// <summary>
        /// The name of the map cluster to path find in.
        /// </summary>
        public string ClusterName;

        /// <summary>
        /// A hook that will be called every time the bot attempts to walk, to see
        /// if we should exit early.
        /// </summary>
        public Func<bool> ExitHook;

        /// <summary>
        /// If the web will be used to aid in path finding.
        /// </summary>
        public bool UseWeb = true;

        /// <summary>
        /// If the local player's mount will be used.
        /// </summary>
        public bool UseMount = true;

        /// <summary>
        /// If we should apply random weighting in the internal path finding algorithm.
        /// </summary>
        public bool ApplyRandomWeighting = true;

        /// <summary>
        /// The amount of random weighting (from 0 - RandomWeighting) to apply to each tile, where 1.0 is the default weighting to 2 tiles
        /// adjacent to one another.
        /// </summary>
        public double RandomWeighting = 2.0D;
    }

    /// <summary>
    /// Represents configuration for a path finding operation, where the target is a static 3d point.
    /// </summary>
    public class PointPathFindConfig : PathFindConfig
    {
        /// <summary>
        /// The point to path find to.
        /// </summary>
        public Vector3<float> Point = null;
    }

    /// <summary>
    /// Represents configuration for a path finding operation, where the target is a resource.
    /// </summary>
    public class ResourcePathFindConfig : PathFindConfig
    {
        /// <summary>
        /// The harvestable object to path find to.
        /// </summary>
        public IHarvestableObject Target;
    }

    /// <summary>
	/// Provides a set of static utility methods for movement.
	/// </summary>
    public interface IMovement : IApiModule
    {
        /// <summary>
		/// Walks to a specified location within the currently loaded map region.
		/// </summary>
		/// <returns><c>true</c>, if we walked successfully, <c>false</c> otherwise.</returns>
		/// <param name="loc">Location.</param>
		bool WalkTo(Vector3<float> loc);

        /// <summary>
        /// Finds a path to a specified location, and walks the path.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="config">The config to use for path finding.</param>
        PathFindResult PathFindTo(PointPathFindConfig config);

        /// <summary>
        /// Finds a path to the specified harvestable, and walks the path.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="config">The config to use for path finding.</param>
        PathFindResult PathFindTo(ResourcePathFindConfig config);

        /// <summary>
        /// Repeatedly finds a path to a random vertex within the web, and walks the path until the condition is met.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="config">The configuration to use for path finding.</param>
        PathFindResult PathRandomly(PathFindConfig config);

        /// <summary>
        /// Finds a path to a specified location, and walks the path.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="clusterName">The destination cluster name.</param>
        /// <param name="loc">The destination 3d location. If this is null, the bot will stop once it enters the cluster.</param>
        [Obsolete("Use PathFindTo(PointPathFindConfig) instad")]
        PathFindResult PathFindTo(string clusterName, Vector3<float> loc = null);

        /// <summary>
        /// Finds a path to the specified harvestable, and walks the path.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="target">The destination harvestable.</param>
        /// <param name="clusterName">The destination cluster name.</param>
        [Obsolete("Use PathFindTo(ResourcePathFindConfig) instad")]
        PathFindResult PathFindTo(IHarvestableObject target, string clusterName);

        /// <summary>
        /// Repeatedly finds a path to a random vertex within the web, and walks the path until the condition is met.
        /// </summary>
        /// <returns>The result from the path finding.</returns>
        /// <param name="clusterName">The destination cluster name</param>
        /// <param name="exitHook">The delegate that tells the both when to stop path finding.</param>
        [Obsolete("Use PathRandomly(PathFindConfig) instad")]
        PathFindResult PathRandomly(string clusterName, Func<bool> exitHook);
    }
}
