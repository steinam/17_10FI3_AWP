using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public abstract class Medien
    {

        //Aufweichen des Geheimnisprinzips, da die Unterklasse sonst keinen
        //Zugriff auf Attribute der Oberklasse hat
        protected string title;
        protected double playingTime;

        public Medien(string _title, double _pt)
        {
            this.title = _title;
            this.playingTime = _pt;
        }


        //gibt Unterklassen die Möglichkeit, die Methode zu überschreiben 
        public virtual void print()
        {
            Console.WriteLine("Oberklasse Print");
        }



        public void doSomething()
        {
            Console.WriteLine("Ich mache Was");

        }


        public abstract void fahren();
        




    }
}
