using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Konto
{
    public class Kunde
    {
        private Konto meinKonto;
        private Bank meineBank;

        private string _Name;
        private string _Adresse;

        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string Name { get => _Name; set => _Name = value; }


        public Kunde(string Name, double Einzahlungsbetrag, Bank b)
        {
            this._Name = Name;

            Konto ko = new Konto(Einzahlungsbetrag, this);
            meinKonto = ko;
            meineBank = b;
        }

        public void setKonto(Konto k)
        {
        
            meinKonto = k;

        }



    }
}
