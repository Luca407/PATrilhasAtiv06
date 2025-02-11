using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 25, 7, 42, 18 };
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine("Menor valor: " + menor);
      Console.ReadKey();
    }
}
