using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Point2D
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point2D()
        { }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double dist2D(Point2D p)
        {
            double res = 0;

            res = Math.Sqrt(((p.y - p.x) * (p.y - p.x)) + ((p.y - p.x) * (p.y - p.x)));

            return res;

        }
        public void printDistance(double d)
        {

        }
    }

    public class Point3D : Point2D
    {
        public int z { get; set; }

        public Point3D(int z)
        {
            this.z = z;
        }
        public double dist3D(Point3D p)
        {
            double res = 0;


            return res;

        }
        public void printDistance(double d)
        {

        }
    }

}
