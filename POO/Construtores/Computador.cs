
namespace Construtores
{
    public class Computador
    {
        public string marca;
        public int    memoriaRam;
        public int Armazenamento;  

        public Computador()
        {
            marca = "Pichau";
            memoriaRam = 16;
            Armazenamento = 256;
        }
        public Computador(string M, int R, int A)
        {
            marca = M;
            memoriaRam = R;
            Armazenamento = A;
        }
    }
     
    
}