using System;

namespace Kontaktlistan
{
    public class Kontakt
    {
        
        public Kontakt(string namn, string nummer)
        {
            Namn = namn;
            Nummer = nummer;

        }
        public string Namn {get; set;}
        public string Nummer {get; set;}


    }
}
