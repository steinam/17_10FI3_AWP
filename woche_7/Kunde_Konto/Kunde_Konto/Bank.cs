using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Konto
{
    public class Bank
    {

        private List<Konto> meineKonten = new List<Konto>();


        public void KundeLoeschen(Kunde k, Konto ko)
        {

        }

        public void KundeAnlegen(string KName,  double Einzahlungsbetrag)
        {
            Kunde k = new Kunde(KName, Einzahlungsbetrag, this);
        }

    }
}
