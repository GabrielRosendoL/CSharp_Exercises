// Exercício 10: Trabalhando com Classes, Objetos e Manipulação de Arquivos

using System;
using System.Collections.Generic;
using System.IO;

class Ex10
{
    public static void Run()
    {
        // OU List<Pessoa> pessoas = new List<Pessoa>();
        List<Pessoa> pessoas = [];

        PreencherLista(pessoas);

        SalvarPessoasEmArquivo(pessoas, "pessoas.txt");

        List<Pessoa> pessoasCarregadas = CarregarPessoasDeArquivo("pessoas.txt");

        Console.WriteLine("Pessoas carregadas do arquivo:");
        foreach (Pessoa pessoa in pessoasCarregadas)
        {
            Console.WriteLine("Nome: {0}, Idade: {1}", pessoa.Nome, pessoa.Idade);
        }
    }

    //MÉTODOS (ENCAPSULAMENTO)
    public static void PreencherLista(List<Pessoa> lista)
    {
        while (true)
        {
            Console.Write("Digite o nome (ou 'sair' para terminar): ");
            string? nome = Console.ReadLine();

            if (nome == null || nome.ToLower() == "sair")
            {
                break;
            }

            Console.Write("Digite a idade: ");
            string? inputIdade = Console.ReadLine();
            if (int.TryParse(inputIdade, out int idade))
            {
                lista.Add(new Pessoa { Nome = nome, Idade = idade });
            }
            else
            {
                Console.WriteLine("Idade inválida. Por favor, digite um número inteiro.");
            }
        }
    }

    //MÉTODOS (ENCAPSULAMENTO)
    public static void SalvarPessoasEmArquivo(List<Pessoa> lista, string caminhoArquivo)
    {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            foreach (Pessoa pessoa in lista)
            {
                writer.WriteLine("{0},{1}", pessoa.Nome, pessoa.Idade);
            }
        }
    }

    //MÉTODOS (ENCAPSULAMENTO)
    public static List<Pessoa> CarregarPessoasDeArquivo(string caminhoArquivo)
    {
        // OU List<Pessoa> lista = new List<Pessoa>();
        List<Pessoa> lista = [];

        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string? linha;
            while ((linha = reader.ReadLine()) != null)
            {
                string[] partes = linha.Split(',');
                if (partes.Length == 2 && int.TryParse(partes[1], out int idade))
                {
                    //CRIAÇÃO DE OBJETOS
                    lista.Add(new Pessoa { Nome = partes[0], Idade = idade });
                }
            }
        }

        return lista;
    }
}

// CLASSE
class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}

// NOTA I: A classe 'Pessoa' é definida com duas propriedades: 'Nome' e 'Idade'.

// NOTA II: O método 'PreencherLista' preenche a lista com informações de pessoas fornecidas pelo usuário. 
// Ele utiliza um loop 'while' para solicitar o nome e a idade de cada pessoa até que o usuário digite 'sair'.

// NOTA III: O método 'SalvarPessoasEmArquivo' salva a lista de pessoas em um arquivo de texto. 
// Ele utiliza um 'StreamWriter' para escrever cada pessoa no formato 'Nome,Idade'.

// NOTA IV: O método 'CarregarPessoasDeArquivo' carrega a lista de pessoas de um arquivo de texto. 
// Ele utiliza um 'StreamReader' para ler cada linha do arquivo e criar objetos 'Pessoa' a partir dos dados lidos.

// NOTA V: No método 'Run', a lista de pessoas é preenchida, salva em um arquivo, carregada do 
// arquivo e as informações das pessoas carregadas são impressas.

// NOTA VI: As propriedades 'Nome' e 'Idade' na classe 'Pessoa' utilizam métodos 'get' e 'set'.
// - 'get' é usado para retornar o valor da propriedade.
// - 'set' é usado para atribuir um valor à propriedade.
// - Por exemplo, 'public string? Nome { get; set; }' define uma propriedade 'Nome' que pode ser lida e escrita.
// - Quando você acessa 'pessoa.Nome', o método 'get' é chamado para retornar o valor.
// - Quando você atribui um valor a 'pessoa.Nome', o método 'set' é chamado para definir o valor.