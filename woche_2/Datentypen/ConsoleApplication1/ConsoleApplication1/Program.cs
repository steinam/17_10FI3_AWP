using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int day = 1;
            int month = 3;

            DM(20, 7, out day, out month);

        }



        public static void DM(int jt, int year, out int day, out int month)
        {
            int l, j, k, d, m;
            l = 0;
            Console.WriteLine(year/4);
            Console.ReadLine();
            if ((year / 4) * 4 == year)

            {
                l = 1;
            }
            k = 0;
            if (jt > (59 + l))
            {
                k = 2 - l;
            }

            j = jt + k + 91;
            m = (j * 100) / 3055;
            d = j - (m * 3055) / 100;
            m = m - 2;
            month = m;
            day = d;
        }
    }
}
