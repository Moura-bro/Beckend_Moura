namespace Exercicio02
{
    public class Fatura : IInprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float valor = 0;
        public int Diasdeatraso = 0;
        public float Juros = 0.10f;

        public Fatura(string nomedeverdor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {

            Devedor = nomedeverdor;
            Credor = nomeEmpresa;
            valor = valorFatura;
            Diasdeatraso = qtdDiasAtraso;

        }

        public void CalcularValorDivida()
        {
            if (Diasdeatraso > 0)
            {
                valor = valor + Diasdeatraso * Juros;
            }


            if (Diasdeatraso >= 5)
            {
                Console.WriteLine($"Sua divida foi encaminhada para o SERASA");

            }
        }

        public void Imprimir()
        {
            Console.WriteLine($@"
            Credor:{Credor}
            Devedor:{Devedor}
            Dias de atraso: {Diasdeatraso}
            Juroa R${Juros * Diasdeatraso}
            Valor Total: R${valor}
            ");
            
        }
    }
}