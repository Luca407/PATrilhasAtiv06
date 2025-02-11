using System;

class Program
{
    static void Main()
    {
      	 int numero;
        Console.Write("Digite um número inteiro positivo: ");
        
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.Write("Entrada inválida! Tente novamente: ");
        }
        
        Console.Write("Divisores de " + numero + ": ");
        for (int i = 1; i <= numero; i++)
            if (numero % i == 0)
                Console.Write(i + " ");
        
        Console.ReadKey();
    }
}
