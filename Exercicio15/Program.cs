float nt1, nt2, nt3, nt4;

Console.WriteLine("Ola, digite suas notas, nota 1 ");
nt1 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 2");
nt2 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 3");
nt3 = float.Parse(Console.ReadLine());

Console.WriteLine("Nota 4");
nt4 = float.Parse(Console.ReadLine());

float md =( nt1 + nt2 + nt3 + nt4)/4;

if (md >= 7)
{
    Console.WriteLine($"Aprovado {md}");
}
else if (md >= 5)
{
    Console.WriteLine($"Recuperacao {md}");
}
else
{
    Console.WriteLine($"Reprovado {md}");
}