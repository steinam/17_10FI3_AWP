using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Konto
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank DeuBa = new Bank();
            DeuBa.KundeAnlegen("Steinam", 100.01);
        }
    }
}
