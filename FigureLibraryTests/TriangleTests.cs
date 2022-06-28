using Figures;
using Figures.Shapes;

namespace FigureLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Invalid_Initialization()
        {
            double a = 0.1;
            double b = 4;
            double c = 5;

            Assert.ThrowsException<Exception>(() => new Triangle(a, b, c));
        }
        [TestMethod]
        public void Perimetr_3and4and5_returns12()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 12;

            Shape triangle = new Triangle(a, b, c);
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsRight_9and12and15_returnsTrue()
        {
            double a = 9;
            double b = 12;
            double c = 15;

            Triangle triangle = new Triangle(a, b, c);

            bool actual = triangle.IsRight();

            Assert.IsTrue(actual);
        }
    }
}