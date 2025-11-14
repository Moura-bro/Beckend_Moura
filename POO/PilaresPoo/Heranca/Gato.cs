using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Gato : Animal
    {
        public String Raca;

        public void ExibirInfo()
        {
            Console.WriteLine($"Espécie: {espécie}");
            Console.WriteLine($"Raca: {Raca}");
            Console.WriteLine($"Nome: {Nome}");


        }




        public void FazerSom()
        {
            Console.WriteLine($"miau miau miau miau...");

        }


    }
}