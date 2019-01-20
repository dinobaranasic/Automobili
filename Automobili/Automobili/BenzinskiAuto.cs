using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class BenzinskiAuto : Auto
    {
        public int CijenaPunogRezervaraBenzina;
        //Svojstvo CijenaPunogRezervaraBenzina
        public int cijenapunogrezervarabenzina { get => CijenaPunogRezervaraBenzina; set => CijenaPunogRezervaraBenzina = value; }

        public BenzinskiAuto() : base("", "", "")
        {
            // Ovo je način da se izbjegne nužnost unosa podataka
            // međutim nije nešto što je općenito preporučljivo.
            // Ukoliko je u baznom razredu podrazumijevani kosntruktor 
            // izostavljen, vjerojatno postoji i razlog zašto je to tako
        }

        public BenzinskiAuto(string Marka, string Model, string Gorivo) : base(Marka, Model, Gorivo)
        {
            //napisani konstruktor koji prima tri paremetra isto kao i u baznom razredu
        }

        //Konstruktor koji prima jos dodatni jedan parametar koji se odnosi samo na Benzinski automobil
        public BenzinskiAuto(string Marka, string Model, string Gorivo, int CijenaPunogRezervaraBenzina) : base(Marka, Model, Gorivo)
        {
            this.CijenaPunogRezervaraBenzina = CijenaPunogRezervaraBenzina;
        }


    }
}
