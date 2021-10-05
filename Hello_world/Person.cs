using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//kromě metod se do třídy dají psát i properties a konstruktory
//třída je šablona, podle které se vytvářejí konkértní instanc
namespace Hello_world
{
    class Person
    {
        public Person()  //prázdný konstruktor //jednotlivé osoby jsou jednotlivé instance
        {
            FirstName = "John"; //defaultní hodnoty
            LastName = "Doe";
        }
        public Person(string firstName, string lastName) //parametry s malym písmenem
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(string firstName, string lastName, int vek) 
        {
            FirstName = firstName; 
            LastName = lastName;
            Age = vek;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string GetFullName()  //nepíšeme static --> z toho vyplývá, že máme přístup k instančním metodám třídy (jméno, věk) vs statické metody
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()  //přepsání původní metody ToString
        {
            return GetFullName();
        }
    }
}


