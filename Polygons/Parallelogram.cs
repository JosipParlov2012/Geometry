using System;

namespace Geometry.Polygons
{
    
    public class Parallelogram : Polygon
    {
        
        private readonly Triangle _triangleA;
        private readonly Triangle _triangleB;

        public Parallelogram(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            _triangleA = new Triangle(pointD, pointA, pointC);
            _triangleB = new Triangle(pointA, pointB, pointC);
            
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
            return _triangleA.Perimeter() + _triangleB.Perimeter();
        }
        
    }
    
}
