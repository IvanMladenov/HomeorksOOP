using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace DistanceCalculator
{
    class DistanceCalcMain
    {
        static void Main(string[] args)
        {
            Point3D.Point a = new Point3D.Point(1, 2, 3);
            Point3D.Point b = new Point3D.Point(7, 8, 9);

            Console.WriteLine(DistanceCalculator.CalculateDistance(a, b));
        }
    }
}
