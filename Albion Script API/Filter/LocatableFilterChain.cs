using System;
using System.Collections.Generic;

using Ennui.Api.Object;
using Ennui.Api.Util;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for locatables.
    /// </summary>
    /// <typeparam name="T">The type of locatable to filter. You know you can't just have one type of locatable.</typeparam>
    /// <typeparam name="R">The type of chain to return for chained method calls.</typeparam>
	public abstract class LocatableFilterChain<T, R> : FilterChain<T, R> where T : Locatable where R : FilterChain<T, R>
	{
		public LocatableFilterChain(IApi api, List<T> list) : base(api, list)
		{

		}

        /// <summary>
        /// Filters out all values that have one of the provided locations.
        /// </summary>
        /// <param name="locs">The locations to filter out.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R ExcludeByLocation(params Vector3<float>[] locs)
		{
			if (locs == null || locs.Length ==  0) return Create(AsList);
			return Filter(new ExcludeLocationFilter(locs));
		}

        /// <summary>
        /// Filters out all values that are in one of the provided areas.
        /// </summary>
        /// <param name="areas">The areas to filter with.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R ExcludeByArea(params IArea<float>[] areas)
		{
			if (areas == null || areas.Length == 0) return Create(AsList);
			return Filter(new ExcludeAreaFilter(areas));
		}

        /// <summary>
        /// Filters out all values that aren't in any of the provided areas.
        /// </summary>
        /// <param name="areas">The areas to filter with.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R IncludeByArea(params IArea<float>[] areas)
		{
			return Filter(new ExludeWithoutAreaFilter(areas));
		}

        /// <summary>
        /// Finds the closest value relative to the center.
        /// </summary>
        /// <param name="center">The relative point to calculate distance on.</param>
        /// <returns>The closest value.</returns>
		public T Closest(Vector3<float> center)
		{
			return Game.Sync<T>(() =>
			{
				T closest = default(T);
				var closestDistance = int.MaxValue;
				foreach (T t in AsList)
				{
                    if (t == null)
                        continue;

                    var sim = t as ISimulationObject;
                    if (sim != null && !sim.IsValid)
                        continue;

					var loc = t.Location;
                    if (loc == null)
                        continue;

					var dist = 0;
					dist += (int) Math.Abs(center.X - loc.X);
					dist += (int) Math.Abs(center.Y - loc.Y);
					dist += (int) Math.Abs(center.Z - loc.Z);
					if (dist < closestDistance)
					{
						closest = t;
						closestDistance = dist;
					}
				}
				return closest;
			});
		}

		private class ExcludeLocationFilter : Filter<T>
		{
			private Vector3<float>[] locs;

			public ExcludeLocationFilter(params Vector3<float>[] locs)
			{
				this.locs = locs;
			}

			public bool Ignore(T t)
			{
				foreach (var loc in locs)
				{
					if (t.Location.Equals(loc))
					{
						return true;
					}
				}
				return false;
			}
		}

        private class ExcludeAreaFilter : Filter<T>
		{
			private IArea<float>[] areas;

			public ExcludeAreaFilter(params IArea<float>[] areas)
			{
				this.areas = areas;
			}

			public bool Ignore(T t)
			{
				foreach (var area in areas)
				{
					if (area.Contains(t.Location))
					{
						return true;
					}
				}
				return false;
			}
		}

        private class ExludeWithoutAreaFilter : Filter<T>
		{
			private IArea<float>[] areas;

			public ExludeWithoutAreaFilter(params IArea<float>[] areas)
			{
				this.areas = areas;
			}

			public bool Ignore(T t)
			{
				var loc = t.Location;
				if (loc == null) return true;

				foreach (var area in areas)
				{
					if (area.Contains(loc))
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}

