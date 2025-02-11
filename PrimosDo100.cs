using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números primos entre 1 e 100:");
        
        for (int num = 2; num <= 100; num++)
        {
            bool primo = true;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
                Console.Write(num + " ");
        }
        
        Console.WriteLine();
        Console.ReadKey(); // Mantém a janela aberta
    }
}
