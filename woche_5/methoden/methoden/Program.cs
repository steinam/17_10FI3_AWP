using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace methoden
{
    class Program
    {
        static void Main(string[] args)
        {

            int Summe = 100;
            int[] zahl = einlesen();

            /*
            for (int i = 0; i < zahl.Length; i++)
            {
                Summe = Summe + zahl[i];
            }

    */
           // double Steuer = berechneUmsatzsteuer(Summe);
           // double GesamtSumme = Summe + Steuer;


            //Console.WriteLine("Vorher:" + Summe);

            //SummeAusgeben(GesamtSumme);

            //Summe = 100
            macheWas(Summe);//copy by Val

            macheWasZweites(Summe++);
            macheWasZweites(++Summe);


            double dZahl = 100.01;
            macheWas(dZahl);





      //      Console.WriteLine(Summe);


            foreach (int element in zahl)
            {
                Console.WriteLine(element);
            }


            macheWasAnderes(zahl); //copy by ref

            foreach (int element in zahl)
            {
                Console.WriteLine(element);     
            }
            
            Console.ReadLine();
        }

        static void macheWas(int Wert)
        {
            Wert = Wert * 2;
        }

        static void macheWas(double Test, int test2)
        {
            Wert = Wert * 2;
        }



        static void macheWas(int Wert, double test)
        {
            Wert = Wert * 2;
        }

        static void macheWas(double Wert)
        {
            


        }

        static void macheWasZweites(int Wert)
        {


            Console.WriteLine(Wert);
            Wert = Wert * 2;
        }



        static void macheWasAnderes(int[] wert)
        {
            for (int i = 0; i < wert.Length; i++)
            {
                wert[i] += 2;
            }
        }

        static double berechneUmsatzsteuer(int Wert)
        {
            return (Wert * 16 / 100);
        }

        static int[] einlesen()
        {
            int[] zahl = new int[5];

            zahl[0] = int.Parse(Console.ReadLine());
            zahl[1] = int.Parse(Console.ReadLine());
            zahl[2] = int.Parse(Console.ReadLine());
            zahl[3] = int.Parse(Console.ReadLine());
            zahl[4] = int.Parse(Console.ReadLine());

            return zahl;

        }

        static void SummeAusgeben(double GesamtSumme)
        {
            Console.WriteLine("Gesamtsumme gleich " + GesamtSumme);
        }

    }
}
