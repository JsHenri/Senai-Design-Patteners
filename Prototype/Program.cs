// Instância inicial de um carro
Carro carro1 = new Carro("Sedan",new Motor(2000));
carro1.ExibirDetalhes(); // Saída: Carro Modelo: Sedan, Motor: Motor 2.0
Console.WriteLine("************* 1 ************");

// Clonando o carro
Carro carro2 = (Carro)carro1.Clone();
carro2.Modelo = "Hatchback"; // Alterando apenas o modelo no clone
carro2.ExibirDetalhes(); // Saída: Carro Modelo: Hatchback, Motor: Motor 2.0
carro1.ExibirDetalhes(); // Saída: Carro Modelo: Sedan, Motor: Motor 2.0

Console.WriteLine("************ 2 *************");
carro1.Motor.potencia = 4000;
carro2.ExibirDetalhes(); // Saída: Carro Modelo: Hatchback, Motor: Motor 2.0
carro1.ExibirDetalhes(); // Saída: Carro Modelo: Sedan, Motor: Motor 2.0

Console.WriteLine("************ 3 *************");
// Instância inicial de uma moto
Moto moto1 = new Moto("Esportiva", new Motor(600));
moto1.ExibirDetalhes(); // Saída: Moto Modelo: Esportiva, Motor: Motor 600cc

// Clonando a moto
Moto moto2 = (Moto)moto1.Clone();
moto2.Modelo = "Custom"; // Alterando o modelo no clone
moto2.ExibirDetalhes(); // Saída: Moto Modelo: Custom, Motor: Motor 600cc
moto1.ExibirDetalhes(); // Saída: Moto Modelo: Esportiva, Motor: Motor 600cc