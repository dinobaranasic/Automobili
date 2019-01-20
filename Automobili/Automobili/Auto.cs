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
        protected string Marka;
        protected string Model;
        protected string Gorivo;

        // Izraditi razred tako da ...
        // Sadrži konstruktor kojim se postavljaju podaci, 
        // onemogućiti stvaranje objekta bez podataka.
        /*
        public Auto()
        {
            // Onemogućavanje stvaranja objekta bez podataka -->
            // izostaviti podrazumijevani konstruktor iz koda 
            //  i izraditi drugi(e) konstruktore
        }
        */

        //Konstruktor koji prima 3 parametra(Marka, Model, Gorivo)
        public Auto(string Marka, string Model, string Gorivo)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Gorivo = Gorivo;
        }

        //Svojstvo Marka
        public string marka
        {
            get
            {
                return Marka;
            }

            set
            {
                Marka = value;
            }
        }

        //Svojstvo marka moze pisati i na nacin:
        //public string marka { get => Marka; set => Marka = value; }

        //Stvojstvo Model
        //public string model
        //{
        //    get
        //    {
        //        return Model;
        //    }

        //    set
        //    {
        //        Model = value;
        //    }
        //}

        //Svojstvo model moze pisati i na nacin:
        public string model { get => Model; set => Model = value; }

        //Svojstvo Gorivo
        public string gorivo { get => Gorivo; set => Gorivo = value; }

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
        public virtual string DohvatiGorivo()
        {
            return "Gorivo" + Gorivo;
        }

        //Metoda za ispis podataka "Marka, Model, Gorivo"
        public void IspisiMarkaModelGorivo()
        {
            Console.WriteLine("{0}, {1}, {2}", Marka, Model, Gorivo);
        }

    }
}
