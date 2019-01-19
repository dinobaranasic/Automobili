using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class ElektricniAuto : Auto
    {
        public int DometPrijedenogPuta;

        void ispisiElektricniAutomobil()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", Marka, Model, Gorivo, DometPrijedenogPuta);
        }
    }
}
