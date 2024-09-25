// Usando o proxy para adiar o carregamento da imagem
IImage image = new ProxyImage("imagem_teste.jpg");

// A imagem será carregada apenas quando for exibida pela primeira vez
image.Display(); // Carrega e exibe a imagem
Console.WriteLine();

// Agora a imagem já está carregada, e só será exibida novamente
image.Display(); // Apenas exibe, sem recarregar        