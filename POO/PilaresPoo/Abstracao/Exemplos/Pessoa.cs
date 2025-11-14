
namespace Exemplos
{
    public class Pessoa : Animal
    {
     public string Nome;

     public int Idade;

        public override void fazersom()
        {
            Console.WriteLine($"Hello Word");
            
        }

        public override void Mover()
        {
           Console.WriteLine($"plic-plic-plic ");
           
        }

        public void Dormir()
        {
            Console.WriteLine($"zzzzzzzzzzzzzzzzzz");
            
        }

        public void Exibirinfo()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Idade:{Idade}");
            
        }
    }
}