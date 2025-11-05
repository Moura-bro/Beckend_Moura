float salario, gasto;



Console.WriteLine("Digite seu Salario:");
salario = float.Parse(Console.ReadLine());


Console.WriteLine("Digite seus Gastos");

Console.WriteLine("Gasto");
gasto = float.Parse(Console.ReadLine());

if(salario > gasto)
{
    Console.WriteLine("Seu saldo esta Positivo");
}
else
{
    Console.WriteLine("Seu saldo esta negativo");
}





