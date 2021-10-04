using System;

//C++ - jazyk vs .NET - platforma, kompilátor, runtime
//středník na konec příkazu
//metoda se deklaruje (static) +  datový typ výstupu + název metody + (vstup do metody)
//klíčové slovo var  dokáže datový formát rozpoznat a nastavit - explicitně(dané programátorem) vs implicitně (vybírá var) nastavení formátu 
//namepsace - sekce kodu, organizace, členění
//class 

namespace Hello_world
{
	class Program //
	{
		static void Main(string[] args)  //metoda main; void = nená návratový typ
		{
			Console.WriteLine("Hello World!");
			int sum = Add(5, 3);
			Console.WriteLine(sum);
			int soucet = AddAndPrint(6, 3);
			int soucet_2 = soucet + 1;
			Console.WriteLine(soucet_2);
			Hello("Vojta");
			//	Console.WriteLine(suma);

			int a = 20;
			int b = 30;
			Console.WriteLine($"a: {a}, b:{b}");


			int c = a;
			int d = b;

			 a = d;
			 b = c;


			Console.WriteLine($"a: {a}, b:{b}");


		}

		
		static int Add(int a, int b)
		{
			return a + b;  //return ukončuje metodu vše zatím je ignorováno
		}
		static int AddAndPrint(int a, int b)  //int = návratový typ; (a, b)= proměnné
		{
			/*int*/ var suma = a + b;
			//int suma = a + b;
			Console.WriteLine(suma);
			Console.WriteLine($"vysledek souctu {a} + {b} = {suma}");  //interpolated string
			return suma;
		}
		static void Hello(string jmeno)
		{
			Console.WriteLine($"Hello,tvoje jméno: {jmeno}");
		}




	}
}
