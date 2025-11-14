
using System.ComponentModel.DataAnnotations;

namespace Heranca
{
    public class Aviao : Veiculo
    {
             public int QtdAsas;

        public void Voar()
        {
            Console.WriteLine($"Aviao esta levantando voo!");

        }
        
         public void Acelerar()
        {
            Console.WriteLine($"zoom..zoom...zoom....");
            
        }
    }
}