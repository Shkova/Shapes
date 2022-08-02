using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {

        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public class VariableNegativeException : Exception { }
        public class VariableZeroException : Exception { }
        public class AreaNegativeException : Exception { }
        public class AreaZeroException : Exception { }
        public class OutOfBoundException : Exception { }
        public override double area()
        {
            if(this.height < 0 || this.width < 0)
            {
                throw new VariableNegativeException();
            }else if (this.height == 0 || this.width == 0)
            {
                throw new VariableZeroException();
            }
            else
            {
                if((this.height * this.width)> double.MaxValue)
                {
                    throw new OutOfBoundException();
                }
                double answer = this.height * this.width;
                if (answer < 0)
                    throw new AreaNegativeException();
                else if (answer == 0)
                    throw new AreaZeroException();
                else
                    return answer;


            }  
        }

        public class PerimeterNegativeException : Exception { }
        public class PerimeterZeroException : Exception { }
        public override double perimeter()
        {
            if (this.height < 0 || this.width < 0)
            {
                throw new VariableNegativeException();
            }
            else if (this.height == 0 || this.width == 0)
            {
                throw new VariableZeroException();
            }
            else
            {
                if ((2 * (this.height + this.width)) > double.MaxValue)
                {
                    throw new OutOfBoundException();
                }
                double answer = 2 * (this.height + this.width);
                if (answer < 0)
                    throw new PerimeterNegativeException();
                else if (answer == 0)
                    throw new PerimeterZeroException();
                else
                    return answer;
            }
        }
        public class DivisionByZeroException : Exception { }
        public double devision()
        {
            var denominator = 0;
            double answer = (this.height + this.width) / denominator;
            if(denominator == 0)
            {
                throw new DivisionByZeroException();
            }
            return answer;
        }

        public class HightLessThanWidthException : Exception {}
        public double subtraction()
        {
            double answer = this.height - this.width;

            if (answer < 0)
                throw new HightLessThanWidthException();
            
            return answer;
        }

        public double area2()
        { 
            double answer = 2 * this.height * this.width;
            if (answer < 0)
                throw new AreaNegativeException();
            else if (answer == 0)
                throw new AreaZeroException();
            else
                return answer;
        }

        public double perimeter2()
        {
            double answer = 2 * (this.height + this.width); ;
            if (answer < 0)
                throw new PerimeterNegativeException();
            else if (answer == 0)
                throw new PerimeterZeroException();
            else
                return answer;
        }
    }
}
