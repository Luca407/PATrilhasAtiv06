using System;

class Program
{
    public static void Main()
    {
       Console.Write("Digite um número inteiro: ");
       int x = Convert.ToInt32(Console.ReadLine());
       
        for (int i = 1; i <= 10; i++)
        {
            
			Console.WriteLine(x + " x " + i + " = " + (x * i));
            
        }
				
        Console.ReadKey();
    }
}
