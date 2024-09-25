// Criando arquivos
IComponent file1 = new File("file1.txt");
IComponent file2 = new File("file2.txt");
IComponent file3 = new File("file3.txt");

// Criando diretórios
Directory directory1 = new Directory("Folder1");
Directory directory2 = new Directory("Folder2");
Directory directory3 = new Directory("SubFolder1");

// Adicionando arquivos a diretórios
directory1.Add(file1);
directory1.Add(file2);
directory2.Add(file3);

// Adicionando diretório a outro diretório
directory1.Add(directory3);

// Criando arquivos dentro do subdiretório
directory3.Add(new File("subfile1.txt"));
directory3.Add(new File("subfile2.txt"));

// Exibindo a estrutura
Console.WriteLine("File System Structure:");
directory1.Display();
directory2.Display();