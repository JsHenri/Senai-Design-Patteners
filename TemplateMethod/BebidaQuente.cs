using System;

public abstract class BebidaQuente
{
    // Método Template: define os passos da preparação
    public void Preparar()
    {
        FerverAgua();
        PrepararBebida();
        ServirNoCopo();
        AdicionarComplementos();
    }

    // Passos comuns
    private void FerverAgua()
    {
        Console.WriteLine("Fervendo água...");
    }

    private void ServirNoCopo()
    {
        Console.WriteLine("Servindo no copo...");
    }

    // Passos que serão implementados pelas subclasses
    protected abstract void PrepararBebida();
    protected abstract void AdicionarComplementos();
}
