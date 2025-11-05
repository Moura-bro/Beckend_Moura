using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        public string titular;
        public float Saldo = 0;


        public void Sacar(float valorsaque)
        {
            if (valorsaque > Saldo)
            {
              Console.WriteLine($"O valor do saque esta indisponivel");

            }
            else
            {
                Saldo -= valorsaque;
            }
        }
        
        public void Depositar(float valordeposito)
        {
            Saldo += valordeposito;
        }
    }
}