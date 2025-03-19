using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distance(Point2D point)
        {
            return Math.Sqrt(Math.Pow(point.x - this.x, 2) + Math.Pow(point.y - this.y, 2));
        }
    }
}
