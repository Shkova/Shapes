using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
using static Shapes.Rectangle;

namespace testShapes
{
    [TestClass]
    public class pentagonTest
    {
        [TestMethod]
        public void PentagonAreaPositiveResult()
        {
            Pentagon pentagon = new Pentagon(2.2);
            double answer = pentagon.area();
            double expectedResult = 8.32;
            Assert.AreEqual(expectedResult, answer, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(VariableNegativeException))]
        public void PentagonAreaVariableNegativeException()
        {
            Pentagon pentagon = new Pentagon(-2.2);
            double answer = pentagon.area();
        }

        [TestMethod]
        [ExpectedException(typeof(VariableZeroException))]
        public void PentagonAreaVariableZeroException()
        {
            Pentagon pentagon = new Pentagon(0);
            double answer = pentagon.area();
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfBoundException))]
        public void PentagonAreaOutOfBoundException()
        {
            Pentagon pentagon = new Pentagon(99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.9999999999);
            double answer = pentagon.area();
        }

        [TestMethod]
        public void PentagonPerimeterPositiveResult()
        {

            Pentagon pentagon = new Pentagon(2.2);
            double answer = pentagon.perimeter();
            double expectedResult = 11;
            Assert.AreEqual(expectedResult, answer, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(VariableNegativeException))]
        public void PentagonPerimeterVariableNegativeException()
        {
            Pentagon pentagon = new Pentagon(-2.2);
            double answer = pentagon.perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(VariableZeroException))]
        public void PentagonPerimeterVariableZeroException()
        {
            Pentagon pentagon = new Pentagon(0);
            double answer = pentagon.perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfBoundException))]
        public void PentagonPerimeterOutOfBoundException()
        {
            Pentagon pentagon = new Pentagon(99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999.9999999999);
            double answer = pentagon.perimeter();
        }

    }
}
