using System.Runtime;

namespace Exemplos 
{
    public class Carro : IMotor
    {
       //Propiedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        //Construtores
        public Carro(string c, string m, string md , int a )
        {
            Cor = c;
            Marca = m;
            Modelo = md; 
            Ano = a;
        }
        //Metodos
        public void ExibirInfo()
        {
          Console.WriteLine($"Marca: {Marca}");
          Console.WriteLine($"Modelo do Carro:{Modelo} Ano:{Ano} Cor:{Cor}");
         
        }
        public void Acelerar()
        {
            Console.WriteLine($"Dando partida vrumm , vrummm....");
            
        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freando irrrrrrrrrrr...");
            
        }
    }
}