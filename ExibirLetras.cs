using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Digite uma palavra: ");
    string palavra = Console.ReadLine();
    Console.WriteLine("\nLetras da Palavra");

    foreach(char letra in palavra)
    {
      Console.WriteLine (letra + " ");
      
    }
    Console.ReadKey();
  }
}
