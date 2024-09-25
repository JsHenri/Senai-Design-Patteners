public class ExternalPaymentService
{
    public void MakeExternalPayment(decimal value)
    {
        Console.WriteLine($"Pagamento de {value} processado pelo serviço externo.");
    }
}