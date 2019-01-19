using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class Auto
    {
        //Sakrivanje podataka, onemogucavanje pristupa
        private string Marka;
        private string Model;
        private string Gorivo;
        private bool provjera = true; //primjer podatak koji nema/netreba javne get/set metode

        //Metoda za postavljanje podataka "Marka"
        public void PostaviMarku(string Marka)
        {
            this.Marka = Marka;
        }

        //Metoda za postavljanje podataka "Model"
        public void PostaviModela(string Model)
        {
            this.Model = Model;
        }

        //Metoda za postavljanje podataka "Gorivo"
        public void PostaviGorivo(string Gorivo)
        {
            this.Gorivo = Gorivo;
        }

        //Metoda za dohvat podataka "Marka"
        public string DohvatiMarku()
        {
            return Marka;
        }

        //Metoda za dohvat podataka "Model"
        public string DohvatiModel()
        {
            return Model;
        }

        //Metoda za dohvat podataka "Gorivo"
        public string DohvatiGorivo()
        {
            return Gorivo;
        }

        //Metoda za ispis podataka "Marka, Model, Gorivo"
        public void IspisiMarkaModelGorivo()
        {
            Console.WriteLine("{0}, {1}, {2}", Marka, Model, Gorivo);
        }

    }
}
