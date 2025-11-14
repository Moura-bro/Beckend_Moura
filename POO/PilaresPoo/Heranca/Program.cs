// using Heranca;

// Carro fusca = new Carro();
// Veiculo generic = new Veiculo();

// Aviao airBussA320 = new Aviao();
// Moto HarleyDavilson = new Moto();
// HarleyDavilson.Marca = "HarleyDavilson";
// HarleyDavilson.Modelo = "Fat Boy";
// HarleyDavilson.Ano = 2028;
// HarleyDavilson.SomDaMoto();

// airBussA320.Marca = "LATAM AirBuss";
// airBussA320.Modelo = "AirBuss 320";
// airBussA320.Ano = 2022;
// airBussA320.QtdAsas = 2;
// airBussA320.Voar();

using Heranca;

// Cachoro Pastor = new Cachoro();
// Pastor.espécie = "Cachoro";
// Pastor.Raca = "Pastor de malinua";
// Pastor.Nome = "Salgado";
// Pastor.ExibirInfo();
// Pastor.FazerSom();

// Console.WriteLine($"");



// Gato Russo = new Gato();
// Russo.espécie = "Gato";
// Russo.Raca = "Siames";
// Russo.Nome = "Salgado";
// Russo.ExibirInfo();
// Russo.FazerSom();



// Aluno RH = new Aluno();
// RH.Nome = "Torolho";
// RH.Idade = 16;
// RH.Curso = "TI";
// RH.ExibirInfo();
// Console.WriteLine($"");


// Professor PF = new Professor();
// PF.Nome = "Torolho";
// PF.Idade = 56;
// PF.Disciplina = "TI";
// PF.ExibirInfo();
Conta Conta = new Conta();
ContaPoupanca Rend = new ContaPoupanca();
Rend.Saldo = 1000;
Rend.Numero = 1;

Console.WriteLine($"Quanto voce deseja sacar");
Conta.Sacar(float.Parse(Console.ReadLine()));

Console.WriteLine($"Quanto voce deseja depositar");
Conta.Depositar(float.Parse(Console.ReadLine()));

Rend.CalcularRendimento();