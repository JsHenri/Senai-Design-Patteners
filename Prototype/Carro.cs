public class Carro : IVeiculo
{
    public string Modelo { get; set; }
    public Motor Motor { get; set; }

    public Carro(string modelo, Motor motor)
    {
        Modelo = modelo;
        Motor = motor;
    }

    // Implementação do método Clone
    public object Clone()
    {
        return this.MemberwiseClone(); // Clonagem superficial
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Carro Modelo: {Modelo}, Motor: {Motor.potencia}");
    }
}