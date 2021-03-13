using System;

namespace Geometry.Polygons
{
    
    public class Rectangle : Polygon
    {
        
        private readonly Vertex _width;
        private readonly Vertex _height;

        public Rectangle(Point corner1, Point corner2)
        {
            if (corner1.EqualsX(corner2)) throw new ArgumentException("same corner X");
            if (corner1.EqualsY(corner2)) throw new ArgumentException("same corner Y"); 
            
            _width = new Vertex(new Point(corner1.X, corner1.Y), new Point(corner2.X, corner1.Y));
            _height = new Vertex(new Point(corner2.X, corner1.Y), new Point(corner2.X, corner2.Y));
        }

        public override float Area()
        {
            return _width.Length() * _height.Length();
        }

        public override float Perimeter()
        {
            return 2 * (_width.Length() + _height.Length());
        }

    }
    
}
