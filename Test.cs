using Geometry.Polygons;

using System;
using System.Collections.Generic;

namespace Geometry
{
    
    public static class Test
    {
        
        private static void Main()
        {
            List<Polygon> polygons = new List<Polygon>
            {
                new Rectangle(new Point(0, 0), new Point(2, 4)),
                new Square(new Point(0, 0), new Point(2, 2)),
                new Triangle(new Point(0, 0), new Point(0, 4), new Point(4, 0)),
                new Parallelogram(new Point(0, 0), new Point(2, 3), new Point(6, 3), new Point(4, 0))
            };


            foreach (Polygon polygon in polygons)
            {
                Type super = polygon.GetType().UnderlyingSystemType;
                
                // Shared properties.
                Console.WriteLine(
                    super.Name +
                    "\nPovrsina: " + polygon.Area() +
                    "\nOpseg: " + polygon.Perimeter()
                );

                if (super == typeof(Triangle))
                {
                    Triangle triangle = (Triangle) polygon;
                    Console.WriteLine(
                        "Je pravokutan: " + triangle.IsPythagorean() +
                        "\nJe jednakostranican: " + triangle.IsEquilateral() +
                        "\nJe jednakokracan: " + triangle.IsIsosceles()
                    );
                }

                // Separate polygon output.
                Console.WriteLine();
            }
        }
        
    }
    
}
