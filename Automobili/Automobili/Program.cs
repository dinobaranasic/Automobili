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

            string marka1 = "BMW";
            string model1 = "5";

            string marka2 = "Audi";
            string model2 = "A7";

            string marka3 = "VW";
            string model3 = "Arteon";

            // BMW, 5 ; Audi, A7 ; VW, Arteon

            Console.WriteLine("Popis osoba:");
            Console.WriteLine("1. {0}, {1}", marka1, model1);
            Console.WriteLine("2. {0}, {1}", marka2, model2);
            Console.WriteLine("3. {0}, {1}", marka3, model3);

            /*
             * Koliki je potencijal ovog rješenja da se jednostavno primijeni za podatke novih 10 automobila?
             * Novih 20 automobila? Novih 100 automobila? 1000 automobila? ....
             * Kolika je mogućnost primjene ovog rješenja uz porast količine podataka 
             * tj. posla koji on mora odraditi? 
             * Kolika je skalabilnost? 
             */
        }
    }
}
