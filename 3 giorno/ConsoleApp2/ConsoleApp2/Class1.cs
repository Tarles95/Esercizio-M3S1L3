using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ContoCorrente
    {
       
            private String _cognome;
            private int _eta, _saldo;
            
            public int Saldo
            {
                get
                {
                    return _saldo;
                }
                set
                {
                    _saldo = value;
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

            public void GetSaldo()
            {
                _saldo = Convert.ToInt32(Console.ReadLine());
            }
            public void GetCognome()
            {
                _cognome = Console.ReadLine();
            }
            public void GetEta()
            {

                _eta = Convert.ToUInt16(Console.ReadLine());
            }
            public void GetDettagli()
            {
                Console.WriteLine($"\n I dettagli della persona sono: \n Saldo: {Saldo} \n Cognome: {Cognome} \n Età: {Eta}  \n");
            }

        }
    }




