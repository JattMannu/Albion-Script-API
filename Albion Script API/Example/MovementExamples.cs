using Ennui.Api.Method;
using Ennui.Api.Util;
using System;

namespace Ennui.Api.Example
{
    public class MovementExamples : ApiResource
    {
        public MovementExamples(IApi api) : base(api)
        {
        }

        public void MoveWithModifiers(string internalClusterName, Vector3<float> destination)
        {
            var area = new Vector3f(0.0f, 0.0f, 0.0f).Expand(3.0f, 3.0f, 3.0f);

            var pfc = new PointPathFindConfig();

            // make black clusters a last resort
            pfc.ClusterModifiers.Add(c =>
            {
                if (c.Type == Meta.ClusterType.PvpBlack)
                {
                    return 100000.0f;
                }
                return 0.0f;
            });

            // set tiles around the area to unwalkable
            pfc.ClippingModifiers.Add(c =>
            {
                for (var x = area.Start.X; x < area.End.X + 1; x++)
                {
                    for (var z = area.Start.Z; z < area.End.Z + 1; z++)
                    {
                        var conv = Collision.LocToGrid(x, z);
                        c[conv.X, conv.Y] = false; 
                    }
                }
            });

            // add a random weighting to each tile, making paths 'random'
            pfc.WeightingModifiers.Add((x, y) =>
            {
                return (float) RandomUtils.NextDouble() * 10.0f;
            });

            pfc.Point = destination;
            pfc.ClusterName = internalClusterName;

            Movement.PathFindTo(pfc);
        }
    }
}
