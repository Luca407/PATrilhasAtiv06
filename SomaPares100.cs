using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 2; i <= 100; i += 2) // Começa em 2 e vai de 2 em 2
        {
        	Console.Write(i + " ");
            soma += i;
        }
        Console.WriteLine();
        Console.WriteLine("\nA soma dos números pares entre 1 e 100 é: " + soma);
        Console.ReadKey();
    }
}
