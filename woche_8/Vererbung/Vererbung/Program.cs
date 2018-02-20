using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {

         
        private static List<CD> CDLiSte = new List<CD>();
        private static List<DVD> DVDListe = new List<DVD>();

        private static List<Medien> MedienListe = new List<Medien>();


        static void Main(string[] args)
        {

            CD Peter_Alexander = new CD("Alexander", 10,  "Baby all", 1.45 );
            Peter_Alexander.print();
            
            DVD Heino = new DVD("Heino",   "Oh Mama", 1.45 );
            Heino.print();



            MedienListe.Add(Peter_Alexander);
            MedienListe.Add(Heino);




            //Abstrakte Oberklassen können nicht instanziiert werden
            //Medien Rihana = new Medien("Rihana", 1.98);
           // MedienListe.Add(Rihana);


            foreach(Medien element in MedienListe)
            {
                //Polymorphie
                //zur Laufzeit wird entscheiden, welche der drei print()-
                //Methoen aufgerufen werden muss
                element.print();
            }


            Console.ReadLine();



        }
    }
}