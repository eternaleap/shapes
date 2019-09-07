using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Circle(13.3),
                new Triangle(2.4, 5, 5),
                new Triangle(6, 6, 6)
            };

            new AreaCalculator().CalculateAreas(shapes);
        }
    }
}
