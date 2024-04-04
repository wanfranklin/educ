namespace Models;

public class Professor
{
    public long Id { get; set; } 
    public string Nome { get; set; }
    public int? Idade { get; set; }
    public string Disciplina { get; set; }

    public Professor(long id, string nome, int idade, string disciplina)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
        Disciplina = disciplina;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Professor: {Nome} - Idade {Idade}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Disciplina: {Disciplina}");
    }
}