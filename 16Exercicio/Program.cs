string nome, cargo;
float salario, salarioProducao, salarioAdiministrativo, salarioDiretoria;

Console.WriteLine("Bom dia");


Console.WriteLine("Insira seu Nome");
nome = Console.ReadLine();

Console.WriteLine("Insira sua Funcao na Empresa");
cargo = Console.ReadLine();

Console.WriteLine("Insira seu salario");
salario = float.Parse(Console.ReadLine());

/*----Calculo-----*/
salarioAdiministrativo = salario * 1.075f;

salarioDiretoria = salario * 1.12f;

salarioProducao = salario * 1.065f;

/*Exibicao*/

Console.Clear();


if (cargo == "Producao")
{
    Console.WriteLine($"Salario reajustado para R${salarioProducao}");
}
else if (cargo == "Adiministrativo")
{
    Console.WriteLine($"Salario reajustado para R${salarioAdiministrativo}");
}
else if (cargo == "Diretoria")
{
    Console.WriteLine($"Salario rajustado para R${salarioDiretoria}");
}
else
{
    Console.WriteLine("ERRO, Tente digitar seu cargo novamente");
}




