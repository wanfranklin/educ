try
{
    
    #region Bloco Principal

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Por favor, insira três números para calcular a média.");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("Nota 1:");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Nota 2:");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Nota 3:");
    double numero3 = Convert.ToDouble(Console.ReadLine());

    double media = (numero1 + numero2 + numero3) / 3;

    if (media < 0)
    {
        Console.WriteLine("O valor digitado é negativo.");
        return;
    }

    if (media >= 6.0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O aluno foi aprovado com média: "
        + media.ToString("0.0"));
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O aluno foi reprovado com média: "
        + media.ToString("0.0"));
        Console.ResetColor();
    }

    #endregion
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erro: {ex.Message} - {DateTime.Now.ToString("dd/MM/yyyyy HH:mm:ss")}");
    Console.ResetColor();
}