// Criando objeto Aluno
using Models;

Aluno aluno = new ("João da Silva", 22, "ADS", 123456789);
aluno.ExibirInformacoes();

Console.WriteLine("######################");

Professor professor = new ("Wan", 10, "PSC");
professor.ExibirInformacoes();