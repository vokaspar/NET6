using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class Point
    {
        public static Point GetDefaultPoint()
        {
            return new Point (100,100);
        }

        public Point(double x, double y) //parametry s malym písmenem
        {
            if (x < 0 || y < 0)
                throw new Exception("Neplatné argumenty, X i Y musí být vetší než 0");
            X = x;
            Y = y;
        }
        public double X { get; set; }

        public double Y { get; set; }
        public override string ToString()  //přepsání původní metody ToString
        {
            return "Souřadnice X: " + X + ", souřadnice Y: " + Y;
        }

        public double obsah()
        {
            return X * Y;
        }

    }
}
