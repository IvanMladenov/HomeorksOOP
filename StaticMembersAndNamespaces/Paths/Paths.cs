using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace Paths
{
    class Paths
    {
        static void Main(string[] args)
        {
            string path = @"file.txt";
            List<string> pointAsString = new List<string>();
            Storage.ReadFile(path, pointAsString);
            Path3D listOfPoints = new Path3D();
            Storage.ConvertToPoints(pointAsString, listOfPoints);

            Console.WriteLine(listOfPoints);
        }
    }
}
