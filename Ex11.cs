using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Exercício 11: Trabalhando com Herança, Interfaces e Serialização JSON
// Este exercício demonstra conceitos avançados de Programação Orientada a Objetos
// como herança, polimorfismo, interfaces e serialização de dados em JSON

// Interface que define o contrato para entidades que podem ser salvas
// Uma interface é um contrato que define quais métodos uma classe deve implementar
interface ISalvavel
{
    void Salvar(string caminhoArquivo);
    void Carregar(string caminhoArquivo);
}

// Classe base Pessoa
// Esta é a classe base que contém os atributos e comportamentos comuns
// O modificador 'virtual' permite que as classes filhas sobrescrevam o método
class Pessoa
{
    // Propriedades da classe Pessoa
    // O '?' indica que a propriedade pode ser nula
    public string? Nome { get; set; }
    public int Idade { get; set; }

    // Método virtual que pode ser sobrescrito pelas classes filhas
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

// Classe Aluno que herda de Pessoa
// O ':' indica que Aluno herda de Pessoa
// Herança permite reutilizar código e criar uma hierarquia de classes
class Aluno : Pessoa
{
    // Propriedades específicas de Aluno
    public string? Matricula { get; set; }
    // Lista de disciplinas do aluno
    public List<string> Disciplinas { get; set; } = new List<string>();

    // Sobrescreve o método da classe base
    // O 'override' indica que estamos sobrescrevendo um método virtual
    public override void ExibirInformacoes()
    {
        // Chama o método da classe base
        base.ExibirInformacoes();
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine("Disciplinas:");
        // Loop para exibir todas as disciplinas
        foreach (var disciplina in Disciplinas)
        {
            Console.WriteLine($"- {disciplina}");
        }
    }
}

// Classe Professor que herda de Pessoa
class Professor : Pessoa
{
    // Propriedades específicas de Professor
    public string? Departamento { get; set; }
    // Lista de disciplinas que o professor leciona
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();

    // Sobrescreve o método da classe base
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine("Disciplinas Lecionadas:");
        foreach (var disciplina in DisciplinasLecionadas)
        {
            Console.WriteLine($"- {disciplina}");
        }
    }
}

// Classe principal do exercício
class Ex11
{
    // Lista estática para armazenar todas as pessoas
    // O modificador 'private' indica que só pode ser acessada dentro desta classe
    private static List<Pessoa> pessoas = new List<Pessoa>();

    // Método principal que inicia o programa
    public static void Run()
    {
        try
        {
            Console.WriteLine("Sistema de Cadastro de Pessoas");
            Console.WriteLine("=============================");

            // Loop principal do menu
            while (true)
            {
                // Exibe as opções do menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cadastrar Aluno");
                Console.WriteLine("2. Cadastrar Professor");
                Console.WriteLine("3. Listar Pessoas");
                Console.WriteLine("4. Salvar Dados");
                Console.WriteLine("5. Carregar Dados");
                Console.WriteLine("6. Sair");

                Console.Write("\nEscolha uma opção: ");
                string? opcao = Console.ReadLine();

                // Switch para processar a opção escolhida
                switch (opcao)
                {
                    case "1":
                        CadastrarAluno();
                        break;
                    case "2":
                        CadastrarProfessor();
                        break;
                    case "3":
                        ListarPessoas();
                        break;
                    case "4":
                        SalvarDados();
                        break;
                    case "5":
                        CarregarDados();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    // Método para cadastrar um novo aluno
    private static void CadastrarAluno()
    {
        try
        {
            // Cria uma nova instância de Aluno
            var aluno = new Aluno();

            // Solicita e valida os dados do aluno
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                aluno.Idade = idade;
            }
            else
            {
                throw new Exception("Idade inválida!");
            }

            Console.Write("Matrícula: ");
            aluno.Matricula = Console.ReadLine();

            // Loop para adicionar disciplinas
            Console.WriteLine("Digite as disciplinas (uma por linha, digite 'fim' para terminar):");
            string? disciplina;
            while ((disciplina = Console.ReadLine()) != "fim")
            {
                if (!string.IsNullOrWhiteSpace(disciplina))
                {
                    aluno.Disciplinas.Add(disciplina);
                }
            }

            // Adiciona o aluno à lista
            pessoas.Add(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar aluno: {ex.Message}");
        }
    }

    // Método para cadastrar um novo professor
    private static void CadastrarProfessor()
    {
        try
        {
            // Cria uma nova instância de Professor
            var professor = new Professor();

            // Solicita e valida os dados do professor
            Console.Write("Nome do professor: ");
            professor.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                professor.Idade = idade;
            }
            else
            {
                throw new Exception("Idade inválida!");
            }

            Console.Write("Departamento: ");
            professor.Departamento = Console.ReadLine();

            // Loop para adicionar disciplinas lecionadas
            Console.WriteLine("Digite as disciplinas lecionadas (uma por linha, digite 'fim' para terminar):");
            string? disciplina;
            while ((disciplina = Console.ReadLine()) != "fim")
            {
                if (!string.IsNullOrWhiteSpace(disciplina))
                {
                    professor.DisciplinasLecionadas.Add(disciplina);
                }
            }

            // Adiciona o professor à lista
            pessoas.Add(professor);
            Console.WriteLine("Professor cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar professor: {ex.Message}");
        }
    }

    // Método para listar todas as pessoas cadastradas
    private static void ListarPessoas()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            return;
        }

        Console.WriteLine("\nLista de Pessoas:");
        Console.WriteLine("=================");
        // Usa polimorfismo para chamar o método ExibirInformacoes apropriado
        foreach (var pessoa in pessoas)
        {
            pessoa.ExibirInformacoes();
            Console.WriteLine("-----------------");
        }
    }

    // Método para salvar os dados em um arquivo JSON
    private static void SalvarDados()
    {
        try
        {
            // Serializa a lista de pessoas para JSON
            string json = JsonSerializer.Serialize(pessoas, new JsonSerializerOptions { WriteIndented = true });
            // Salva o JSON em um arquivo
            File.WriteAllText("pessoas.json", json);
            Console.WriteLine("Dados salvos com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar dados: {ex.Message}");
        }
    }

    // Método para carregar os dados de um arquivo JSON
    private static void CarregarDados()
    {
        try
        {
            // Verifica se o arquivo existe
            if (!File.Exists("pessoas.json"))
            {
                Console.WriteLine("Arquivo de dados não encontrado.");
                return;
            }

            // Lê o arquivo JSON
            string json = File.ReadAllText("pessoas.json");
            // Deserializa o JSON para uma lista de pessoas
            pessoas = JsonSerializer.Deserialize<List<Pessoa>>(json) ?? new List<Pessoa>();
            Console.WriteLine("Dados carregados com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar dados: {ex.Message}");
        }
    }
} 