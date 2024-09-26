FlyweightFactory factory = new FlyweightFactory();

// Criando e reutilizando figuras (estado intrínseco é o tipo da figura)
IFigura triangulo1 = factory.GetFigura("Triangulo");
triangulo1.Desenhar("Vermelho"); // Estado extrínseco é a cor

IFigura quadrado1 = factory.GetFigura("Quadrado");
quadrado1.Desenhar("Azul");

IFigura losango1 = factory.GetFigura("Losango");
losango1.Desenhar("Verde");

// Reutilizando as mesmas instâncias para desenhar em outras cores
IFigura triangulo2 = factory.GetFigura("Triangulo");
triangulo2.Desenhar("Amarelo");

IFigura quadrado2 = factory.GetFigura("Quadrado");
quadrado2.Desenhar("Preto");

IFigura losango2 = factory.GetFigura("Losango");
losango2.Desenhar("Roxo");
