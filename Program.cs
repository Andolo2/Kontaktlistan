using System;

namespace Kontaktlistan // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gör ett val i menyn");
            Console.WriteLine("[1] Lägg till en kontakt");
            Console.WriteLine("[2] Visa kontaktnummer");
            Console.WriteLine("[3] Visa alla kontakter");
            Console.WriteLine("[4] Sök efter en kontakt");
            Console.WriteLine("[X] Tryck X för att avsluta");



            var userInput = Console.ReadLine();

            var kontaktLista = new Kontaktlista();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                    Console.WriteLine("Skriv in namn på ny kontakt");
                    var namn = Console.ReadLine();
                    var nummer = Console.ReadLine();

                    var nyKontakt = new Kontakt(namn, nummer);

                    kontaktLista.AddKontakt(nyKontakt);
                    break;
                    case "2":
                    Console.WriteLine("Skriv in kontaktnummer för att söka");
                    var searchNummer = Console.ReadLine();
                    kontaktLista.visaKontakt(searchNummer);
                    break;
                    case "3":
                    kontaktLista.visaAllaKontakter();
                    break;
                    case "4":
                    Console.WriteLine("Skriv in ett sökord.");
                    var searchPhrase = Console.ReadLine();
                    kontaktLista.visaLiknandeKontakter(searchPhrase);
                    break;
                    default:
                        Console.WriteLine("Fel inmatningh, försök igen");
                        break;
                }
            }   Console.WriteLine("Gör ett val i menyn");
                userInput = Console.ReadLine();


        }
    }
}