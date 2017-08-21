using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Represents a 3d area within the game world.
	/// </summary>
	public class Area : IArea<float>
    {
        private Vector3<float> start;
        private Vector3<float> end;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ennui.Api.Area"/> class.
        /// </summary>
        /// <param name="start">The start coordinate of the area.</param>
        /// <param name="end">The end coordinate of the area.</param>
        public Area(Vector3<float> start, Vector3<float> end)
        {
            this.start = start;
            this.end = end;
        }

        public Area(float x0, float y0, float z0, float x1, float y1, float z1)
            : this(new Vector3f(x0, y0, z0), new Vector3f(x1, y1, z1))
        {

        }

        public Vector3<float> Start
        {
            get { return start; }
        }

        public Vector3<float> End
        {
            get { return end; }
        }

        public IArea<float> Expand(float x, float y, float z)
        {
            return new Area(start.Translate(-x, -y, -z), end.Translate(x, y, z));
        }

        public virtual bool Contains(Vector3<float> loc)
        {
            return
                loc.X >= start.X && loc.X <= end.X &&
                loc.Y >= start.Y && loc.Y <= end.Y &&
                loc.Z >= start.Z && loc.Z <= end.Z;
        }

        public virtual bool ContainsIgnoreHeight(Vector2<float> loc)
        {
            return
                loc.X >= start.X && loc.X <= end.X &&
                loc.Y >= start.Z && loc.Y <= end.Z;
        }

        public virtual bool ContainsIgnoreHeight(Vector3<float> loc)
        {
            return
                loc.X >= start.X && loc.X <= end.X &&
                loc.Z >= start.Z && loc.Z <= end.Z;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("[Area: start={0} end={1}]", start, end);
        }
    }
}
