using System;

namespace Kontaktlistan
{
    public class Kontaktlista
    {
        private List<Kontakt> _kontakt {get; set;} = new List<Kontakt>();



        private void visaKontakt(Kontakt kontakt)
        {
            Console.WriteLine($"Kontakt: {kontakt.Namn}, {kontakt.Nummer}");
            
        }
        private void kontaktInformation(List<Kontakt> kontakter)
        {
            foreach (var kontakt in kontakter)
            {
                kontaktInformation(kontakter);
            }
        }
        public void AddKontakt(Kontakt kontakt)
        {
            _kontakt.Add(kontakt);
        }
        public void visaKontakt(string nummer)
        {
            var kontakt = _kontakt.FirstOrDefault(c => c.Nummer == nummer);
            if (kontakt == null)
            {
                Console.WriteLine("Hittade ingen kontakt");
            }
            else
            {
                visaKontakt(kontakt);
            }

        }
        public void visaAllaKontakter()
        {
            kontaktInformation(_kontakt);
        }
        public void visaLiknandeKontakter(string searchPhrase)
        {
            var liknandeKontakter = _kontakt.Where(c => c.Namn.Contains(searchPhrase)).ToList();
        }    

    }
}
