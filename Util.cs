using System;

namespace Geometry
{
    
    public static class Util
    {

        public static bool FloatEquals(float a, float b)
        {
            return Math.Abs(a - b) < float.Epsilon;
        }

        public static bool IsPythagorean(float a, float b, float c)
        {
            return FloatEquals((float) Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), c);
        }
        
    }
    
}
