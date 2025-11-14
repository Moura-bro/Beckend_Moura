using Exemplos; 

// Gato birobinha = new Gato();

// birobinha.fazersom();


// Console.WriteLine($"");


// Cachorro Nero = new Cachorro();

// Nero.Mover();

// Pessoa Hm = new Pessoa();
// Hm.Nome = "Rafael";
// Hm.Idade = 16;
// Hm.Exibirinfo();
// Hm.Dormir();
ContaCorrente Rent = new ContaCorrente();
ContaPoupanca Pou = new ContaPoupanca();


Console.WriteLine($"Quanto voce deseja depositar");
Rent.Depositar(float.Parse(Console.ReadLine()));

Console.WriteLine($"Quanto voce deseja Sacar");
Rent.Sacar(float.Parse(Console.ReadLine()));




