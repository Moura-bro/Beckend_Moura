float numero1;
float numero2;


Console.WriteLine("Ola, digite um numero");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = float.Parse(Console.ReadLine());

float soma = numero1 + numero2;

 Console.WriteLine($"Valor: {soma}");