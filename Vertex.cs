using System;

namespace Geometry
{
    
    public class Vertex
    {
        
        public Point Point1 { get; }
        public Point Point2 { get; }

        private Vertex() {}
        
        public Vertex(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public float Length()
        {
            return (float) Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
        }

        public bool EqualLength(Vertex other)
        {
            return Util.FloatEquals(Length(), other.Length());
        }

    }
    
}
