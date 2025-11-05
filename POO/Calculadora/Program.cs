using Calculadora;

Console.Clear();

Calculator calc = new Calculator();
calc.Numero1 = 0;
calc.Numero2 = 0;

int escolha = -1;

Console.WriteLine($"===  calculadora ===");

Thread.Sleep(1000);

Console.Clear();

do
{
    Console.WriteLine($"Digite um número de sua escolha");
    calc.Numero1 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Digite outro número de sua escolha");
    calc.Numero2 = double.Parse(Console.ReadLine());

    Console.Clear();

    Console.WriteLine($"Escolha uma das seguintes equações");

    Console.WriteLine($"1 - Soma");
    Console.WriteLine($"2 - Subtração");
    Console.WriteLine($"3 - Multiplicação");
    Console.WriteLine($"4 - Divisão");
    Console.WriteLine($"0 - Sair");
    escolha = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (escolha)
    {
        case 1:
            calc.Somar();
            break;

        case 2:
            calc.Subtrair();
            break;

        case 3:
            calc.Multiplicar();
            break;

        case 4:
            calc.Dividir();
            break;

        case 0:
            Console.WriteLine($"Saindo da Calculadora....");
            break;
            
        default:
            Console.WriteLine($"Opção desconhecida");
            break;
    }

    Thread.Sleep(2250);

    Console.Clear();

} while (escolha !=0);