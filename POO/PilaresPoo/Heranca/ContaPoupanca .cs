
namespace Heranca
{
    public class ContaPoupanca : Conta
    {
        public double Rendimento;
        public void CalcularRendimento()
        {
            Rendimento = Saldo * 1.02; 
            Console.WriteLine($"Rendimento: {Rendimento}");
            
        } 
    }
}