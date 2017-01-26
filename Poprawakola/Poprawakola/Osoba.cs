using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawakola
{
   abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int podstawa;
        virtual public void ObliczPensje(int Podstawa)
        {
            
            Console.WriteLine(this.podstawa);
        }
        public Osoba (string Imie,string Nazwisko, int Podstawa)
        {
            this.imie = Imie;
            this.nazwisko = Nazwisko;
            this.podstawa = Podstawa;
        }
    }

}
