using System;

class Program
{
    static void Main()
    {
        // Criando um vetor de inteiros com alguns valores
        int[] vetor = { 10, 20, 30, 40, 50 };

        // Percorrendo o vetor e imprimindo o valor de cada elemento
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Elemento na posição " + i + ": " + vetor[i]);
        }
        Console.ReadKey();

    }
}
