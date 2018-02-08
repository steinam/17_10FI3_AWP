using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Konto
{
    public class Konto
    {

        private string _KontoNr;
        private double _Sollzinssatz;

        private double KontoStand;

        public Konto(double Betrag, Kunde k)
        {
            this.KontoStand = Betrag;
            this.meinKunde = k;
        }

        private Kunde meinKunde;

        public string KontoNr { get => _KontoNr; set => _KontoNr = value; }
        public double Sollzinssatz { get => _Sollzinssatz; set => _Sollzinssatz = value; }
   
        public void setKunde(Kunde k)
        {
            meinKunde = k;
        }
    }
}
