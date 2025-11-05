namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public float Altura;
        public int Idade = 1;

        public void Falar()
        {
            Console.WriteLine($"Ola, eu sou {Nome} e tenho {Idade} anos de idade e tenho {Altura} metros de altura");
        }
        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzzzzz...");
        }

    

     public void Envelhecer(int _id = 0)
        {
            if(_id > 0)
            {
                Idade += _id;
            }
            else
            {
                Idade++;   
            }
        }
    }
}