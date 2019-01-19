using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    class Auto
    {
        public string Marka;
        public string Model;
        public string Gorivo;

        public void ispisiMarkaModelGorivo()
        {
            Console.WriteLine("{0}, {1}, {2}", Marka, Model, Gorivo);
        }
    }
}
