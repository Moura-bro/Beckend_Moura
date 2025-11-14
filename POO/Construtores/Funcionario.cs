
namespace Construtores
{
    public class Funcionario
    {
        public string Nome;

        public string Cargo;

        public double Salario; 

        public Funcionario(string n )
        {
            Nome = n; 
        }
        public Funcionario(string n, string c )
        {
            Nome = n;
            Cargo = c;
        }

        public Funcionario(string n, string c, double s)
        {
            Nome = n;
            Cargo = c;
            Salario = s;
        }
        
        public void Exibirdados()
        {
            Console.WriteLine($"Fucionario    {Nome}");
            Console.WriteLine($"Funcao        {Cargo}");
            Console.WriteLine($"Salario       {Salario}");
        }
    }
}