// Exercício 8: Trabalhando com arrays e métodos

// Definição de uma classe chamada 'Ex08'.
// Uma classe é um contêiner que pode conter métodos, propriedades e outros membros.
// Classes são fundamentais na programação orientada a objetos.
class Ex08_Class
{
    // Definição de um método estático chamado 'Run'.
    // 'public' significa que o método pode ser acessado de fora da classe.
    // 'static' significa que o método pertence à classe e não a uma instância específica da classe.
    // Isso significa que você pode chamar o método 'Run' diretamente usando o nome da classe 'Ex08',
    // sem precisar criar um objeto dessa classe. Métodos estáticos são úteis para funcionalidades
    // que não dependem de dados específicos de uma instância da classe.
    // 'void' significa que o método não retorna nenhum valor.
    public static void Run()
    {
        // Declaração de uma variável inteira 'n' inicializada com o valor 3.
        // Essa variável define o tamanho do array, ou seja, quantos números serão armazenados.
        int n = 3;

        // Declaração de um array de inteiros chamado 'numeros' com 'n' elementos.
        // Este array será usado para armazenar os números fornecidos pelo usuário.
        // OBS: Para declarar um array em C# nós usamos a sintaxe 'tipo[] nomeDoArray = new tipo[tamanho]',
        int[] numeros = new int[n];

        // Chama o método 'PreencherArray' para preencher o array 'numeros' com valores fornecidos pelo usuário.
        // Primeiro Passo
        PreencherArray(numeros);

        // Chama o método 'CalcularSoma' para calcular a soma dos números no array 'numeros'.
        // Segundo Passo
        int soma = CalcularSoma(numeros);

        // Chama o método 'CalcularMedia' para calcular a média dos números no array 'numeros'.
        // Terceiro Passo
        double media = CalcularMedia(numeros);

        // Imprime no console a soma dos números armazenados no array.
        Console.WriteLine("Soma dos números: " + soma);

        // Imprime no console a média dos números armazenados no array.
        Console.WriteLine("Média dos números: " + media);
    }

    // Método estático chamado 'PreencherArray'.
    // Este método preenche o array fornecido como parâmetro com números fornecidos pelo usuário.
    // Escrevemos (int[] array) para indicar que o método recebe um array de inteiros como argumento.
    // O nome do parâmetro é 'array', mas você pode nomeá-lo como quiser.
    public static void PreencherArray(int[] array)
    {
        // Um loop 'for' que itera sobre cada posição do array.
        for (int i = 0; i < array.Length; i++)
        {
            // Solicita ao usuário que digite um número para a posição atual do array.
            Console.Write("Digite o número {0}: ", i + 1);

            // Lê a entrada do usuário como texto (string).
            string? input = Console.ReadLine();

            // Tenta converter a entrada do usuário para um número inteiro usando 'int.TryParse'.
            // Se a conversão for bem-sucedida, o número é armazenado na posição atual do array.
            if (int.TryParse(input, out int numero))
            {
                array[i] = numero;
            }
            else
            {
                // Caso a entrada seja inválida, exibe uma mensagem de erro e decrementa o índice 'i'.
                // Isso faz com que o loop repita a solicitação para a mesma posição do array.
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                i--;
            }
        }
    }

    // Método estático chamado 'CalcularSoma'.
    // Este método calcula e retorna a soma de todos os números no array fornecido como parâmetro.
    public static int CalcularSoma(int[] array)
    {
        // Declaração de uma variável inteira 'soma' inicializada com 0.
        // Essa variável será usada para armazenar a soma acumulada dos números no array.
        int soma = 0;

        // Um loop 'foreach' que itera sobre cada elemento do array.
        // Escrevemos 'int num' para indicar que 'num' é uma variável temporária que representa o valor atual do elemento.
        foreach (int num in array)
        {
            // Adiciona o valor atual do elemento à variável 'soma'.
            soma += num;
        }

        // Retorna o valor final da soma.
        return soma;
    }

    // Método estático chamado 'CalcularMedia'.
    // Este método calcula e retorna a média dos números no array fornecido como parâmetro.
    public static double CalcularMedia(int[] array)
    {
        // Chama o método 'CalcularSoma' para obter a soma dos números no array.
        int soma = CalcularSoma(array);

        // Calcula a média dividindo a soma pelo número de elementos no array.
        // A conversão para 'double' é necessária para garantir que o resultado seja um número decimal.
        return (double)soma / array.Length;
    }
}

// NOTA I: A variável 'n' define o tamanho do array, ou seja, quantos números serão armazenados.
// Neste exemplo, 'n' é 3, então o array terá 3 elementos.

// NOTA II: O array 'numeros' é inicializado com 'n' elementos. Ele será usado para armazenar os números fornecidos pelo usuário.

// NOTA III: O método 'PreencherArray' preenche o array com números fornecidos pelo usuário.
// Ele utiliza um loop 'for' para iterar sobre cada posição do array e solicitar a entrada do usuário.

// NOTA IV: O método 'CalcularSoma' calcula a soma dos números no array.
// Ele utiliza um loop 'foreach' para iterar sobre cada elemento do array e somar seus valores.

// NOTA V: O método 'CalcularMedia' calcula a média dos números no array.
// Ele chama o método 'CalcularSoma' para obter a soma dos elementos e depois divide essa soma pelo número de elementos no array.

// NOTA VI: A conversão para 'double' é necessária no cálculo da média para obter um resultado decimal preciso.

// NOTA VII: No método 'PreencherArray', utilizamos 'int.TryParse' para validar a entrada do usuário e garantir que seja um número inteiro.
// Caso a entrada seja inválida, o índice 'i' é decrementado para repetir a solicitação de entrada.