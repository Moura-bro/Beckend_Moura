
namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public double Largura;

        public double Altura;

        public double Area;

        public void CalcularArea()
        {
             Console.WriteLine($"Qual e a largura do seu Retangulo");
             Largura = double.Parse(Console.ReadLine());

             Console.WriteLine($"Qual e a Altura do seu Retangulo");
             Altura = double.Parse(Console.ReadLine());


            Area = Largura * Altura;
        }

         public void ExibirInfo()
        {
            Console.WriteLine($"A Area do Retangulo e {Area}");
            
        }
    }
}