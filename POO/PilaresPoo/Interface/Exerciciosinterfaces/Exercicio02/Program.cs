using Exercicio02;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();
List<IInprimivel> Documentos = new List<IInprimivel>();


int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opcoes
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Lista de Faturas
5) Lista de Relatorios
6) Lista de Contratos
0) Sair
Escolha a Opcao");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();

            break;

        case 2:
            Console.WriteLine($"Cadastrar Relatorio em desevolvimento");
            break;

        case 3:
            Console.WriteLine($"Cadastrar Contrato em desevolvimento");
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"Listar Relatorio em desevolvimento");
            break;

        case 6:
            Console.WriteLine($"Listar Contrato em desevolvimento");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"opcao invalida");
            break;
    }
    Console.WriteLine($"Pressione <ENTER> para Continuar");
    Console.ReadLine();


} while (opcao != 0);





//Funcoes auxiliares

void CadastrarFatura()
{
  Console.WriteLine($"Digite o nome do cliente devedor");
  string dev = Console.ReadLine();
  
  Console.WriteLine($"Digite o nome da Empresa");
  string Empresa = Console.ReadLine();

  Console.WriteLine($"Digite o Valor da Fatura");
   float Valor = float.Parse(Console.ReadLine());

  Console.WriteLine($"Dias de atraso da Fatura");
   int qtdDiasAtraso = int.Parse(Console.ReadLine());

  Fatura fat = new Fatura(dev , Empresa , Valor , qtdDiasAtraso);
  Documentos.Add(fat);

  Console.WriteLine($"Fatura cadastrada com sucesso");
  
}
void CadastrarContratos()
{

}

void CadastrarRelatorio()
{

}

void ListarFaturas()
{
Console.WriteLine($"Listando Faturas:");
foreach (var item in Documentos)
{
    if(item is Fatura)
        {
            item.Imprimir();
        }
}

}

void ListarContratos()
{

}

void ListarRelatorio()
{

}










































































// Fatura fatRafa = new Fatura();
// Documentos.Add(fatRafa);

// Fatura Ale = new Fatura();
// Documentos.Add(Ale);



// Relatorio relRafa = new Relatorio();
// Documentos.Add(relRafa);

// Relatorio Alex = new Relatorio();
// Documentos.Add(Alex);


// Contrato conRafa = new Contrato();
// Documentos.Add(conRafa);

// Contrato Edu = new Contrato();
// Documentos.Add(Edu);


// // fatRafa.Imprimir();
// // relRafa.Imprimir();
// // conRafa.Imprimir();


// //Listar os Dados 
// // for(int i = 0; i < listafatura.Count; i++)
// // {
// //     listafatura[i].Imprimir();
// // }
// Console.WriteLine($"FATURAS");
// foreach (var fat in Documentos)
// {
//     if (fat is Fatura)
//     {
//         fat.Imprimir();
//     }
// }

// Console.WriteLine($"");

// Console.WriteLine($"RELATORIOS");
// foreach (var rel in Documentos)
// {
//     if (rel is Relatorio)
//     {
//         rel.Imprimir();
//     }
// }

// Console.WriteLine($"");

// Console.WriteLine($"CONTRATOS");
// foreach (var con in Documentos)
// {
//     if (con is Contrato)
//     {
//         con.Imprimir();
//     }
// }