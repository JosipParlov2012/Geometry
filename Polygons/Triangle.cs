using System;

namespace Geometry.Polygons
{
    
    public class Triangle : Polygon
    {
        
        private readonly Vertex _vertexA;
        private readonly Vertex _vertexB;
        private readonly Vertex _vertexC;

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            if (pointA.Equals(pointB)) throw new ArgumentException("A same as B");
            if (pointB.Equals(pointC)) throw new ArgumentException("B same as C");
            if (pointC.Equals(pointA)) throw new ArgumentException("C same as A");

            _vertexA = new Vertex(pointB, pointC);
            _vertexB = new Vertex(pointA, pointC);
            _vertexC = new Vertex(pointA, pointB);
        }
        
        public override float Area()
        {
            float s = Perimeter() / 2;
            return (float) Math.Sqrt(s * (s - _vertexA.Length()) * (s - _vertexB.Length()) * (s * _vertexC.Length()));
        }

        public override float Perimeter()
        {
            return _vertexA.Length() + _vertexB.Length() + _vertexC.Length();
        }

        /**
         * Je li trokut pravokutan?
         */
        public bool IsPythagorean()
        {
            float a = _vertexA.Length();
            float b = _vertexB.Length();
            float c = _vertexC.Length();
            return Util.IsPythagorean(a, b, c) || Util.IsPythagorean(a, c, b) || Util.IsPythagorean(b, c, a);
        }

        /**
         * Je li trokut jednakostranican?
         */
        public bool IsEquilateral()
        {
            return _vertexA.EqualLength(_vertexB) && _vertexB.EqualLength(_vertexC) && _vertexC.EqualLength(_vertexA);
        }

        /**
         * Je li trokut jednakokracan?
         */
        public bool IsIsosceles()
        {
            if (_vertexA.EqualLength(_vertexB) && !_vertexC.EqualLength(_vertexA) && !_vertexC.EqualLength(_vertexA)) return true;
            if (_vertexA.EqualLength(_vertexC) && !_vertexB.EqualLength(_vertexA) && !_vertexB.EqualLength(_vertexC)) return true;
            if (_vertexB.EqualLength(_vertexC) && !_vertexA.EqualLength(_vertexB) && !_vertexA.EqualLength(_vertexC)) return true;
            return false;
        }

    }
    
}
