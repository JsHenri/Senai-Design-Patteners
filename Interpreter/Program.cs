// Expressão para 5
IExpression five = new NumberExpression(5);

// Expressão para 10
IExpression ten = new NumberExpression(10);

// Expressão para 5 + 10
IExpression add = new AddExpression(five, ten);

// Expressão para 3
IExpression three = new NumberExpression(3);

// Expressão para 2
IExpression two = new NumberExpression(2);

// Expressão para 3 + 2
IExpression add2 = new AddExpression(three, two);

// Expressão para (5 + 10) - (3 + 2)
IExpression subtract = new SubtractExpression(add, add2);

// Interpretando a expressão
Console.WriteLine($"Resultado: {subtract.Interpret()}");

