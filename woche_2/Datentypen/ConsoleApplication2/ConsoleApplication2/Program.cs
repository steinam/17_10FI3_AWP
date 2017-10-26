using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            operatorplusplus(x++);

            Console.WriteLine(x);

            //int e = 5 << 2;

            //Console.WriteLine(e);


//            tageslohn();
  //          fussgesteuert();
            Console.ReadLine();
        }



        static void tageslohn()
        {


            int Gesamtverdienst = 0;
            int Tag = 0;
            int Tageslohn = 1;

            while (Gesamtverdienst < 40000)
            {
                Tag++;
                Gesamtverdienst += Tageslohn;
                Tageslohn *= 2;
                

            }

            Console.WriteLine(Tag);
            Console.WriteLine(Gesamtverdienst);
            Console.WriteLine(Tageslohn/2);
            Console.ReadLine();


        }


        static void fussgesteuert()
        {
            int Gesamtverdienst = 0;
            int Tag = 0;
            int Tageslohn = 1;

            do
            {
                Tag++;
                Gesamtverdienst += Tageslohn;
                Tageslohn *= 2;


            } while (Gesamtverdienst < 40000);

        Console.WriteLine(Tag);
        Console.WriteLine(Gesamtverdienst);
        Console.WriteLine(Tageslohn/2);
        Console.ReadLine();


        }

        static void forSchleife()
        {

            for (int i = 0; i < = 20; i++)
            {
                



            }
        }


        static void operatorplusplus(int x)
        {

            

            int a = x++ * x++;
            Console.WriteLine(a);
        }


        static void einseitig()
        {
            int a = 4;
            int b = 5;

            // nur true wird ausgewertet
            if(a > b)
            {

                Console.WriteLine("A ist größer b");

            }



        }


        static void zweiseitig()
        {
            int a = 4;
            int b = 5;

            // nur true wird ausgewertet
            if (a > b)
            {

                Console.WriteLine("A ist größer b");

            }
            else
            {
                Console.WriteLine("A ist kleiner gleich b");



            }



        }

        static void mehrseitig()
        {
            string ort = "Stuttgar";
            int tage = 10;
            int prov = 0;

            if (ort == "Hamburg")
            {

                prov = tage * 100;

            }
            else if (ort == "Nürnberg")
            {

                prov = tage * 30;


            }
            else if (ort == "Stuttgart")
            {
                prov = tage * 50;
            }
            else
            {
                Console.WriteLine("Falsche Stadt");
            }




        }



        static void fallweise()
        {

            int Umsatz = 25000;
            int Provision = 0;
            switch (Umsatz)
            {

                case 50000:
                {
                    Provision = 2500;    
                    break;
                }

                case 20000:
                {
                    Provision = 2000;
                    break;
                }

                default:
                    { 
                    Console.WriteLine("Fehler");
                    break;

                    }
            }


            Console.ReadLine();

        }



        static void mehrseitig_switch()
        {
            int Umsatz = 9000;
            int Provision = 0;


            if (Umsatz > 50000)
            {
                Provision = 2500;
            }
            else if (Umsatz > 40000)
            {
                Provision = 2000;
            }
            else if (Umsatz > 30000)
            {
                Provision = 1500;
            }
            else if (Umsatz > 20000)
            {
                Provision = 1000;
            }
            else if(Umsatz > 10000)
            {
                Provision = 500;
            }
            else
            {
                Console.WriteLine("Falscher Umsatz");
            }

            Console.WriteLine(Provision);
            Console.ReadLine();
        }


    }
}
