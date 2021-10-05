using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class teplota_F_C
    {
        public static void Prevod_F_C()
        {
            Console.WriteLine("Stupne F");
            double input_double;
            var input = Console.ReadLine();
            input_double = Double.Parse(input);



            Console.WriteLine($" {input_double} Stupnu F je  {Teplota(input_double)} stupnu C");  //interpolated string
        }

        static double Teplota(double a)  //int = návratový typ; (a, b)= proměnné
        {
            /*int*/
            //Chcete-li převést teploty ve stupních Fahrenheita na Celsia, odečtěte 32 a vynásobte je. 5556 (nebo 5/9).
            var celsius = (a - 32) * 0.5556;
            //int suma = a + b;

            return Math.Round(celsius, 2);
        }


    }
}
