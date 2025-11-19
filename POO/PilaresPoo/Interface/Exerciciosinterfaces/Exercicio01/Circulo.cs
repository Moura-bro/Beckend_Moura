
namespace Exercicio01
{
    public class Circulo : IForma
    {
       public double Raio;

       public double Area;

        public void CalcularArea()
        {
            Console.WriteLine($"Qual e o Raio do Circulo");
             Raio = double.Parse(Console.ReadLine());

              Console.WriteLine($"Qual e o Raio do Circulo");
             Raio = double.Parse(Console.ReadLine());


            Area = Math.PI * Raio * Raio;
        }


        public void ExibirInfo()
        {
            Console.WriteLine($"A Area do Circulo e {Area}");
            
        }
    }
}