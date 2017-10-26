using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    enum Terminzustand
    {
        

        abgestimmt, geplant, eingeladen, fixiert


    }


    class Termin
    {


           //Zustandsattribut
        private Terminzustand tzustand;

        //Datenattribut
        private DateTime termindatum;


        public Termin()
        {
            tzustand = Terminzustand.geplant;

        }

        
        public void RaumReservieren(string Raum)
        {
            if (tzustand == Terminzustand.abgestimmt)
            {

                //makesomethin
                tzustand = Terminzustand.fixiert;
            }

        }



    }
}
