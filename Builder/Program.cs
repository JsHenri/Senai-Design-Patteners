// Construção de um Carro Esportivo
ICarroBuilder esportivoBuilder = new CarroEsportivoBuilder();
ICarroBuilder popularBuilder = new CarroPopularBuilder();

Director diretor = new Director();
diretor.AddBuilder("esportivo", esportivoBuilder);
diretor.AddBuilder("popular", popularBuilder);

diretor.ConstruirCarro("esportivo", TipoPortas.DuasPortas, "Banco de Couro");
Carro carroEsportivo = diretor.ObterCarro();
Console.WriteLine(carroEsportivo);

// Construção de um Carro Popular
diretor.ConstruirCarro("popular", TipoPortas.QuatroPortas, "Teto Solar", "Vidro Elétrico");
Carro carroPopular1 = diretor.ObterCarro();
Console.WriteLine(carroPopular1);

// Construção de um Carro Popular
diretor.ConstruirCarro("popular", TipoPortas.QuatroPortas);
Carro carroPopular2 = diretor.ObterCarro();
Console.WriteLine(carroPopular2);