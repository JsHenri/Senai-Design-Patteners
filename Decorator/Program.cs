// Um café simples
Bebida bebida = new Cafe();
Console.WriteLine($"{bebida.Descricao} custa {bebida.Custo():C2}");

// Café com leite
bebida = new Leite(bebida);
Console.WriteLine($"{bebida.Descricao} custa {bebida.Custo():C2}");

// Café com leite e açúcar
bebida = new Acucar(bebida);
Console.WriteLine($"{bebida.Descricao} custa {bebida.Custo():C2}");