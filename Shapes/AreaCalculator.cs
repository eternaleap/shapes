using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    public sealed class AreaCalculator
    {
        public double CalculateArea(Shape shape) => shape.GetArea();

        public IEnumerable<double> CalculateAreas(IEnumerable<Shape> shapes) => shapes.Select(s => s.GetArea());
    }
}
