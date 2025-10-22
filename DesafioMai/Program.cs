float numero1, numero2;



Console.WriteLine("Ola, digite um numero");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = float.Parse(Console.ReadLine());


if (numero1 > numero2)
{
    Console.WriteLine($"O Primeiro numero e maior {numero1} > {numero2}");
}
else if (numero1 < numero2)
{
    Console.WriteLine($"O Segundo numero e maior {numero1} < {numero2}");
}
else
{
    Console.WriteLine($"Eles sao iguais {numero1} = {numero2}"); 
}