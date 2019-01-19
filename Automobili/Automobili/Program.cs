using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZADATAK
             * Stvoriti popis automobila; programsku podršku
             * za razne primjene gdje je potreban popis automobila
             */

            Auto d1 = new Auto();
            d1.Marka = "Audi";
            d1.Model = "A7";
            d1.Gorivo = "Dizel";

            Auto b1 = new Auto();
            b1.Marka = "BMW";
            b1.Model = "5";
            b1.Gorivo = "Benzin";

            Auto e1 = new Auto();
            e1.Marka = "Rimac";
            e1.Model = "Concept One";
            e1.Gorivo = "Elektricni";

            List<Auto> auti = new List<Auto>();

            auti.Add(d1);
            auti.Add(b1);
            auti.Add(e1);

        }
    }
}
