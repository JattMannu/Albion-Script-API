using System;
using System.Collections.Generic;
using Ennui.Api.Method;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public abstract class LocatableFilterChain<T, R> : FilterChain<T, R> where T : Locatable where R : FilterChain<T, R>
	{
		public LocatableFilterChain(IApi api, List<T> list) : base(api, list)
		{

		}

		public R ExcludeByLocation(params Vector3<float>[] locs)
		{
			if (locs == null || locs.Length ==  0) return Create(AsList);
			return Filter(new ExcludeLocationFilter(locs));
		}

		public R ExcludeByArea(params IArea<float>[] areas)
		{
			if (areas == null || areas.Length == 0) return Create(AsList);
			return Filter(new ExcludeAreaFilter(areas));
		}

		public R FilterByArea(params IArea<float>[] areas)
		{
			return Filter(new AreaFilter(areas));
		}

		public T Closest(Vector3<float> center)
		{
			return Api.Game.Sync<T>(() =>
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

		public class ExcludeLocationFilter : Filter<T>
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

		public class ExcludeAreaFilter : Filter<T>
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

		public class AreaFilter: Filter<T>
		{
			private IArea<float>[] areas;

			public AreaFilter(params IArea<float>[] areas)
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

