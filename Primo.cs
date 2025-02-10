using System;

class Program
{
    public static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int divisores = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            Console.WriteLine(numero + " é um número primo.");
        }
        else
        {
            Console.WriteLine(numero + " não é um número primo.");
        }

        Console.ReadKey();
    }
}
