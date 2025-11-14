
using System.Security.Cryptography.X509Certificates;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo = 0;
        public override double Depositar(double ValorDeposito)
        {
            if (ValorDeposito <= 0)
            {
                Console.WriteLine($"Valor do deposito invalido");

            }
            double c = Saldo += ValorDeposito;
            Console.WriteLine($"Saldo da conta: {c}");
            return c;
        }

        public override double Sacar(double ValorSaque)
        {
            if (ValorSaque > Saldo)
            {
                Console.WriteLine($"O Valor que voce esta tentando sacar nao esta disponivel");
                return -1;
            }
            else
            {
                double d = Saldo -= ValorSaque * 1.03;
                Console.WriteLine($"Saldo da conta: {d}");
                return d;

            }


        }



    }
}