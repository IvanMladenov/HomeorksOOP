using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point
    {
        private static readonly Point startingPoint = new Point(0, 0, 0);
        private int x;
        private int y;
        private int z;

        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point StartingPoint
        {
            get { return startingPoint; }
        }

        public int X
        { 
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y 
        { 
            get { return this.y; } 
            set { this.y = value; } 
        }

        public int Z 
        { 
            get { return this.z; }
            set { this.z = value; } 
        }

        public override string ToString()
        {

            return string.Format("{0} {1} {2}",this.X,this.Y,this.Z);
        }

    }
}
