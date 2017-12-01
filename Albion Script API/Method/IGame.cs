using Ennui.Api.Meta;
using Ennui.Api.Util;
using System.Collections.Generic;

namespace Ennui.Api.Method
{
    /// <summary>
    /// A task which will be executed on the game's engine thread.
    /// </summary>
    public delegate void EngineTask();

    /// <summary>
	/// Does something, and returns something.
	/// </summary>
	public delegate T GenericTask<T>();

    /// <summary>
    /// Does something, and returns nothing.
    /// </summary>
    public delegate void Task();

    /// <summary>
	/// Provides a set of static utilities for interfacing with the game.
	/// </summary>
	public interface IGame : IApiModule
    {
        /// <summary>
        /// Executes the provided task on the game thread, and blocks until it returns.
        /// a value.
        /// </summary>
        /// <param name="task">The task to run on the game thread.</param>
        /// <typeparam name="T">The type of value that the task returns.</typeparam>
        T Sync<T>(GenericTask<T> task);

        /// <summary>
        /// Executes the provided task on the game thread, and blocks until it returns.
        /// a value.
        /// </summary>
        /// <param name="task">The task to run on the game thread.</param>
        /// <param name="events">The type of events that should catch the task.</param>
        /// <typeparam name="T">The type of value that the task returns.</typeparam>
        T Sync<T>(GenericTask<T> task, params GameEvent[] events);

        /// <summary>
        /// Executes the provided task on the game thread, and blocks until it returns.
        /// </summary>
        /// <param name="task">The task to execute on the game thread.</param>
        void Sync(EngineTask task);

        /// <summary>
        /// Executes the provided task on the game thread, and blocks until it returns.
        /// </summary>
        /// <param name="task">The task to execute on the game thread.</param>
        ///  <param name="events">The type of events that should catch the task.</param>
        void Sync(EngineTask task, params GameEvent[] events);

        /// <summary>
        /// Retrieves the general state of the game.
        /// </summary>
        /// <value>The general state of the game.</value>
        GameState State { get; }

        /// <summary>
        /// Retrieves the value indicating whether or not the game has a loading screen.
        /// </summary>
        /// <value><c>true</c> if in loading screen; otherwise, <c>false</c>.</value>
        bool InLoadingScreen { get; }

        /// <summary>
        /// Checks if the local player is downed on the ground.
        /// </summary>
        /// <value><c>true</c> if is downed; otherwise, <c>false</c>.</value>
        bool IsDowned { get; }

        /// <summary>
        /// Attempts to logout from the game.
        /// </summary>
        bool Disconnect();

        /// <summary>
        /// Retrieves the number of hostile players in the currently loaded area.
        /// </summary>
        /// <value>The number of hostile players in the currently loaded area.</value>
        int HostilesInArea { get; }

        /// <summary>
        /// Retrieves the number of friendly players in the currently loaded area.
        /// </summary>
        /// <value>The number of friendly players in the currently loaded area.</value>
        int FriendliesInArea { get; }

        /// <summary>
        /// Retrieves the collision grid of the game. This contains information about
        /// which tiles are or are not blocked.
        /// </summary>
        /// <value>The collision grid of the game.</value>
        ICollisionGrid CollisionGrid { get; }

        /// <summary>
        /// Gets the currently loaded map cluster.
        /// </summary>
        /// <value>The cluster.</value>
        IMapCluster Cluster { get; }

        /// <summary>
        /// Gets the name of the currently loaded map cluster.
        /// </summary>
        /// <value>The name of the cluster.</value>
        string ClusterName { get; }

        /// <summary>
        /// Gets the internal name of the currently loaded map cluster.
        /// </summary>
        /// <value>The internal name of the cluster.</value>
        string InternalClusterName { get; }

        /// <summary>
        /// The size of the game screen.
        /// </summary>
        /// <value>The size of the game screen.</value>
        Vector2<int> ScreenSize { get; }

        /// <summary>
        /// Places the currently held object.
        /// </summary>
        /// <returns><c>true</c>, if the object was placed, <c>false</c> otherwise.</returns>
        bool PlaceObject();

        /// <summary>
        /// Converts a 3d coordinate to 2d screen space.
        /// </summary>
        /// <param name="pos">The 3d coordinate to project.</param>
        /// <returns><c>null</c> If the 3d point isn't visible, otherwise the projected point.</returns>
        Vector2<float> ProjectToScreen(Vector3<float> pos);

        /// <summary>
        /// All spell effect areas within the scene.
        /// </summary>
        List<ISpellEffectArea> SpellEffectAreas { get; }

        /// <summary>
        /// Calculates the height of the tile at the provided coordinates.
        /// </summary>
        /// <returns>The height of the tile at the provided coordinates.</returns>
        /// <param name="pos">The coordinates to get the height at.</param>
        float GetTileHeight(Vector2<float> pos);

        /// <summary>
        /// Whether or not input is enabled.
        /// </summary>
        bool InputEnabled { set; }
    }
}
