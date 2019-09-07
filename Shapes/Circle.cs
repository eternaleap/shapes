using System;

namespace Shapes
{
    public sealed class Circle : Shape
    {
        double _radius;

        public Circle(double radius)
        {
            _radius = radius;    
        }

        public override double GetArea() => Math.PI * (_radius * _radius);
    }
}
