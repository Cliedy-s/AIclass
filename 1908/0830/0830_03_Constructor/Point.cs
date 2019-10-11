using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_03_Constructor
{
    public class Point
    {
        double x, y; // public double x, y => 은닉성 위배

        public Point() { this.x = 0; this.y = 0; }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point b)
        {
            double xdiff = this.x - b.x;
            double ydiff = this.y - b.y;

            return Math.Sqrt(xdiff * xdiff + ydiff * ydiff);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.x, this.y);
        }
    }
}
