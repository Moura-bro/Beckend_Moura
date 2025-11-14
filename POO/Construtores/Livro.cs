
namespace Construtores
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public double Preco;

        public Livro(string t, string a)
        {
            Titulo = t;
            Autor = a;  
        }
        public Livro(string t, string a, double P)
        {
            Titulo = t;
            Autor = a;
            Preco = P;
        }
        
    }
}