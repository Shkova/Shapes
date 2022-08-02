using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shapes.Rectangle;

namespace Shapes
{
    public class Pentagon : Shape
    {
        public double length { get; set; }

        public Pentagon(double length)
        {
            this.length = length;
        }

        public override double area()
        {
            if (this.length < 0)
                throw new VariableNegativeException();
            else if (this.length == 0)
                throw new VariableZeroException();
            if ((((double)1 / 4) * (Math.Sqrt((5 * (5 + (2 * (Math.Sqrt(5))))))) * (Math.Pow(this.length, 2.0))) > double.MaxValue)
            {
                throw new OutOfBoundException();
            }
            double answer = ((double)1 / 4) * (Math.Sqrt((5 * (5 + (2 * (Math.Sqrt(5))))))) * (Math.Pow(this.length, 2.0));
            return answer;
        }

        public override double perimeter()
        {
            if (this.length < 0)
                throw new VariableNegativeException();
            else if (this.length == 0)
                throw new VariableZeroException();
            if ((5 * this.length) > double.MaxValue)
            {
                throw new OutOfBoundException();
            }
            double answer = 5 * this.length;
            return answer;
        }
    }
}
