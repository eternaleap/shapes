using System;

namespace Shapes
{
    public sealed class Triangle : Shape
    {
        private readonly double _h;
        private readonly double _c1;
        private readonly double _c2;

        public Triangle(double a, double b, double c)
        {
            if (a > b)
            {
                _h = a;
                _c1 = b;
            }
            else
            {
                _h = b;
                _c1 = a;
            }

            if (_h > c)
            {
                _c2 = c;
            }
            else
            {
                _c2 = _h;
                _h = c;
            }
        }

        public override double GetArea()
        {
            if (IsRightTriangle)
            {
                return (_c1 * _c2) / 2;
            }

            var s = (_h + _c1 + _c2) / 2;
            return Math.Sqrt(s * (s - _h) * (s - _c1) * (s - _c2));
        }

        public bool IsRightTriangle => (_h * _h) == ((_c1 * _c1) + (_c2 * _c2));
    }
}
