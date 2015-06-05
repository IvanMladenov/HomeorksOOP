using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Point a, Point b)
        {
            double dX = a.X - (double)b.X;
            double dY = a.Y - (double)b.Y;
            double dZ = a.Z - (double)b.Z;
            
            double distance = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2) + Math.Pow(dZ, 2));
            return distance;
        }
    }
}
