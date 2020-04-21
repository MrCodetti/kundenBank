using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kundenBank
{
    class Kunde
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public int kundenNummer { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var kunden = new List<Kunde>();
            string name, adresse;
            int kNummer, counter = 0;

            Console.WriteLine("Wie viele Kunden willst du Eingeben?: ");
            string input = Console.ReadLine();

            while (counter < int.Parse(input))
            {
                Console.Clear();
                Console.WriteLine("Kunde " + (counter + 1));
                Console.WriteLine("Kunden Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Kunden Adresse: ");
                adresse = Console.ReadLine();
                Console.WriteLine("Kunden Nummer: ");
                kNummer = int.Parse(Console.ReadLine());
                Kunde kunde = new Kunde() { Name = name, Adresse = adresse, kundenNummer = kNummer };
                kunden.Add(kunde);
                counter++;
                
            }


            foreach (var item in kunden)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Adresse);
                Console.WriteLine(item.kundenNummer + "/n");
            }

            Console.ReadKey();
        }
    }
    
}
