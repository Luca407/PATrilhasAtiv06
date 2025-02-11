using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = { 1, 2, 3, 4, 5 };
        int[] vetor2 = { 6, 7, 8, 9, 10 };
        int[] soma = new int[5];

        for (int i = 0; i < 5; i++)
        {
            soma[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("Vetor soma:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(soma[i] + " ");
        }
        Console.ReadKey();
    }
}
