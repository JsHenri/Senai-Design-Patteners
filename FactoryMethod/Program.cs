// Fábrica de Carros
VeiculoFactory carroFactory = new CarroFactory();
VeiculoFactory motoFactory = new MotoFactory();

IVeiculo v;

v = carroFactory.CriarVeiculo();
v.Dirigir();  // Saída: Dirigindo um carro.

v = carroFactory.CriarVeiculo();
v.Dirigir();  // Saída: Dirigindo um carro.

v = motoFactory.CriarVeiculo();
v.Dirigir();  // Saída: Dirigindo um moto