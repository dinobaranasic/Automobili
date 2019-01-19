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

            /*
             * Što nije dobro?
             * We Enjoy Typing? Write Everytinh Twice? Waste Everyone's Time? WET! 
             * We have a WET solution.
             * DRY -> Don't Repeat Yourself (The Pragmatic Programmer)
             */

            string[] marka = { "BMW", "Audi", "VW" };
            string[] model = { "5", "A7", "Arteon" };

            Console.WriteLine("Popis osoba:");
            for (int i = 0; i < marka.Length; i++)
            {
                Console.WriteLine("{0}. {1}, {2}", i, marka[i], model[i]);
            }

        }
    }
}
