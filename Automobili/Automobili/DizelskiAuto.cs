using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class DizelskiAuto : Auto
    {
        public int Potrosnjadizela;

        void ispisiDizelsiAutomobil()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", Marka, Model, Gorivo, Potrosnjadizela);
        }
    }
}
