// Exercício 1 – Animais e sons
// Crie uma classe chamada Animal que contenha o método virtual FazerSom().
// Crie as classes Cachorro e Gato que herdem de Animal e sobrescrevam o método FazerSom() para imprimir sons diferentes (ex: "Au au" e "Miau").
// Na Program, crie um objeto de cada classe e chame o método FazerSom().

using System.Runtime.CompilerServices;

namespace Heranca
{
    public class Animal
    {
        public string espécie;
        public string Nome;

        public void FazerSom()
        {
         Console.WriteLine($"O Animal esta a emitir um som");
          
        } 
    }
}