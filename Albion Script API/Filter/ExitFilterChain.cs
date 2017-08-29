using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class ExitFilterChain : SimulationFilterChain<IExitObject, ExitFilterChain>
    {
        public ExitFilterChain(IApi api, List<IExitObject> list) : base(api, list)
        {
        }

        /// <summary>
        /// Filters exits by the cluster they're pointing to (internal name as identifier.)
        /// </summary>
        /// <param name="internalClusterName">The cluster name to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public ExitFilterChain FilterByInternalClusterName(string internalClusterName)
        {
            return Filter(new InternalClusterNameFilter(internalClusterName));
        }

        private class InternalClusterNameFilter : Filter<IExitObject>
        {
            private string internalClusterName;

            public InternalClusterNameFilter(string internalClusterName)
            {
                this.internalClusterName = internalClusterName;
            }

            public bool Ignore(IExitObject t)
            {
                var bound = t.BoundCluster;
                if (bound == null)
                    return true;

                var cluster = bound.Unbound;
                if (cluster == null)
                    return true;

                return !cluster.InternalName.Equals(internalClusterName);
            }
        }

        protected override ExitFilterChain Create(List<IExitObject> elements)
        {
            return new ExitFilterChain(Api, elements);
        }
    }
}
