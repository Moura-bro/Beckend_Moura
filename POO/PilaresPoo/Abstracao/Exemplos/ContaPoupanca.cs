

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;
        public override double Depositar(double ValorDeposito)
        {
            if (ValorDeposito <= 0)
            {
                Console.WriteLine($"Valor do deposito invalido");

            }
            double V = Saldo += ValorDeposito;
            Console.WriteLine($"Saldo da conta: {V}");
            return V;

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

                double i = Saldo -= ValorSaque * 1.03;
                Console.WriteLine($"Saldo da conta: {i}");
                return i;
            }
        }


    }
}