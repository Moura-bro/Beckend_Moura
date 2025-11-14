
namespace Construtores
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Resultado;

        public Retangulo()
        {
            Resultado = Largura * Altura;
            Console.WriteLine($"Resultado da Da area total do retangulo");
            
        }
        public Retangulo(double l, double a)
        {
            Largura = 1;
            Altura = 1;
        }
            
        }
}