using ClassesEObjetos;

// AgenciaBancaria conta = new AgenciaBancaria();
// conta.titular = "Rafael";
// conta.Saldo = 1000;


// Console.WriteLine($"Qual e o seu Nome?");
// conta.titular = Console.ReadLine();

// Console.WriteLine($"{conta.titular} tem {conta.Saldo}");

// Console.WriteLine($"Quanto voce deseja sacar");
// conta.Sacar(float.Parse(Console.ReadLine()));


// Console.WriteLine($"{conta.titular} tem {conta.Saldo}");

// Console.WriteLine($"Quanto voce deseja depositar");
// conta.Depositar(float.Parse(Console.ReadLine()));

// Console.WriteLine($"{conta.titular} tem {conta.Saldo}");

/*----------------------------------------------------------------------------------------------------------------------------------*/

Produto produto = new Produto();
produto.nome = "";
produto.preco = 0;

Console.WriteLine($"Qual o nome do produto que procura?");
produto.nome = Console.ReadLine();

Console.WriteLine($"Qual o preço do produto que procura?");
produto.preco = double.Parse(Console.ReadLine());

Console.WriteLine($"Qual o desconto do produto no momento?");
produto.Desconto(double.Parse(Console.ReadLine()));

Console.WriteLine($"Desconto aplicado, novo preco {produto.preco}R$");
