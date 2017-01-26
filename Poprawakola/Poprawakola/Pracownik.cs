using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawakola
{
    class Pracownik : Osoba
    {
        protected int staz;

      public override void ObliczPensje(int Podstawa)
        {
            base.podstawa = base.podstawa + staz * 100;
            Console.WriteLine(this.podstawa);
        }
        public Pracownik(string Imie, string Nazwisko, int Podstawa, int staz): base(Imie, Nazwisko, Podstawa) //konstruktor parametryczny
        {
            base.imie = Imie;
            base.nazwisko = Nazwisko;
            base.podstawa = Podstawa;
            this.staz = staz; 
        }
        public override string ToString() //przesłonięcie metody
        {
            return "Pracownik: " + imie + nazwisko + ", podstawa + " + podstawa + " staż:" +staz;
        }

    } 
}
