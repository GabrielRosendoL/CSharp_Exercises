// Exercício 10: Trabalhando com Arquivos, Estruturas de Dados e Tratamento de Exceções
// Este exercício demonstra conceitos avançados de manipulação de arquivos, estruturas de dados
// e tratamento de exceções em C#

using System;
using System.Collections.Generic;
using System.IO;

// Classe que representa um contato
// Esta classe encapsula os dados de um contato (nome, telefone e email)
// e fornece uma representação em string personalizada através do método ToString
class Contato
{
    // Propriedades da classe Contato
    // O modificador 'public' permite que estas propriedades sejam acessadas de fora da classe
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    // Construtor da classe Contato
    // Este método é chamado quando um novo objeto Contato é criado
    // Ele inicializa as propriedades com os valores fornecidos
    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    // Sobrescreve o método ToString da classe base Object
    // Este método é chamado automaticamente quando o objeto é convertido para string
    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
    }
}

// Classe principal do exercício
// Esta classe contém a lógica principal do programa e gerencia a agenda de contatos
class Ex10_Class
{
    // Lista estática para armazenar os contatos
    // O modificador 'private' indica que só pode ser acessada dentro desta classe
    private static List<Contato> agenda = new List<Contato>();

    // Constante que define o nome do arquivo onde os contatos serão salvos
    private const string arquivoAgenda = "agenda.txt";

    // Método principal que inicia o programa
    // Este método é responsável por exibir o menu e processar as opções do usuário
    public static void Run()
    {
        try
        {
            Console.WriteLine("Sistema de Agenda de Contatos");
            Console.WriteLine("============================");

            // Carrega os contatos do arquivo se existir
            CarregarAgenda();

            // Loop principal do menu
            while (true)
            {
                // Exibe as opções do menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Listar Contatos");
                Console.WriteLine("3. Buscar Contato");
                Console.WriteLine("4. Remover Contato");
                Console.WriteLine("5. Salvar Agenda");
                Console.WriteLine("6. Sair");

                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine()!;

                // Switch para processar a opção escolhida
                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
                        break;
                    case "3":
                        BuscarContato();
                        break;
                    case "4":
                        RemoverContato();
                        break;
                    case "5":
                        SalvarAgenda();
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

    // Método para adicionar um novo contato
    // Este método solicita os dados do contato ao usuário e os valida
    private static void AdicionarContato()
    {
        try
        {
            // Solicita e valida os dados do contato
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine()!;

            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Todos os campos são obrigatórios!");
            }

            // Adiciona o novo contato à lista
            agenda.Add(new Contato(nome, telefone, email));
            Console.WriteLine("Contato adicionado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar contato: {ex.Message}");
        }
    }

    // Método para listar todos os contatos
    // Este método exibe todos os contatos cadastrados na agenda
    private static void ListarContatos()
    {
        if (agenda.Count == 0)
        {
            Console.WriteLine("Nenhum contato cadastrado.");
            return;
        }

        Console.WriteLine("\nLista de Contatos:");
        Console.WriteLine("=================");
        foreach (var contato in agenda)
        {
            Console.WriteLine(contato);
        }
    }

    // Método para buscar contatos por nome
    // Este método permite buscar contatos que contenham o texto fornecido no nome
    private static void BuscarContato()
    {
        Console.Write("Digite o nome do contato: ");
        string nomeBusca = Console.ReadLine()!;

        // Usa expressão lambda para encontrar contatos que contenham o texto de busca
        var contatosEncontrados = agenda.FindAll(c => c.Nome.Contains(nomeBusca, StringComparison.OrdinalIgnoreCase));

        if (contatosEncontrados.Count == 0)
        {
            Console.WriteLine("Nenhum contato encontrado.");
            return;
        }

        Console.WriteLine("\nContatos encontrados:");
        foreach (var contato in contatosEncontrados)
        {
            Console.WriteLine(contato);
        }
    }

    // Método para remover um contato
    // Este método remove um contato da agenda pelo nome
    private static void RemoverContato()
    {
        Console.Write("Digite o nome do contato a ser removido: ");
        string nomeRemover = Console.ReadLine()!;

        // Procura o contato pelo nome exato
        var contato = agenda.Find(c => c.Nome.Equals(nomeRemover, StringComparison.OrdinalIgnoreCase));

        if (contato == null)
        {
            Console.WriteLine("Contato não encontrado.");
            return;
        }

        agenda.Remove(contato);
        Console.WriteLine("Contato removido com sucesso!");
    }

    // Método para carregar a agenda do arquivo
    // Este método lê os contatos do arquivo e os adiciona à lista
    private static void CarregarAgenda()
    {
        try
        {
            if (!File.Exists(arquivoAgenda))
            {
                return;
            }

            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(arquivoAgenda);
            foreach (string linha in linhas)
            {
                // Divide a linha usando o caractere '|' como separador
                string[] dados = linha.Split('|');
                if (dados.Length == 3)
                {
                    // Cria um novo contato com os dados lidos
                    agenda.Add(new Contato(dados[0], dados[1], dados[2]));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar agenda: {ex.Message}");
        }
    }

    // Método para salvar a agenda no arquivo
    // Este método salva todos os contatos da lista em um arquivo
    private static void SalvarAgenda()
    {
        try
        {
            List<string> linhas = new List<string>();
            foreach (var contato in agenda)
            {
                // Formata cada contato como uma linha do arquivo
                linhas.Add($"{contato.Nome}|{contato.Telefone}|{contato.Email}");
            }

            // Salva todas as linhas no arquivo
            File.WriteAllLines(arquivoAgenda, linhas);
            Console.WriteLine("Agenda salva com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar agenda: {ex.Message}");
        }
    }
} 