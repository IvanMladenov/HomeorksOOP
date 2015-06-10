using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Circle:IShape
    {

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }      

        public double CalculateArea()
        {
            double area = Math.PI*this.Radius*this.Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2*this.Radius*Math.PI;
            return perimeter;
        }
    }
}
