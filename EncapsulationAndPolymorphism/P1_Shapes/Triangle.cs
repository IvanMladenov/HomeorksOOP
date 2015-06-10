using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Triangle:BasicShape
    {
        public Triangle(double a, double b, double c) : base(a, b)
        {
            this.C = c;
        }

        public double C { get; set; }

        public override double CalculateArea()
        {
            double halfPerimeter = this.CalculatePerimeter()/2;
            
            double area = Math.Sqrt(halfPerimeter*(halfPerimeter-this.Height)*(halfPerimeter-this.Width)*(halfPerimeter-this.C));
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.C + this.Width + this.Height;
            return perimeter;
        }
    }
}
