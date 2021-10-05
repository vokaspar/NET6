using System;

//C++ - jazyk vs .NET - platforma, kompilátor, runtime
//středník na konec příkazu
//metoda se deklaruje (static) +  datový typ výstupu + název metody + (vstup do metody)
//klíčové slovo var  dokáže datový formát rozpoznat a nastavit - explicitně(dané programátorem) vs implicitně (vybírá var) nastavení formátu  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
//		The literal without suffix or with the d or D suffix is of type double
//		The literal with the f or F suffix is of type float
//		The literal with the m or M suffix is of type decimal
//		DateTime date = new DateTime(1999, 12, 31);
//namepsace - sekce kodu, organizace, členění
//class 

//int[] numbers = new[] { 10, 11, 12, 13, 20, 67 };
//for (int i =0; numbers.Lenght;i++)
//    {
//        var num = numbers [i];
//        Console.WriteLine(num);
//    }

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
//int counter = 0;
//while (counter <5)
//{
//    counter++;
//}

namespace Hello_world
{
	class Program //
	{
		static void Main(string[] args)  //metoda main; void = nená návratový typ
        {
            //  prvni_den();
           // Console.WriteLine("Napis co je potreba:");
            //var input = Console.ReadLine();
            //var input_int = int.Parse(input);

            //  Console.WriteLine(generace(input)); //VYPIS GENERACI
            //  Console.WriteLine(den_v_tydnu(input)); //VYPIS den v tydnu
            //  Suda_konec(input_int);
            //  Soucet_do_cisla(input_int);

            Person p1 = new Person();   //vytvořili jsme intance třídy(šablony) person, new = konstruktor

            p1.FirstName = "Adam";
            p1.LastName = "Smith";
            p1.Age = 30;

            Person p3 = new Person("Milan", "Pešek");

            p3.Age = 36;

            Person p4 = new Person("Adela", "pešková",46);


            Console.WriteLine($"Osoba:{p1.GetFullName()},{p1},{p3},{p3.Age},{p4},{p4.Age}"); //díky instanční mětode , kterou jsme přepsali původní to_string, je to totožné









        }

        private static void Soucet_do_cisla  (int input_int)
        { var x = 0;
          var y = "";
        
            for (int i = 1; i <= input_int; i++)
            {
                x = x + i;
                y =  y  + i + "+";

               // numbers = Add[i] { i };
            }

            Console.WriteLine($"Soucet  {y}= {x}");

        }

        private static void Suda_konec(int input_int)
        {
            while (input_int % 2 != 0)  //%zbytek po deleni dvojkou
            {
                Console.WriteLine($"Cislo liche: {input_int}, napis dalsi: ");
                input_int = int.Parse(Console.ReadLine());
                

            }

            
        }

        private static string Den_v_tydnu (string input)
        {
            var input_int = int.Parse(input);
           switch(input_int)
            {
                case 1:
                    return "pondělí";
                   // break; //nemusí být, když je předtím return
                case 2:
                    return "úterý";
                case 3:
                    return "středa";
                case 4:
                    return "čtvrtek";
                case 5:
                    return "pátek";
                case 6:
                case 7:
                    return "víkend";

                default:
                    return "zkontroluj si den";

            }

        }

        private static string Generace(string input)
        {
            var input_int = int.Parse(input);
            var x = "generace";
            if (input_int < 1946)
                x = "N/A";
            else if (input_int < 1965 && input_int >=1946)
                x = "Baby Boomerss";
            else if (input_int < 1981)
                x = "Generation X";
            else if (input_int < 1997)
                x = "Millenials";
            else if (input_int < 2013)
                x = "Generation Z";
            else if (input_int <= 2021)
                x = "Generation Alpha";
            else x = $"Zkontroluj si zadany rok{x}";

            return x;
        }

        private static void Prvni_den()
        {
            Console.WriteLine("Hello World!");
            int sum = Add(5, 3);
            Console.WriteLine(sum);
            int soucet = AddAndPrint(6, 3);
            int soucet_2 = soucet + 1;
            Console.WriteLine(soucet_2);
            Hello("Vojta");
            //	Console.WriteLine(suma);

            int a = 30;
            int b = 30;
            Console.WriteLine($"a: {a}, b:{b}");


            Console.WriteLine($"Vetsi z cisel {a} a {b} je {VetsiMensi(a, b)}");

            const int c_a = 155;
            const int c_b = 255;

            var a2 = 255;
            var b2 = 5;

            // zjistit jestli "a" je vetsi nez "b"
            // ale pokud "a" je kterakoliv z konstant
            // tak vrat false (tzn jakoby a v tomto pripade bylo vzdy mensi)

            bool result;

            if (a2 == c_a || a == c_b)
                result = false;
            else if (a2 > b2)
                result = true;
            else
                result = false;

            Console.WriteLine($"Vetsi z cisel {a2} a {b2} je {result}");

            /*Console.WriteLine("Napis sve jmeno:");
			var input = Console.ReadLine();
			Hello(input);

			int num = int.Parse(input); //převod stringu na číslo
			string str = num.ToString(); //převod čísla na string
			double doub = (double)num;
			*/

            teplota_F_C.Prevod_F_C();
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
			 if (jmeno == "Bob" || jmeno == "Alice")
            if (jmeno.ToLower() == "bob" || jmeno.ToLower() == "alice")
                Console.WriteLine($"Welcome back {jmeno}");
            else
                Console.WriteLine($"Hello {jmeno}");

			/*
				  if (name == "Bob" || name == "Alice")
			   if (name.ToLower() == "bob" || name.ToLower() == "alice")
				   Console.WriteLine($"Welcome back {name}");
			   else
				   Console.WriteLine($"Hello {name}");

			  */
		}
		static string VetsiMensi(int a, int b)  //int = návratový typ; (a, b)= proměnné
		{
			int c;
			if (a > b)
			{//nejsou potřeba závorky, pokud je jen jeden příkaz
			 //Console.WriteLine($"Vetsi z cisel {a} a {b} je {a}");
				c = a;
				return c.ToString();
			}
			else if (a == b)
				return "stejné";
			{
				c = b;
				return c.ToString();
			}


		}
		



	}
}
