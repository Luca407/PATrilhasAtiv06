using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 25, 7, 42, 18 };
        int maior = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];
        }

        Console.WriteLine("Maior valor: " + maior);
    }
}
