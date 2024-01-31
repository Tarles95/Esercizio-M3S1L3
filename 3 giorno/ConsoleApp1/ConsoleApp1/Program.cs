using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votiOpzione1 = 0, votiOpzione2 = 0, votiOpzione3 = 0;
            bool continuaVotazione = true;

            Console.WriteLine("Benvenuto nella macchina per il voto!");






            while (continuaVotazione)
            {
                Console.WriteLine("\nOpzioni di voto:");
                Console.WriteLine("\n1 Opzione 1");
                Console.WriteLine("\n2 Opzione 2");
                Console.WriteLine("\n3 Opzione 3");
                Console.WriteLine("\n4 Termina votazione e mostra risultati");
                Console.Write("\nInserisci il tuo voto (1-4): ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        votiOpzione1++;
                        break;
                    case "2":
                        votiOpzione2++;
                        break;
                    case "3":
                        votiOpzione3++;
                        break;
                    case "4":
                        continuaVotazione = false;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break;

                }


            }
        }
    }
}
