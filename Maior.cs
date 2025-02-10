using System;

class Program
{
    public static void Main()
    {
        Console.Write("Quantos números você deseja inserir? ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        int maiorNumero = int.MinValue; // Inicializa com o menor valor possível de um inteiro

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número atual é maior que o maior número encontrado até agora
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Console.WriteLine("O maior número inserido foi: " + maiorNumero);
        Console.ReadKey();
    }
}
