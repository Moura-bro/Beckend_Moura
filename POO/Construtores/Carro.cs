
namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro()
        {
            Console.WriteLine($"Informacoes incopativeis");

        }

        public Carro(string M, string MO, int AN)
        {
            Marca = M;
            Modelo = MO;
            Ano = AN;
        }
        
        public void Exibirdados()
        {
            Console.WriteLine($"Marca{Marca}, Modelo{Modelo}, Ano {Ano}");
            
        }
    }
}