using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        if (x < 0)
        {
            Console.WriteLine("Número Inválido");
        }
        else
        {
            for (int i = x; i >= 0; i -= 2)
            {
            	Console.Write(i + " ");
            }
        }
        
        Console.ReadKey();
    }
}
