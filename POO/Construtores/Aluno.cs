

namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float media;

        public Aluno(string n)
        {
           Nome = n;
           Nota1 = 0;
           Nota2 = 0;
           Nota3 = 0;
         Console.WriteLine($"Voce Reprovou,tente novamente ano que vem");
         
        }

        public Aluno(string n, float i, float j, float l)
        {
            Nome = n;
            Nota1 = i;
            Nota2 = j;
            Nota3 = l;

        }
        
        public void Exibirdados()
        {
            media = Nota1 + Nota2 + Nota3;
            Console.WriteLine($"Media do aluno = {media}");
            
        }
    }
}