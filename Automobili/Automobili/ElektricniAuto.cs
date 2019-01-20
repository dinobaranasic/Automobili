using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class ElektricniAuto : Auto
    {

        public ElektricniAuto() : base("", "", "")
        {
            // Ovo je način da se izbjegne nužnost unosa podataka
            // međutim nije nešto što je općenito preporučljivo.
            // Ukoliko je u baznom razredu podrazumijevani kosntruktor 
            // izostavljen, vjerojatno postoji i razlog zašto je to tako
        }

        public ElektricniAuto(string Marka, string Model, string Gorivo) : base(Marka, Model, Gorivo)
        {
            //napisani konstruktor koji prima tri paremetra isto kao i u baznom razredu
        }

    }
}
