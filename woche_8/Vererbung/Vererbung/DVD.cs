using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class DVD : Medien
    {


        private string director;

        // Konstruktor der Unterklasse muss den Konstruktor der Oberklasse aufrufen,
        // wenn es keinen Default-Konstruktor in der Oberklasse gibt
        public DVD(string _direc, string _title, double _pt): base(_title, _pt)
        {
            this.director = _direc;
        }

        //überschreibt die Methode der Oberklasse
        public override void print()
        {
            Console.WriteLine(title);
            Console.WriteLine(director);
        }


        public override void fahren()
        {


        }
    }
}
