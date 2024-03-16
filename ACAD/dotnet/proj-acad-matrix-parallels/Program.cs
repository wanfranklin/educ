
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

verificarAbertura("code");
verificarAbertura("notepad");


/*
using System.Diagnostics;

ProcessStartInfo startInfo = new();
startInfo.FileName = "notepad.exe";

ProcessStartInfo startInfo2 = new();
startInfo2.FileName = "calc.exe";

Process.Start(startInfo);
Process.Start(startInfo2);
Console.WriteLine("O Bloco de Notas foi iniciado em um processo separado.");

var numeros = Enumerable.Range(1, 1000000);
var pares = numeros.AsParallel().Where(n => n % 2 == 0).ToArray();
Console.WriteLine($"Quantidade de números pares: {pares.Length}");


using System.Numerics;

int tamanho = 4;

int[,] matrixA = new int[4, 4] { {1,2,3,4}, {5,6,7,8}, {9,19,11,12}, {13,14,15,16} };
int[,] matrixB = new int[4, 4] { {16,15,14,13}, {12,11,10,9}, {8,7,6,5}, {4,7,2,1} };

int[,] resultado = new int[tamanho, tamanho];

Parallel.For(0, tamanho, i =>
{
    for (int j = 0; j < tamanho; i++)
    {
        for (int k = 0; k < tamanho; i++)
        {
            resultado[i, j] += matrixA[i, k] * 
            matrixB[k, j];
        }
    }
});

Console.WriteLine("Matrix");

ImprimirMatrix(resultado);

static void ImprimirMatrix(int[,] matrix)
{
    int linha = matrix.GetLength(0);
    int coluna = matrix.GetLength(1);

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.WriteLine(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
*/