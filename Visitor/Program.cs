// Criando as formas
IForma circulo = new Circulo(5);
IForma retangulo = new Retangulo(4, 6);

// Criando os visitantes
IVisitor desenharVisitor = new DesenharVisitor();
IVisitor areaVisitor = new AreaVisitor();

// Aplicando o visitante de desenhar
Console.WriteLine("Desenhando formas:");
circulo.Aceitar(desenharVisitor);
retangulo.Aceitar(desenharVisitor);

// Aplicando o visitante de calcular área
Console.WriteLine("\nCalculando áreas:");
circulo.Aceitar(areaVisitor);
retangulo.Aceitar(areaVisitor);