using ClassesEstaticas;

// CauculosMatematicos calc = new CauculosMatematicos();

Console.WriteLine($"Numero de PI: {CauculosMatematicos.PI}");

// CauculosMatematicos.Somar(5, 10);
Console.WriteLine($"Digite o um numero");
 float x  = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o outro numero");
 float y  = float.Parse(Console.ReadLine());

float menor = Math.Min(x, y); // menor terá o valor 10
float maior = Math.Max(x, y); // maior terá o valor 25

if(menor == maior)
{
    Console.WriteLine($"Eles sao iguais");
    return;
}
Console.WriteLine($"o maior numero e {maior}");
Console.WriteLine($"o maior numero e {menor}");

// Console.WriteLine($"Soma: {x} e {y} = {CauculosMatematicos.Somar(x, y)}");
// Console.WriteLine($"Subitracao: {CauculosMatematicos.Subitracao(x, y)}");
// Console.WriteLine($"Multiplicacao: {CauculosMatematicos.Multiplicacao(x, y)}");
// Console.WriteLine($"Divisao: {CauculosMatematicos.Divisao(x, y)}");

