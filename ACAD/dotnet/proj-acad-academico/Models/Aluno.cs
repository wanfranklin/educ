
namespace Models;

public class Aluno(
    long id,
    string nome, 
    int idade, 
    string curso, 
    long matricula
    )
{
    public long Id { get; set; } = id;
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public string Curso { get; set; } = curso;
    public long Matricula { get; set; } = matricula;

    public void ExibirInformacoes()
    {   
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, "
        + $"Curso: {Curso}, Matrícula: {Matricula} ");
    }

}