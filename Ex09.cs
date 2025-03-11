// Exercício 9: Trabalhando com Listas, Manipulação de Strings e Tratamento de Exceções

using System;
using System.Collections.Generic;

class Ex09
{
    public static void Run()
    {
        List<string> nomes = new List<string>();

        PreencherLista(nomes);

        Console.Write("Digite uma letra para contar os nomes que começam com ela: ");
        string? inputLetra = Console.ReadLine();

        if (string.IsNullOrEmpty(inputLetra))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite uma letra.");
            return;
        }

        char letra = inputLetra[0];

        int contagem = ContarNomesQueComecamCom(nomes, letra);

        Console.WriteLine("Número de nomes que começam com '{0}': {1}", letra, contagem);
    }

    public static void PreencherLista(List<string> lista)
    {
        while (true)
        {
            Console.Write("Digite um nome (ou 'sair' para terminar): ");
            string? input = Console.ReadLine();

            if (input == null || input.ToLower() == "sair")
            {
                break;
            }

            lista.Add(input);
        }
    }

    public static int ContarNomesQueComecamCom(List<string> lista, char letra)
    {
        int contagem = 0;
        foreach (string nome in lista)
        {
            if (nome.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                contagem++;
            }
        }
        return contagem;
    }
}

// NOTA I: A lista 'nomes' é inicializada como uma nova lista de strings. Ela será usada para armazenar os nomes fornecidos pelo usuário.

// NOTA II: O método 'PreencherLista' preenche a lista com nomes fornecidos pelo usuário. 
// Ele utiliza um loop 'while' para solicitar nomes até que o usuário digite 'sair'.

// NOTA III: No método 'PreencherLista', verificamos se a entrada do usuário é 'sair' (ignorando maiúsculas/minúsculas) para terminar o loop.

// NOTA IV: O método 'ContarNomesQueComecamCom' conta quantos nomes na lista começam com uma letra específica. 
// Ele utiliza um loop 'foreach' para iterar sobre cada nome na lista e o método 'StartsWith' para verificar a condição.

// NOTA V: No método 'ContarNomesQueComecamCom', utilizamos 'StringComparison.OrdinalIgnoreCase' para ignorar maiúsculas/minúsculas na comparação.

// NOTA VI: No método 'Run', verificamos se a entrada do usuário para a letra não é nula ou vazia antes de acessar o primeiro caractere.