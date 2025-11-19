using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        public void AumentarVolumme()
        {
            if (NivelVolume == VolumeMaximo)
            {
              Console.WriteLine($"Volume maximo atingido {NivelVolume}");
              return;
                
            }
            NivelVolume ++;
            Console.WriteLine($"Volume: {NivelVolume}");
            
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV");
            
        }

        public void DiminuirVolume()
        {
            if(NivelVolume == 0)
            {
                Console.WriteLine($"Volume ja Esta no minimo: {NivelVolume}");
                return;
                
            }
          NivelVolume --;
          Console.WriteLine($"Volume: {NivelVolume}");
            
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV");
            
        }
    }
}