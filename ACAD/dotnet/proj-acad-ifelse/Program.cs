
int idade = 18;

if (idade <= 17)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você é maior de idade.");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você é menor de idade.");
    Console.ForegroundColor = ConsoleColor.White;
}
