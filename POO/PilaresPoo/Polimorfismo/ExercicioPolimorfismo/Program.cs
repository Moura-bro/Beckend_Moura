using ExercicioPolimorfismo;

PagamentoPix Pix = new PagamentoPix();
Pix.ValorCompra = 30000;
float valor = Pix.CalcularTotal();
Console.WriteLine($"Produto: Pc Gamer");
Console.WriteLine($"Preco: {Pix.ValorCompra}");
Console.WriteLine($"Valor do Pc via pix com desconto: {valor}");
Console.WriteLine($"");

PagamentoCartao Cartao = new PagamentoCartao();
Cartao.ValorCompra = 56;
Console.WriteLine($"Produto: Caneca Personlizada Santos futebol clube");
Console.WriteLine($"Preco: {Cartao.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartao");
Console.WriteLine($"Pagamnto com Acrescimo do Cartao: {Cartao.CalcularTotal()}");
Console.WriteLine($"");