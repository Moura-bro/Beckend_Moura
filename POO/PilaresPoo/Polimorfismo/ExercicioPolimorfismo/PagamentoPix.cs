namespace ExercicioPolimorfismo
{

    public class PagamentoPix : Pagamento
    {   //Desconto de 5%
        public float ValorCompra;

        private float desconto = 5;

        //Devolve o valor com o desconto calculado

        public override float CalcularTotal()
        {
            float ValorDesconto = ValorCompra / 100 * desconto;
            return ValorCompra = ValorCompra - ValorDesconto;
        }
    }
}