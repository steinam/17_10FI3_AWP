using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {

            short note1 = 4;
            short note2 = 2;
                                   //1. Berechnung der Multiplikation gibt int
                             //2. Versuch, den int in ewin short zu casten
            short noteend = (short)(note1 * note2);



            var result = 5.0 / 3.0;
            int result2 = 5 / 3;
            double result3 = 5 / 3;

            Console.WriteLine(result);
            Console.WriteLine(result2);


            Console.ReadLine();













        }
    }
}
