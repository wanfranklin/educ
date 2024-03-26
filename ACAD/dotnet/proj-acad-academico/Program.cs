// https://github.com/wanfranklin/educ

static class Program
{
    static void Main(string[] args)
    {
        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("###############");
        Console.WriteLine("SISTEMA ACADÊMICO");
        Console.WriteLine("###############");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine();
        Console.WriteLine("1. Visualizar nota");
        Console.WriteLine("2. Adicionar aluno");
        Console.WriteLine("3. Remover aluno");
        Console.WriteLine("4. Sair");
        Console.WriteLine("\nDigite o número da opção desejada: ");

        switch (Console.ReadLine())
        {
            case "1":
            VisualizarNotas();
            return true;
            case "2":
            return true;
            case "3":
            return true;
            case "4":
            Sair();
            return false;
            default:
            return true;
        }
    }

    private static void VisualizarNotas()
    {
        Console.WriteLine("Visualizando Notas...");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
    private static void Sair()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.S)
        {
            Console.WriteLine("Saindo...");
        }
    }
}