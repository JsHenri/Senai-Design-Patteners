public interface IVeiculo : ICloneable
{
    string Modelo { get; set; }
    Motor Motor { get; set; }
    void ExibirDetalhes();
}