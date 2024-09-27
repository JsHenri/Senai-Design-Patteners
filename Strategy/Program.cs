 Calculadora calculadora = new Calculadora();

 List <IOperacao> operacoes = new List<IOperacao>();

 operacoes.Add(new Adicao());
 operacoes.Add(new Divisao());
 operacoes.Add(new Multiplicacao());
 operacoes.Add(new Subtracao());

foreach(IOperacao op in operacoes)
{
    calculadora.DefinirOperacao(op);
    Console.WriteLine($"Resultado: {calculadora.Calcular(4,3)}");
}
