using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class BenzinskiAuto : Auto
    {
        public int PotrosnjaBenzina;

        void ispisiBenzinskiAutomobil()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", Marka, Model, Gorivo, PotrosnjaBenzina);
        }
    }
}
