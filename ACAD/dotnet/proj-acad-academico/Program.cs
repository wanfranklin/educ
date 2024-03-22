using Models;

try
{
    Aluno aluno = new ("João da Silva", 22, "ADS", 123456789);
    aluno.ExibirInformacoes();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("######################");
    Console.ForegroundColor = ConsoleColor.White;

    Professor professor = new ("Wan", 10, "PSC");
    professor.ExibirInformacoes();
}
catch (Exception ex)
{
   Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message.ToString());
    Console.ForegroundColor = ConsoleColor.White;
}
