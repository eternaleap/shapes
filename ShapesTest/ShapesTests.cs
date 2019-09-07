using Shapes;
using Xunit;

namespace ShapesTest
{
    public class ShapesTests
    {
        [Theory]
        [InlineData(13, 530)]
        [InlineData(99, 30790)]
        public void TestCircleCalc(double radius, int result)
        {
            Assert.Equal((int)result, (int)new Circle(radius).GetArea());
        }

        [Theory]
        [InlineData(13, 13, 13, 73, false)]
        [InlineData(50, 56, 44, 1050, false)]
        [InlineData(4, 5, 3, 6, true)]
        public void TestTriangleCalc(double a, double b, double c, int result, bool isRight)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(triangle.IsRightTriangle, isRight);
            Assert.Equal((int)result, (int)triangle.GetArea());
        }
    }
}
