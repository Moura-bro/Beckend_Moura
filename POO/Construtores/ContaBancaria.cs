using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class ContaBancaria
    {
        public string Titular;
        public float Saldo; 

        public ContaBancaria()
        {
            Console.WriteLine($"Titular da Conta Registrado");
            
        }
        public ContaBancaria(string T, float S)
        {
            Titular = T;
            Saldo = 0;
        }
    }
}