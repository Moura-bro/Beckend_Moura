using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Produto
    {
        public string nome;

        public double preco = 0;


        public void Desconto(double percentual)
        {
          if(percentual > 100)
            {
             Console.WriteLine($"O disconto esta indisponivel, proucure o gerente");
             
            }
            else
            {
                preco -= preco / 100 * percentual;
            }
        }
    }


}