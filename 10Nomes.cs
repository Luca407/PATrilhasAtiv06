using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um nome: ");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("\nLista de nomes:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(nomes[i]);
        }

        Console.ReadKey();
    }
}
