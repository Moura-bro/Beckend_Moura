using System.Diagnostics;
using Encapsulamento;

ContaBancaria contaRafa = new ContaBancaria();
ContaBancaria contaJoao = new ContaBancaria(1500);

contaRafa.Depositar(-100);
contaRafa.Depositar(20);
contaRafa.Sacar(-200);
contaJoao.Sacar(300);

Console.WriteLine($"");

Console.WriteLine($"Saldo atual do Rafael: R${contaRafa.GetSaldo()}");
Console.WriteLine($"Saldo atual do Joao: R${contaJoao.GetSaldo()}");




