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

            Auto a1 = new Auto();
            a1.PostaviMarku("BMW");
            a1.PostaviModela("5");
            a1.PostaviGorivo("Benzin");
           //ispisivanje pomocu napravljene metode za ispis
            a1.IspisiMarkaModelGorivo();

            Auto a2 = new Auto();
            a2.PostaviMarku("Audi");
            a2.PostaviModela("A7");
            a2.PostaviGorivo("Dizel");
            a2.IspisiMarkaModelGorivo();

            //Korištenje svojstva za dodjelu vrijednosti
            Auto a3 = new Auto();
            a3.marka="Rimac";
            a3.model = "Concept One";
            a3.gorivo = "Elektricni";
            a3.IspisiMarkaModelGorivo();

            List<Auto> auti = new List<Auto>();
            auti.Add(a1);
            auti.Add(a2);
            auti.Add(a3);
           

        }
    }
}
