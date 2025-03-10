// Exercício 8: Trabalhando com arrays e métodos

class Ex08
{
    public static void Run()
    {
        int n = 3;
        int[] numeros = new int[n];

        PreencherArray(numeros);

        int soma = CalcularSoma(numeros);

        double media = CalcularMedia(numeros);

        Console.WriteLine("Soma dos números: " + soma);
        Console.WriteLine("Média dos números: " + media);
    }

    public static void PreencherArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int numero))
            {
                array[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                i--;
            }
        }
    }

    public static int CalcularSoma(int[] array)
    {
        int soma = 0;
        foreach (int num in array)
        {
            soma += num;
        }
        return soma;
    }

    public static double CalcularMedia(int[] array)
    {
        int soma = CalcularSoma(array);
        return (double)soma / array.Length;
    }
}

// NOTA I: A variável 'n' é inicializada com o valor 5. Ela define quantos números serão armazenados no array.

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