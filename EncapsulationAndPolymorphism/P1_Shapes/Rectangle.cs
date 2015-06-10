using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Rectangle:BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double area = this.Width*this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2*(this.Width+this.Height);
            return perimeter;
        }
    }
}
