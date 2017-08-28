using Ennui.Api.Util;

namespace Ennui.Api.Method
{
    public interface IGeometryUtils
    {
        bool TransformArcMesh(IMesh mesh, IMeshData backing, float f1, float f2, float f3, float f4, float f5, int i1, int i2);
        void TransformCircleMesh(IMesh mesh, IMeshData backing, float radius, int i1);
        void TransformRectMesh(IMesh mesh, IMeshData backing, float width, float height);
    }
}
