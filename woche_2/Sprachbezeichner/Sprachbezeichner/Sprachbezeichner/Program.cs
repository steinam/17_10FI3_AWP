using System;
using System.Collections;

namespace Sprachbezeichner
{
    class Program
    {

        static void Main(string[] args)
        {
            int note1 = 5;
            int note2 = 5;

            ArrayList liste = new ArrayList();
            

            liste.Add(5);
            liste.Add(10);


            foreach (int element in liste)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("note1 = " + note1);

            ListMultiplier(liste, note1);

            Console.WriteLine("note1 = " + note1);


            foreach (int element in liste)
           {
                Console.WriteLine("Element hat Wert " + element);
           }


            liste = null;


            GC.Collect();
            Console.ReadLine();
        }


        public static void Adder(double A, double B)
        {
            Console.WriteLine(A + B);
        }

        //Überladene F: gleicher Methodenname, versch. Datentypen der Parameter
        public static void Adder(string A, double B)
        {


            

           // Console.WriteLine(Convert.ToDouble(A) + B);
        }

        public static void ListMultiplier(ArrayList myList, int value)
        {


            value = 10;
            Console.WriteLine("note1 = " + value);

            for (int i = 0; i < myList.Count; i++)
            {

                myList[i] = Convert.ToInt32(myList[i]) * 2;
                Console.WriteLine(myList[i]);

            }

            //myList.Clear();
           myList = null;//ich brauche das Objekt nicht mehr


          // myList.Add(4);
        }



    }
}