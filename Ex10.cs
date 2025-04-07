// Exercício 10: Trabalhando com Classes, Objetos e Manipulação de Arquivos

using System;
using System.Collections.Generic;
using System.IO;

// Definição de uma classe chamada 'Ex10'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex10
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex10',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma lista de objetos 'Pessoa' chamada 'pessoas'.
        // Essa lista será usada para armazenar as informações de pessoas fornecidas pelo usuário.
        List<Pessoa> pessoas = new List<Pessoa>();

        // Chama o método 'PreencherLista' para preencher a lista 'pessoas' com informações fornecidas pelo usuário.
        PreencherLista(pessoas);

        // Chama o método 'SalvarPessoasEmArquivo' para salvar a lista de pessoas em um arquivo chamado 'pessoas.txt'.
        SalvarPessoasEmArquivo(pessoas, "pessoas.txt");

        // Chama o método 'CarregarPessoasDeArquivo' para carregar a lista de pessoas do arquivo 'pessoas.txt'.
        List<Pessoa> pessoasCarregadas = CarregarPessoasDeArquivo("pessoas.txt");

        // Imprime no console as informações das pessoas carregadas do arquivo.
        Console.WriteLine("Pessoas carregadas do arquivo:");
        foreach (Pessoa pessoa in pessoasCarregadas)
        {
            Console.WriteLine("Nome: {0}, Idade: {1}", pessoa.Nome, pessoa.Idade);
        }
    }

    // Método estático chamado 'PreencherLista'.
    // Este método preenche a lista fornecida como parâmetro com informações de pessoas fornecidas pelo usuário.
    public static void PreencherLista(List<Pessoa> lista)
    {
        // Um loop 'while' que continua solicitando informações ao usuário até que ele digite 'sair'.
        while (true)
        {
            // Solicita ao usuário que digite o nome de uma pessoa ou 'sair' para terminar.
            Console.Write("Digite o nome (ou 'sair' para terminar): ");
            string? nome = Console.ReadLine();

            // Verifica se o nome é nulo ou se o usuário digitou 'sair' (ignorando maiúsculas/minúsculas).
            // Caso seja, o loop é encerrado com o comando 'break'.
            if (nome == null || nome.ToLower() == "sair")
            {
                break;
            }

            // Solicita ao usuário que digite a idade da pessoa.
            Console.Write("Digite a idade: ");
            string? inputIdade = Console.ReadLine();

            // Tenta converter a entrada do usuário para um número inteiro usando 'int.TryParse'.
            // Se a conversão for bem-sucedida, cria um objeto 'Pessoa' com o nome e a idade fornecidos
            // e o adiciona à lista.
            if (int.TryParse(inputIdade, out int idade))
            {
                lista.Add(new Pessoa { Nome = nome, Idade = idade });
            }
            else
            {
                // Caso a entrada seja inválida, exibe uma mensagem de erro.
                Console.WriteLine("Idade inválida. Por favor, digite um número inteiro.");
            }
        }
    }

    // Método estático chamado 'SalvarPessoasEmArquivo'.
    // Este método salva a lista de pessoas em um arquivo de texto no formato 'Nome,Idade'.
    public static void SalvarPessoasEmArquivo(List<Pessoa> lista, string caminhoArquivo)
    {
        // Usa um 'StreamWriter' para escrever no arquivo especificado.
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            // Itera sobre cada pessoa na lista e escreve suas informações no arquivo.
            foreach (Pessoa pessoa in lista)
            {
                writer.WriteLine("{0},{1}", pessoa.Nome, pessoa.Idade);
            }
        }
    }

    // Método estático chamado 'CarregarPessoasDeArquivo'.
    // Este método carrega uma lista de pessoas a partir de um arquivo de texto no formato 'Nome,Idade'.
    public static List<Pessoa> CarregarPessoasDeArquivo(string caminhoArquivo)
    {
        // Declaração de uma lista de objetos 'Pessoa' para armazenar os dados carregados do arquivo.
        List<Pessoa> lista = new List<Pessoa>();

        // Usa um 'StreamReader' para ler o arquivo especificado.
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string? linha;
            // Lê cada linha do arquivo até o final.
            while ((linha = reader.ReadLine()) != null)
            {
                // Divide a linha em partes usando a vírgula como separador.
                string[] partes = linha.Split(',');

                // Verifica se a linha contém exatamente duas partes (nome e idade)
                // e tenta converter a segunda parte (idade) para um número inteiro.
                if (partes.Length == 2 && int.TryParse(partes[1], out int idade))
                {
                    // Cria um objeto 'Pessoa' com os dados lidos e o adiciona à lista.
                    lista.Add(new Pessoa { Nome = partes[0], Idade = idade });
                }
            }
        }

        // Retorna a lista de pessoas carregadas do arquivo.
        return lista;
    }
}

// Definição de uma classe chamada 'Pessoa'.
// Esta classe representa uma pessoa com duas propriedades: 'Nome' e 'Idade'.
class Pessoa
{
    // Propriedade 'Nome' para armazenar o nome da pessoa.
    public string? Nome { get; set; }

    // Propriedade 'Idade' para armazenar a idade da pessoa.
    public int Idade { get; set; }
}

// NOTA I: A classe 'Pessoa' é definida com duas propriedades: 'Nome' e 'Idade'.
// Essas propriedades utilizam métodos 'get' e 'set' para leitura e escrita dos valores.

// NOTA II: O método 'PreencherLista' preenche a lista com informações de pessoas fornecidas pelo usuário.
// Ele utiliza um loop 'while' para solicitar o nome e a idade de cada pessoa até que o usuário digite 'sair'.

// NOTA III: O método 'SalvarPessoasEmArquivo' salva a lista de pessoas em um arquivo de texto.
// Ele utiliza um 'StreamWriter' para escrever cada pessoa no formato 'Nome,Idade'.

// NOTA IV: O método 'CarregarPessoasDeArquivo' carrega a lista de pessoas de um arquivo de texto.
// Ele utiliza um 'StreamReader' para ler cada linha do arquivo e criar objetos 'Pessoa' a partir dos dados lidos.

// NOTA V: No método 'Run', a lista de pessoas é preenchida, salva em um arquivo, carregada do
// arquivo e as informações das pessoas carregadas são impressas no console.

// NOTA VI: As propriedades 'Nome' e 'Idade' na classe 'Pessoa' utilizam métodos 'get' e 'set'.
// - 'get' é usado para retornar o valor da propriedade.
// - 'set' é usado para atribuir um valor à propriedade.