
namespace Heranca
{
    public class Cachoro : Animal
    {
        public String Raca;

        public void ExibirInfo()
        {
            Console.WriteLine($"Espécie: {espécie}");
            Console.WriteLine($"Raca: {Raca}");
            Console.WriteLine($"Nome: {Nome}");
           

        }

        public void FazerSom()
        {
            Console.WriteLine($"Au Au AU Au Au...");

        }

    }
}