namespace Exercicio02
{
    public class Relatorio : IInprimivel
    {
        public string NomeResponsavel;

        public string TextoRelatorio;

        public Relatorio(string Responsavel, string Relatorio)
        {
            NomeResponsavel = Responsavel;
            TextoRelatorio = Relatorio;

        }



        public void Imprimir()
        {
            Console.WriteLine($"Imprimndo o Relatorio......");

            Console.WriteLine($"Relatorio");

            Console.WriteLine($@"
            Nome do Responsavel:{NomeResponsavel}
            Relatorio:{TextoRelatorio}
            ");
        }
    }
}