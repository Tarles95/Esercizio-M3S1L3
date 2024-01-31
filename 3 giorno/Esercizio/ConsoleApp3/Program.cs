using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            ContoCorrente persona = new ContoCorrente();
            
            Console.WriteLine("Ciao, prima di tutto crea un account! \n");
            Console.WriteLine("Inserisci qui il tuo nome:\n ");
            persona.GetNome();

            Console.WriteLine("\ninserisci il tuo cognome: ");
            persona.GetCognome();

            Console.WriteLine("\nInserire l'età attuale: ");
            persona.GetEta();


            Console.WriteLine("           Benvenuto in Banca Marios");
            persona.Menu();


            Console.ReadLine();
        }
    }
}
