using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Point3D;

namespace Paths
{
    static class Storage
    {
        //string path = @"";
        //List<string> pointsList = new List<string>();
        
        public static void ReadFile(string path, List<string> points)
        {
            var allLines = File.ReadAllLines(path);
            foreach (var item in allLines)
            {
                string currentLine = item.ToString();
                points.Add(currentLine);
            }
        }

        public static void ConvertToPoints(List<string>lines, Path3D points)
        {
            foreach (string item in lines)
            {
               
                int[] xyz = item.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                Point current = new Point(xyz[0],xyz[1],xyz[2]);
                points.Path.Add(current);
            }
        }
    
    

    }
}
