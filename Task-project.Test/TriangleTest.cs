using SquareCalcLib;

namespace Task_project.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void isTriangleTest()
        {
            //data
            double a = 1;
            double b = 10;
            double c = 20;

            bool result = false;

            var triangle = new Triangle();
            

            //act

            var isTriangle = triangle.IsTriangle(a,b,c);

            //assert

            Assert.AreEqual(result, isTriangle);
        }

        [TestMethod]
        public void isRightTest()
        {
            //data
            double a = 3, b = 4, c = 5;

            bool result = true;

            //act

            var triangle = new Triangle();

            var isRight = triangle.IsRight();
            //assert

            Assert.AreEqual(result, isRight);
        }
        [TestMethod]
        public void TriangleSquareTest()
        {
            //data
            double a = 3, b = 4, c = 5;

            double result = 6;

            //act

            var triangle = new Triangle(a, b, c);

            var s = triangle.Square();

            //assert

            Assert.IsNotNull(s);
            Assert.AreEqual(result, s);
        }
    }
}