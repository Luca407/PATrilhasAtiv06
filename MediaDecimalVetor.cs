using System;

class Program
{
    static void Main()
    {
        double[] numeros = { 5.5, 7.2, 8.3, 6.4, 9.1 };
        double soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        double media = soma / numeros.Length;
        Console.WriteLine("Média dos valores: " + media);
        Console.ReadKey();
    }
}
