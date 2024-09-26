public class Moto : IVeiculo
{
    public string Modelo { get; set; }
    public Motor Motor { get; set; }

    public Moto(string modelo, Motor motor)
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
        Console.WriteLine($"Moto Modelo: {Modelo}, Motor: {Motor.potencia}");
    }
}