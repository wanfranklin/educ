using System.Diagnostics;

Action<string> verificarAbertura = programa =>
{
    Process[] processos = Process.GetProcessesByName(programa);

    if (processos.Length > 0)
    {
        Console.WriteLine($"{programa} está aberto.");
    }
    else
    {
        Console.WriteLine($"{programa} não está aberto.");
    }
};

verificarAbertura("chrome");
verificarAbertura("notepad");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Processo {i} executando.");
}

 Console.WriteLine("#######################");

Parallel.For(0, 10, i =>
{
    Console.WriteLine($"Thread {i} executando.");
});

 Console.WriteLine("#######################");

 
var numeros = Enumerable.Range(1, 1000000);
var pares = numeros.AsParallel().Where(n => n % 2 == 0).ToArray();
Console.WriteLine($"Quantidade de números pares: {pares.Length}");


ProcessStartInfo startInfo = new();
startInfo.FileName = "notepad.exe";
Process.Start(startInfo);
Console.WriteLine("O Bloco de Notas foi iniciado em um processo separado.");