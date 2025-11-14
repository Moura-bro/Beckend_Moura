
namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Estoque;

        public Produto()
        {
         Console.WriteLine($"Produto Realocado para o Estoque");
         
        }
        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void Exibirdados()
        {
        Console.WriteLine($"Nome do Produto{Nome}, Preco R${Preco}, Quantidade em estoque{Estoque}, ");
        
        }
    }
}