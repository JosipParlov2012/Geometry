using System;

namespace Geometry.Polygons
{
    
    public class Parallelogram : Polygon
    {
        
        private readonly Triangle _triangleA;
        private readonly Triangle _triangleB;

        private readonly Vertex _a;
        private readonly Vertex _b;

        public Parallelogram(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            _triangleA = new Triangle(pointA, pointB, pointC);
            _triangleB = new Triangle(pointA, pointD, pointC);

            _a = _triangleA.VertexAB;
            _b = _triangleB.VertexAB;
            
            if (Util.FloatEquals(_triangleA.Perimeter(), _triangleB.Perimeter())) return;
            if (_triangleA.IsEquilateral() && _triangleB.IsEquilateral()) return;
            throw new ArgumentException("not quadrilateral");
        }
        
        public override float Area()
        {
            return _triangleA.Area() + _triangleB.Area();
        }

        public override float Perimeter()
        {
            return 2 * (_a.Length() + _b.Length());
        }
        
    }
    
}
