Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

int anoNascimento = DateTime.Now.Year - idade;

Console.WriteLine($"Olá, {nome}! Você nasceu em {anoNascimento}.");

Console.ReadLine();