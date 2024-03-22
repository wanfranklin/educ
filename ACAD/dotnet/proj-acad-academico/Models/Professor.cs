namespace Models;

public class Professor
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Disciplina { get; set; }

    public Professor(string nome, int idade, string disciplina)
    {
        Nome = nome;
        Idade = idade;
        Disciplina = disciplina;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Professor: {Nome} - Idade \"{Idade}\"");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Disciplina: {Disciplina}");
    }
}