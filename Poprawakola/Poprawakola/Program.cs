using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawakola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> pracownicy = new List<Osoba>();

            pracownicy.Add(new Pracownik("Andrzej", "Duda" , 1200, 100));
            pracownicy.Add(new Pracownik("Donald", "Trump", 1300, 100));
            pracownicy.Add(new Pracownik("Angela", "Merkel", 1400, 100));
            pracownicy.Add(new Pracownik("Wladimir", "Putin", 1100, 100));
            pracownicy.Add(new Pracownik("Fidel", "Castro", 1000, 100));
            pracownicy.Add(new Pracownik("Barack", "Obama", 1010, 100));
            pracownicy.Add(new Pracownik("Vincent", "Kompany", 1220, 100));
            pracownicy.Add(new Pracownik("Saddam", "Hussain", 1120, 100));
            pracownicy.Add(new Pracownik("Joanna", "D'Arc", 1205, 100));
            pracownicy.Add(new Pracownik("Felipe", "Santana", 4500, 100));

            foreach (var e in pracownicy)
            {
                Console.WriteLine(pracownicy.ToString());
            }
                Console.ReadKey();
                Console.ReadLine();
            
        }
    }
}
