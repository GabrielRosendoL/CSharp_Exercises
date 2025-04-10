// Exercício 9: Trabalhando com Listas, Manipulação de Strings e Tratamento de Exceções

using System;
using System.Collections.Generic;

// Definição de uma classe chamada 'Ex09'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex09_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex09',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma lista de strings chamada 'nomes'.
        // A lista será usada para armazenar os nomes fornecidos pelo usuário.
        List<string> nomes = new List<string>();

        // Chama o método 'PreencherLista' para preencher a lista 'nomes' com valores fornecidos pelo usuário.
        PreencherLista(nomes);

        // Solicita ao usuário que digite uma letra para contar os nomes que começam com ela.
        Console.Write("Digite uma letra para contar os nomes que começam com ela: ");
        string? inputLetra = Console.ReadLine();

        // Verifica se a entrada do usuário é nula ou vazia.
        // Caso seja, exibe uma mensagem de erro e encerra o método.
        if (string.IsNullOrEmpty(inputLetra))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite uma letra.");
            return;
        }

        // Obtém o primeiro caractere da entrada do usuário.
        // Digitamos 'inputLetra[0]' para acessar o primeiro caractere da string.
        // Usamos '0' pois os índices em C# começam em 0.
        char letra = inputLetra[0];

        // Chama o método 'ContarNomesQueComecamCom' para contar os nomes que começam com a letra fornecida.
        int contagem = ContarNomesQueComecamCom(nomes, letra);

        // Imprime no console o número de nomes que começam com a letra fornecida.
        Console.WriteLine("Número de nomes que começam com '{0}': {1}", letra, contagem);
    }

    // Método estático chamado 'PreencherLista'.
    // Este método preenche a lista fornecida como parâmetro com nomes fornecidos pelo usuário.
    public static void PreencherLista(List<string> lista)
    {
        // Um loop 'while' que continua solicitando nomes ao usuário até que ele digite 'sair'.
        while (true)
        {
            // Solicita ao usuário que digite um nome ou 'sair' para terminar.
            Console.Write("Digite um nome (ou 'sair' para terminar): ");
            string? input = Console.ReadLine();

            // Verifica se a entrada do usuário é nula ou se ele digitou 'sair' (ignorando maiúsculas/minúsculas).
            // Caso seja, o loop é encerrado com o comando 'break'.
            if (input == null || input.ToLower() == "sair")
            {
                break;
            }

            // Adiciona o nome fornecido pelo usuário à lista.
            lista.Add(input);
        }
    }

    // Método estático chamado 'ContarNomesQueComecamCom'.
    // Este método conta e retorna o número de nomes na lista que começam com uma letra específica.
    public static int ContarNomesQueComecamCom(List<string> lista, char letra)
    {
        // Declaração de uma variável inteira 'contagem' inicializada com 0.
        // Essa variável será usada para armazenar o número de nomes que atendem à condição.
        int contagem = 0;

        // Um loop 'foreach' que itera sobre cada nome na lista.
        foreach (string nome in lista)
        {
            // Verifica se o nome começa com a letra fornecida (ignorando maiúsculas/minúsculas).
            // O método 'StartsWith' é usado para verificar a condição.
            if (nome.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                // Incrementa a variável 'contagem' em 1 se a condição for verdadeira.
                contagem++;
            }
        }

        // Retorna o valor final da contagem.
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

// NOTA VII: O método 'StartsWith' é usado para verificar se uma string começa com outra string. 
// O parâmetro 'StringComparison.OrdinalIgnoreCase' garante que a comparação ignore maiúsculas/minúsculas.