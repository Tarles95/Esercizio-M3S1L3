using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto1 = new ContoCorrente();

            Console.WriteLine("Ciao, se sei quì è per aprire un nuovo conto presso Banca Mario; versa 1000 o più euro digitando '1000' :D");

            Console.WriteLine("Inserisci quanto versare ");
            conto1.GetSaldo();

            Console.WriteLine("Inserire il cognome della persona: ");
            conto1.GetCognome();

            Console.WriteLine("Inserire l'età della persona: ");
            conto1.GetEta();
            conto1.GetDettagli();
            Console.ReadLine();

        }
    }
}
