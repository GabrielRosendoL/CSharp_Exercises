// Exercício 11: Trabalhando com Interfaces e Classes Abstratas

using System;
using System.Collections.Generic;

class Ex11
{
    public static void Run()
    {
        List<IApresentavel> apresentaveis = [];

        apresentaveis.Add(new Aluno { Nome = "João", Idade = 20, Matricula = "A123" });
        apresentaveis.Add(new Professor { Nome = "Maria", Idade = 45, Disciplina = "Matemática" });

        foreach (IApresentavel apresentavel in apresentaveis)
        {
            apresentavel.Apresentar();
        }
    }
}

interface IApresentavel
{
    void Apresentar();
}

abstract class Individuo : IApresentavel
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public abstract void Apresentar();
}

class Aluno : Individuo
{
    public string? Matricula { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine("Nome: {0}, Idade: {1}, Matrícula: {2}", Nome, Idade, Matricula);
    }
}

class Professor : Individuo
{
    public string? Disciplina { get; set; }

    // Implementando o método Apresentar
    public override void Apresentar()
    {
        Console.WriteLine("Nome: {0}, Idade: {1}, Disciplina: {2}", Nome, Idade, Disciplina);
    }
}

// NOTA I: A interface 'IApresentavel' define um método 'Apresentar' que deve ser implementado por qualquer classe que implemente a interface.

// NOTA II: A classe abstrata 'Pessoa' implementa a interface 'IApresentavel' e define um método abstrato 'Apresentar'.
// - As propriedades 'Nome' e 'Idade' são definidas na classe 'Pessoa'.
// - O método 'Apresentar' deve ser implementado nas classes derivadas.

// NOTA III: A classe 'Aluno' herda de 'Pessoa' e adiciona a propriedade 'Matricula'.
// - Ela implementa o método 'Apresentar' para incluir a matrícula na apresentação.

// NOTA IV: A classe 'Professor' herda de 'Pessoa' e adiciona a propriedade 'Disciplina'.
// - Ela implementa o método 'Apresentar' para incluir a disciplina na apresentação.

// NOTA V: No método 'Run', criamos uma lista de objetos 'IApresentavel' que pode conter objetos 'Aluno' e 'Professor'.
// - Utilizamos polimorfismo para chamar o método 'Apresentar' de cada objeto, que executa a versão apropriada do método com base no tipo do objeto.