using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 25, 7, 42, 18 };
        Array.Sort(numeros);
        Array.Reverse(numeros);

        Console.WriteLine("Vetor ordenado em ordem decrescente:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.ReadKey();
    }
}
