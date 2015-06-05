using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace Paths
{
    class Path3D
    {
        private List<Point> path=new List<Point>();

        public Path3D()//(List<Point> path)
        {
            this.Path = path;
        }

        public List<Point> Path 
        {
            get { return this.path; }
            set
            {
                this.path = value;
            }
        }

        public override string ToString()
        {
            StringBuilder current = new StringBuilder();
            foreach (var item in path)
            {
                current.AppendLine(item.ToString());
            }
            return current.ToString();
        }

        //public void AddPointToPath(Point point)
        //{
        //    var currentPath = this.Path;
        //    currentPath.Add(point);
        //    this.Path = currentPath;
        //}
    }
}
