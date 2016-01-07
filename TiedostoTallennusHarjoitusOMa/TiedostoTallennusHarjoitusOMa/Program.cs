using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedostoTallennusHarjoitusOMa
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\Temp\\Lämpötila.txt";
            //luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiarvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on: "+aiempiarvo+" astetta");
            }

            int lämpötila = 0;
                Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            string tiedosto = "C:\\Temp\\Lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();

        }
    }
}
