using Ennui.Api.Direct;

using System.Collections.Generic;

namespace Ennui.Api.Example
{
    public class SpellEffectGeometry : ApiResource
    {
        public SpellEffectGeometry(IApi api) : base(api)
        {
        }

        private void ParseChild(List<IMesh> meshes, IGeometryNode node)
        {
            var children = node.Children;
            foreach (var child in children)
            {
                var asNode = child.AsNode();
                if (asNode != null)
                {
                    ParseChild(meshes, asNode);
                }

                var asArc = child.AsArc();
                if (asArc != null)
                {
                    var mesh = Factories.CreateMesh();
                    var data = Factories.CreateMeshData();
                    GeometryUtils.TransformArcMesh(mesh, data, 0 /* border */, asArc.GetParam1(), asArc.GetParam2(), -0.008726646f * asArc.GetParam3(), 0.01745329f * asArc.GetParam3(), 0x18, 1);
                    meshes.Add(mesh);
                }

                var asCircle = child.AsCircle();
                if (asCircle != null)
                {
                    var mesh = Factories.CreateMesh();
                    var data = Factories.CreateMeshData();
                    GeometryUtils.TransformCircleMesh(mesh, data, asCircle.GetRadius() + 0 /* border */, 0x30);
                    meshes.Add(mesh);
                }

                var asRectangle = child.AsRectangle();
                if (asRectangle != null)
                {
                    var mesh = Factories.CreateMesh();
                    var data = Factories.CreateMeshData();
                    GeometryUtils.TransformRectMesh(mesh, data, asRectangle.GetWidth() + 0 /* border */, asRectangle.GetHeight() + 0 /* border */);
                    meshes.Add(mesh);
                }
            }
        }

        public List<IMesh> BuildSpellEffectMeshes()
        {
            List<IMesh> meshes = new List<IMesh>();
            foreach (var seao in Objects.SpellEffectAreas)
            {
                var context = seao.Context;
                var sea = context.SpellEffectArea;
                var desc = sea.GeometryDescriptor;

                var outline = desc.Outline;
                if (outline != null)
                    ParseChild(meshes, outline);

                var fill = desc.Fill;
                if (fill != null)
                    ParseChild(meshes, fill);
            }
            return meshes;
        }
    }
}
