Console.WriteLine(" Digite seu nome completo.");
string nome = Console.ReadLine();

Console.WriteLine(" Quantos quartos tem na sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine(" Entre com o preço de um produto");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine(" Entre seu ultimo nome, idade e altura (Mesma Linha)");
string[] vet = Console.ReadLine().Split(' '); // Armazena o que o usuário digitou e o split separa em variáveis a cada ' ' espaço
string UltimoNome = vet[0]; // primeira posição do vetor é sempre a 0, Ultimonome no caso está recebendo a primeira parte do vetor
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco);
Console.WriteLine(UltimoNome);  
Console.WriteLine(idade);
Console.WriteLine(altura);
