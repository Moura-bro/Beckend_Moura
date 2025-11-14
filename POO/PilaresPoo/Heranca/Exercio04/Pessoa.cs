// Exercício 4 – Escola
// Crie uma classe Pessoa com as propriedades Nome e Idade.
// Crie as classes Aluno e Professor que herdem de Pessoa.
// O Aluno deve ter uma propriedade Curso e o Professor uma propriedade Disciplina.
// Crie objetos de ambas as classes e exiba suas informações no console.

namespace Heranca
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void ExibirInfo()
        {
          Console.WriteLine($"Nome: {Nome}");
          Console.WriteLine($"Idade: {Idade}");
          
        }
    }
}