using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class Point
    {
        private uint _x = 0;

        public Point(double x, double y) //parametry s malym písmenem --> konstruktor
        {
            if (x < 0 || y < 0)
                throw new Exception("Neplatné argumenty, X i Y musí být vetší než 0");
            X = x;
            Y = y;
        }
        public Point() //parametry s malym písmenem --> konstruktor
        {
           
        }
        public double X { get; set; }  //vlastnosti(property)

        public double Y { get; set; } //vlasnost(property)

        public double Z { get; set; } = 0; //vlasnost --> 0=defaultní nastavení

        public uint _X //getter a setter --> používá se pokud get nebo set chceme kódem modifikovat, jinak je to vlastnost viz řádky výše
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public override string ToString()  //přepsání původní metody ToString
        {
            return "Souřadnice X: " + X + ", souřadnice Y: " + Y + ", souřadnice Z: " + Z;
        }

        public  string ToString2()  => "Souřadnice X: " + X + ", souřadnice Y: " + Y + ", souřadnice Z: " + Z; // zjednodušení zápisu
     

        public double obsah() //instanční metoda
        {
            return X * Y;
        }
        public static Point GetDefaultPoint()
        {
            return new Point(100, 100);   //volám konstruktor
        }

    }
}
