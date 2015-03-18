namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            var testShapes = new List<Shape>
            {
                new Triangle(3.2, 4),
                new Rectangle(6, 7),
                new Circle(2),
                new Triangle(5, 2)
            };

            foreach (var shape in testShapes)
            {
                Console.WriteLine(
                    "Figure {0,9} --> surface = {1:F2}",
                    shape.GetType().Name,
                    shape.CalculateSurface());
            }
        }
    }
}
