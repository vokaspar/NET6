using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class Point
    {
        public Point(double x, double y) //parametry s malym písmenem
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }

        public double Y { get; set; }
        public override string ToString()  //přepsání původní metody ToString
        {
            return "Souřadnice X: " + X + ", souřadnice Y: " + Y;
        }

    }
}
