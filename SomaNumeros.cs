using System;

class Program
{
    public static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("Por favor, insira um número positivo.");
        }
        else
        {
            int soma = 0;

            // Loop para somar os números de 1 até o número inserido
            for (int i = 1; i <= numero; i++)
            {
                soma += i;
            }

            Console.WriteLine("A soma dos números de 1 até " + numero + " é: " + soma);
        }

        Console.ReadKey();
    }
}
