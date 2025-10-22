//Pedir para o usuario digitar o nome , sobrenome , idade saldo bancario e qunto investiu esse ano 
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float ivestimentos;

Console.WriteLine("Ola, qual e o seu nome");
nome = Console.ReadLine();

Console.WriteLine("Qual e o seu Sobrenome");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual a sua Idade");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual e seu saldo Bancario");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Quanto voce investio");
ivestimentos = float.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");

Console.WriteLine($"Idade do : {nome} {idade}");

Console.WriteLine($"Saldo Bancario: {saldoBancario}");

Console.WriteLine($"Investimentos este ano: {ivestimentos}");