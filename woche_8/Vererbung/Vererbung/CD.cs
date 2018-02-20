using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class CD : Medien, IDrucken
    {

        private string Artist;
        private int NumberofTracks;

        // Einhalten des Vertrages der Oberklasse; der Konstruktor erwartet zwei Parameter
        public CD(string _artist, int _numbers, string _title, double _pt) :base(_title, _pt)
        {
            this.Artist = _artist;
            this.NumberofTracks = _numbers;
        }

        
        public override void print()
        {
            Console.WriteLine(title);
            Console.WriteLine(Artist);
        }


        public override void fahren()
        {
            throw new NotImplementedException();
        }
    }
}