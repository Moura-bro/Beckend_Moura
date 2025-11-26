using Exercicio01;

Carro Civic = new Carro();
Civic.DefinirMarca("Honda");
Civic.ObterMarca();
Civic.DefinirModelo("Conversivel");
Civic.ObterModelo();
Thread.Sleep(1000);

Civic.Acelerar(0);

Thread.Sleep(1000);

Civic.Frear(190);

Thread.Sleep(1000);
Civic.ObterVelocidade();
