using SquareCalcLib;

namespace Task_project.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleSquareTest()
        {
            //data
            double r = 5;

            double result = 78.54;

            //act

            var circle = new Circle(5);

            var square = circle.Square();

            //assert

            Assert.AreEqual(result, square);
        }
    }
}
