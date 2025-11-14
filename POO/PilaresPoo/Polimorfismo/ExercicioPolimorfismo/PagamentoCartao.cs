namespace ExercicioPolimorfismo
{
    public class PagamentoCartao : Pagamento
    {   //Acrecimo de 5%
        public float ValorCompra;

        private float acrecimo = 5.38f;

        //Devolve o valor com  o Acrecio calculado
        public override float CalcularTotal()
        {
            float valorAcrescimo = ValorCompra / 100 * acrecimo;
            return ValorCompra = ValorCompra + valorAcrescimo;
           
        }
    }
}