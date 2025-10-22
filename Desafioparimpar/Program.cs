int nq;
string pares = "pares: ";
string impares = "impares: ";

Console.WriteLine("Quantos numeros voce quer digitar?");
nq = int.Parse(Console.ReadLine());

for (int i = 1; i < nq; i++)
{
    Console.WriteLine($"Digite o {i} numero");
    int numerodg = int.Parse(Console.ReadLine());
 
 if(numerodg % 2 == 0)
    {
        pares += numerodg.ToString() + ", ";
    }
    else
    {
        impares += numerodg.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine("Resultado:");
Console.WriteLine("");
Console.WriteLine(pares);
Console.WriteLine(impares);
