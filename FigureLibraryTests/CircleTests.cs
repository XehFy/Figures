using Figures;
using Figures.Shapes;

namespace FigureLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Invalid_Initialization()
        {
            double Radius = -3;

            Assert.ThrowsException<Exception>(() => new Circle(Radius));
        }
        [TestMethod]
        public void Area5_returnsPixRsquared()
        {
            double r = 5;
            double expected = Math.PI * r * r;

            IShape circle = new Circle(5);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Perimeter7_returns2xPixR()
        {
            double r = 7;
            double expected = Math.PI * r * 2;

            IShape circle = new Circle(7);
            double actual = circle.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}
