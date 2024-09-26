// Fábrica de veículos elétricos
IVeiculoFactory factory;
ICarro carro;
IMoto  moto;


factory = new VeiculoEletricoFactory();
carro = factory.CriarCarro();
moto  = factory.CriarMoto();
carro.ExibirDetalhes();  // Saída: Carro elétrico com bateria de longa duração.
moto.ExibirDetalhes();   // Saída: Moto elétrica com carregamento rápido.


factory = new VeiculoCombustaoFactory();
carro = factory.CriarCarro();
moto  = factory.CriarMoto();
carro.ExibirDetalhes();  // Saída: Carro a combustão com motor V8.
moto.ExibirDetalhes();   // Saída: Moto a combustão com motor 600cc.

