namespace Exercicio02
{
    public class Contrato : IInprimivel
    {
        public string Nome;
        public string TextoClausulas;


        public Contrato(string nomeEmpresa, string clausulas)
        {
            Nome = nomeEmpresa;
            TextoClausulas = clausulas;

        }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o Contrato.....");
            
            Console.WriteLine($"Contrato");
            
            Console.WriteLine($@"
            Nome da Empresa:{Nome}
            z
            Clausulas:{TextoClausulas}
            ");

        }
    }
}