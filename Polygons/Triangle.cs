using System;

namespace Geometry.Polygons
{
    
    public class Triangle : Polygon
    {
        
        public Vertex VertexAB { get; }
        public Vertex VertexBC { get; }
        public Vertex VertexCA { get; }

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            if (pointA.Equals(pointB)) throw new ArgumentException("A same as B");
            if (pointB.Equals(pointC)) throw new ArgumentException("B same as C");
            if (pointC.Equals(pointA)) throw new ArgumentException("C same as A");

            VertexAB = new Vertex(pointA, pointB);
            VertexBC = new Vertex(pointB, pointC);
            VertexCA = new Vertex(pointC, pointA);
        }
        
        public override float Area()
        {
            float s = Perimeter() / 2;
            return (float) Math.Sqrt(s * (s - VertexAB.Length()) * (s - VertexBC.Length()) * (s - VertexCA.Length()));
        }

        public override float Perimeter()
        {
            return VertexAB.Length() + VertexBC.Length() + VertexCA.Length();
        }

        /**
         * Je li trokut pravokutan?
         */
        public bool IsPythagorean()
        {
            float a = VertexAB.Length();
            float b = VertexBC.Length();
            float c = VertexCA.Length();
            return Util.IsPythagorean(a, b, c) || Util.IsPythagorean(a, c, b) || Util.IsPythagorean(b, c, a);
        }

        /**
         * Je li trokut jednakostranican?
         */
        public bool IsEquilateral()
        {
            return VertexAB.EqualLength(VertexBC) && VertexBC.EqualLength(VertexCA) && VertexCA.EqualLength(VertexAB);
        }

        /**
         * Je li trokut jednakokracan?
         */
        public bool IsIsosceles()
        {
            if (VertexAB.EqualLength(VertexBC) && !VertexCA.EqualLength(VertexAB) && !VertexCA.EqualLength(VertexAB)) return true;
            if (VertexAB.EqualLength(VertexCA) && !VertexBC.EqualLength(VertexAB) && !VertexBC.EqualLength(VertexCA)) return true;
            if (VertexBC.EqualLength(VertexCA) && !VertexAB.EqualLength(VertexBC) && !VertexAB.EqualLength(VertexCA)) return true;
            return false;
        }

    }
    
}
