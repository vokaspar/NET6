using System;

namespace Hello_world
{
	class Program //
	{
		static void Main(string[] args)  //metoda main; void = nená návratový typ
		{
			Console.WriteLine("Hello World!");
			int sum = Add(5, 3);
			Console.WriteLine(sum);
			AddAndPrint(6, 3);
			Hello("Vojta");
		//	Console.WriteLine(suma);
			
		}

		
		static int Add(int a, int b)
		{
			return a + b;  //return ukončuje metodu vše zatím je ignorováno
		}
		static void Hello(string jmeno)
		{
			Console.WriteLine($"Hello,tvoje jméno: {jmeno}");
		}
		static int AddAndPrint(int a, int b)  //int = návratový typ; (a, b)= proměnné
		{
			int suma = a + b;
			Console.WriteLine(suma);
			Console.WriteLine($"vysledek souctu {a} + {b} = {suma}");  //interpolovaný
			return suma;
		}




	}
}
