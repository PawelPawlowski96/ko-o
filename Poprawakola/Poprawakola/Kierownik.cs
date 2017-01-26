using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawakola
{
    class Kierownik : Osoba
    {
        private int iloscPodwladnych;
        public override void ObliczPensje(int iloscPodwladnych)
        {
            base.podstawa = base.podstawa + iloscPodwladnych * 7;
            Console.WriteLine(this.podstawa);
        }
        public Kierownik(string Imie, string Nazwisko, int Podstawa, int iloscPodwladnych): base(Imie, Nazwisko, Podstawa) //konstruktor parametryczny
        {
            base.imie = Imie;
            base.nazwisko = Nazwisko;
            base.podstawa = Podstawa;
            this.iloscPodwladnych = iloscPodwladnych; 
        }
        public override string ToString() //przesłonięcie metody
        {
            return "Kierownik: " + imie + nazwisko + ", podstawa + " + podstawa + " ilość podwładnych" + iloscPodwladnych;
        }

    }
}
