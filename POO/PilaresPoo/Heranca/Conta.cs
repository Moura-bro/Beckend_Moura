using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Conta
    {
        public float Saldo;
        public int Numero;

        public void Sacar(float valorsaque)
        {
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
        }
        
        public void Depositar(float valordeposito)
        {
          Saldo += valordeposito;
        }
    }
}