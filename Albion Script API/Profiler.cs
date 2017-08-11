using System.Collections.Generic;

namespace Ennui.Api
{
    /// <summary>
    /// Represents a specific scope in the profile. Used as a psuedo-range
    /// for benchmarking a stretch of code.
    /// </summary>
    public class ProfilerScope
    {
        /// <summary>
        /// The name of this scope.
        /// </summary>
        public string Name;
        /// <summary>
        /// The timer used to track the runtime of this scope.
        /// </summary>
        public ITimer Timer;
        /// <summary>
        /// The  runtime captured when profiling last stopped.
        /// </summary>
        public long ElapsedMs;

        /// <summary>
        /// Begins tracking the runtime for this scope.
        /// </summary>
        public void Begin()
        {
            Timer = new Timer();
        }

        /// <summary>
        /// Stops tracking the runtime for this scope.
        /// </summary>
        /// <returns>The total runtime.</returns>
        public long End()
        {
            ElapsedMs = Timer.ElapsedMs;
            Timer = null;
            return ElapsedMs;
        }
    }

    /// <summary>
    /// Provides functionality for benchmarking code runtime.
    /// </summary>
    public class Profiler
    {
        private Dictionary<string, ProfilerScope> scopes = new Dictionary<string, ProfilerScope>();

        /// <summary>
        /// Begins tracking the runtime for a specific scope.
        /// </summary>
        /// <param name="scope">The name of the scope to start tracking.</param>
        public void Begin(string scope)
        {
            ProfilerScope section;
            if (!scopes.TryGetValue(scope, out section))
            {
                section = new ProfilerScope();
                section.Name = scope;
                scopes.Add(scope, section);
            }
            section.Begin();
        }

        /// <summary>
        /// Stops tracking the runtime for a specific scope.
        /// </summary>
        /// <param name="scope">The name of the scope to stop tracking.</param>
        /// <returns>The total elapsed time of the scope.</returns>
        public long End(string scope)
        {
            ProfilerScope section;
            if (scopes.TryGetValue(scope, out section))
            {
                return section.End();
            }
            return -1;
        }

        /// <summary>
        /// A list of all scopes registered to this profiler.
        /// </summary>
        public ICollection<ProfilerScope> Scopes
        {
            get { return scopes.Values;  }
        }
    }
}
