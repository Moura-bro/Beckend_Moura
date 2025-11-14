
namespace Construtores
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //Costrutor
        public Pessoa()
        {
          Console.WriteLine($"Erro no Sistema");
          
        }
        public Pessoa(string n)
        {
           Nome = n; 
        }
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }



        //Metodos 
        public void Exibirdados()
        {
            Console.WriteLine($"Nome {Nome} , Idade {Idade}");

        }
    }
}