using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;
        //Sets and Gets



        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }


        public void Depositar(float valor)
        {
           Saldo += valor;  
        }
        public float GetSaldo()
        {
            return Saldo;
        }
        public void Sacar(float valor)
        {
           Saldo -= valor; 
        }
}
    }