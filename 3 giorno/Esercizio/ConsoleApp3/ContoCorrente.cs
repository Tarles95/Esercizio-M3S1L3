using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ContoCorrente
    {
        private String _nome, _cognome;
        private int _eta, _versamento;
        

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }

        private decimal _saldo = 0;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public decimal Versamento
        {
            get { return _versamento; }
            set { _versamento = 0; }
        }

        private bool _contoAperto = false;

        public bool ContoAperto
        {
            get { return _contoAperto; }
            set { _contoAperto = value; }
        }


        public void GetNome()
        {
            _nome = Console.ReadLine();
        }
        public void GetCognome()
        {
            _cognome = Console.ReadLine();
        }
        public void GetEta()
        {

            _eta = Convert.ToUInt16(Console.ReadLine());
        }

        public void Menu()
        {
           


            Console.WriteLine($"\nCiao {Nome} {Cognome}, Cosa vuoi fare? \n ");
            Console.WriteLine("\n Scegli l'operazione da effettuare:\n");
            Console.WriteLine("1. Apri un conto");
            Console.WriteLine("2. Deposita");
            Console.WriteLine("3. Preleva/Prelevamento");
            Console.WriteLine("4. ESCI");


            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                NuovoConto();
            }
            else if (scelta == 2)
            {
                Deposita();
            }
            else if (scelta == 3)
            {
                Preleva();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Esci");
            }
            else
            {
                Console.WriteLine("Comando non valido");
                Menu();
            }

        }

        private void NuovoConto()
        {   
            Console.WriteLine("Versa almeno 1000 euro per creare il conto \n");
            int Versamento = Convert.ToInt32(Console.ReadLine());

            ContoCorrente conto1 = new ContoCorrente();
            _versamento = Versamento;
            _saldo = _versamento;
            _contoAperto = false;

            if(_versamento >= 1000)
            {
                _contoAperto = true;
                Console.WriteLine($"Congratulazioni {_cognome} {_nome} per aver aperto il conto correttamente");
                Menu();
            }
            else
            {
                Console.WriteLine($"Conto corrente non aperto correttamente");
                
            }

            
        }

        private void Preleva()
        {
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un prelevamento");
            }
            else
            {
                Console.WriteLine("Quanto vuoi prelevare? ");
                decimal importoPrelevato = Convert.ToInt32(Console.ReadLine());

                if (importoPrelevato > _saldo)
                {
                    Console.WriteLine("Saldo insufficiente");
                }
                else
                {
                    Console.WriteLine("Prelievo/Prelevamento effettuato");
                    _saldo -= importoPrelevato;
                    Console.WriteLine($"Nuovo saldo: {_saldo}");
                }
            }
            Menu();
        }

        private void Deposita()
        {
            if (_contoAperto == false)
            {
                Console.WriteLine("E' necessario aprire un conto prima di effettuare un versamento");
            }
            else
            {
                Console.WriteLine("Quanto vuoi depositare? ");
                int importoVersato = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Versamento effettuato");
                _saldo += importoVersato;
                Console.WriteLine($"Nuovo saldo: {_saldo}");
            }
            Menu();
        }


    }






}
   

