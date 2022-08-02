using Shapes;
using static Shapes.Rectangle;

namespace testShapes
{
    [TestClass]
    public class rectangleTest
    {
        [TestMethod]
        public void rectangleAreaPositiveResult()
        {

            Rectangle rectangle = new Rectangle(2.2, 2.1);
            double answer = rectangle.area();
            double expectedResult = 4.62;
            Assert.AreEqual(expectedResult, answer, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(VariableNegativeException))]
        public void rectangleAreaNegativeLength()
        {
            Rectangle rectangle = new Rectangle(-2.2, -2.1);
            double answer = rectangle.area();
        }

        [TestMethod]
        [ExpectedException(typeof(VariableZeroException))]
        public void rectangleAreaZeroLength()
        {
            Rectangle rectangle = new Rectangle(0, 2.1);
            double answer = rectangle.area();
        }

        [TestMethod]
        [ExpectedException(typeof(AreaZeroException))]
        public void rectangleAreaZeroResult()
        {
            Rectangle rectangle = new Rectangle(0, -2.1);
            double answer = rectangle.area2();
        }

        [TestMethod]
        [ExpectedException(typeof(AreaNegativeException))]
        public void rectangleAreaNegativeResult()
        {
            Rectangle rectangle = new Rectangle(2, -2.1);
            double answer = rectangle.area2();
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfBoundException))]
        public void rectangleAreaOutOfBoundResult()
        {
            //Console.WriteLine(Double.MaxValue);
            Rectangle rectangle = new Rectangle(9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.2, 222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222.2);
            double answer = rectangle.area();
        }

        [TestMethod]
        public void rectanglePerimeterPositiveResult()
        {
            Rectangle rectangle = new Rectangle(2.2, 2.1);
            double answer = rectangle.perimeter();
            double expectedResult = 8.6;
            Assert.AreEqual(expectedResult, answer, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(VariableNegativeException))]
        public void rectanglePerimeterNegativeLength()
        {
            Rectangle rectangle = new Rectangle(-2.2, 2.1);
            double answer = rectangle.perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(VariableZeroException))]
        public void rectanglePerimeterZeroLength()
        {
            Rectangle rectangle = new Rectangle(2.2, 0);
            double answer = rectangle.perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(PerimeterZeroException))]
        public void rectanglePerimeterZeroResult()
        {
            Rectangle rectangle = new Rectangle(0, 0);
            double answer = rectangle.perimeter2();
        }

        [TestMethod]
        [ExpectedException(typeof(PerimeterNegativeException))]
        public void rectanglePerimeterNegativeResult()
        {
            Rectangle rectangle = new Rectangle(-2, 1);
            double answer = rectangle.perimeter2();
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfBoundException))]
        public void rectanglePerimeterOutOfBoundResult()
        {
            Rectangle rectangle = new Rectangle(99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.2, 9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.2);
            double answer = rectangle.perimeter();
        }
        

        [TestMethod]
        [ExpectedException(typeof(DivisionByZeroException))]
        public void rectangleDivisionTest()
        {
            Rectangle rectangle = new Rectangle(2, 2);
            //System.Diagnostics.Debug.WriteLine(rectangle.ToString());
            var expectedException = rectangle.devision();
        }

        [TestMethod]
        [ExpectedException(typeof(HightLessThanWidthException))]
        public void SubtractionException()
        {
            Rectangle rectangle = new Rectangle(2, 6);
            var expectedException = rectangle.subtraction();
        }

    }
}