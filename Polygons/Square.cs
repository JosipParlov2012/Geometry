using System;

namespace Geometry.Polygons
{
    
    public class Square : Polygon
    {
        
        private readonly Vertex _vertex;

        public Square(Point corner1, Point corner2)
        {
            if (corner1.EqualsX(corner2)) throw new ArgumentException("same corner X");
            if (corner1.EqualsY(corner2)) throw new ArgumentException("same corner Y");

            float diffX = Math.Abs(corner1.X - corner2.X);
            float diffY = Math.Abs(corner1.Y - corner2.Y);
            if (!Util.FloatEquals(diffX, diffY)) throw new ArgumentException("corner not equally offset to form square");
            
            _vertex = new Vertex(new Point(corner1.X, corner1.Y), new Point(corner2.X, corner1.Y));
        }
        
        public override float Area()
        {
            return (float) Math.Pow(_vertex.Length(), 2);
        }

        public override float Perimeter()
        {
            return 4 * _vertex.Length();
        }
        
    }
    
}
