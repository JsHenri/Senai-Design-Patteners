// Construção de um Carro Esportivo
ICarroBuilder esportivoBuilder = new CarroEsportivoBuilder();
Director diretor = new Director(esportivoBuilder);
diretor.ConstruirCarro(TipoPortas.DuasPortas, "Banco de Couro");
Carro carroEsportivo = diretor.ObterCarro();
Console.WriteLine(carroEsportivo);

// Construção de um Carro Popular
ICarroBuilder popularBuilder = new CarroPopularBuilder();
diretor = new Director(popularBuilder);
diretor.ConstruirCarro(TipoPortas.QuatroPortas, "Teto Solar", "Vidro Elétrico");
Carro carroPopular = diretor.ObterCarro();
Console.WriteLine(carroPopular);