public class Cafe : Bebida
{
    public override string Descricao => "Café";

    public override double Custo()
    {
        return 5.00; // Custo básico do café
    }
}
