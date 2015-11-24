using _01.Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Paths
{
    public class Path3D
    {
        private List<Point3D> points = new List<Point3D>();

        public Path3D()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }

        public void Add(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}
