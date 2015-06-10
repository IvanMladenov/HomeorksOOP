using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class ProgramTest
    {
        static void Main()
        {

            List<IShape> shapes = new List<IShape>()
            {
                 new Circle(11.3),
                 new Rectangle(3.57,9.4),
                 new Triangle(14,8,20.5),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}",shape.GetType().Name);
                Console.WriteLine("Area= {0}\nPerimeter= {1}",shape.CalculateArea(),shape.CalculatePerimeter());
                Console.WriteLine();
            }

        }

    }
}
