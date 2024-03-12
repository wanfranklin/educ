Console.WriteLine("Digite um número: ");

int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.WriteLine();
Console.ReadKey();