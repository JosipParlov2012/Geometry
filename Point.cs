namespace Geometry
{
    
    public class Point
    {
        
        public float X { get; }
        public float Y { get; }
        
        private Point() {}

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public bool EqualsX(Point other)
        {
            return Util.FloatEquals(X, other.X);
        }

        public bool EqualsY(Point other)
        {
            return Util.FloatEquals(Y, other.Y);
        }

        public bool Equals(Point other)
        {
            return EqualsX(other) && EqualsY(other);
        }
        
    }
    
}
