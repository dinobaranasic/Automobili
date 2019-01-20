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

            //Nije moguće stvoriti objekt Auto bez podataka
            // Auto a1 = new Auto();
            // a1.PostaviMarku("BMW");
            // a1.PostaviModela("5");
            // a1.PostaviGorivo("Benzin");

            //ispisivanje pomocu napravljene metode za ispis
            // a1.IspisiMarkaModelGorivo();


            //Nije moguće stvoriti objekt Auto bez podataka
            //Auto a2 = new Auto();
            //a2.PostaviMarku("Audi");
            //a2.PostaviModela("A7");
            //a2.PostaviGorivo("Dizel");
            //a2.IspisiMarkaModelGorivo();


            //Nije moguće stvoriti objekt Auto podataka
            //Korištenje svojstva za dodjelu vrijednosti
            //Auto a3 = new Auto();
            //a3.marka="Rimac";
            //a3.model = "Concept One";
            //a3.gorivo = "Elektricni";
            //a3.IspisiMarkaModelGorivo();

            //Stvaranje objekta Auto pomoću konstruktora koji smo izradili i prima 3 parametra
            Auto a1 = new Auto("BMW", "5", "Benzin");
            Auto a2 = new Auto("Audi", "A7", "Dizel");
            Auto a3 = new Auto("Rimac", "Concept One", "Elektricni");

            List<Auto> auti = new List<Auto>();
            auti.Add(a1);
            auti.Add(a2);
            auti.Add(a3);

            BenzinskiAuto b1 = new BenzinskiAuto();
            b1.marka = "VW";
            b1.model = "Golf R";
            b1.gorivo = "Benzin";
            b1.CijenaPunogRezervaraBenzina = 550;

            DizelskiAuto d1 = new DizelskiAuto();
            b1.marka = "Porsche";
            b1.model = "Panamera";
            b1.gorivo = "Dizel";

            ElektricniAuto e1 = new ElektricniAuto();
            e1.marka = "Tesla";
            e1.model = "Model S";
            e1.gorivo = "Elektricni";

            BenzinskiAuto b2 = new BenzinskiAuto("Ferrari", "812 superfast", "Benzin", 600);
            DizelskiAuto d2 = new DizelskiAuto("VW", "Arteon", "Dizel");
            ElektricniAuto e2 = new ElektricniAuto("Rimac", "Concept Two", "Elektricni");

            Console.WriteLine("Ispiši automobil: ");
            Console.WriteLine(b2.DohvatiGorivo());



        }
    }
}
