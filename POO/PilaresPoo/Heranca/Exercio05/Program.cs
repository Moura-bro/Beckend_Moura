using Heranca;

Conta Conta = new Conta();
ContaPoupanca Rend = new ContaPoupanca();
Rend.Saldo = 1000;
Rend.Numero = 1;

Console.WriteLine($"Quanto voce deseja sacar");
Conta.Sacar(float.Parse(Console.ReadLine()));

Console.WriteLine($"Quanto voce deseja depositar");
Conta.Depositar(float.Parse(Console.ReadLine()));

Rend.CalcularRendimento();