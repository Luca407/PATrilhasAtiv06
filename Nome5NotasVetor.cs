using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] nota1 = new double[5];
        double[] nota2 = new double[5];
        double[] medias = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("\nNome do aluno: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Nota 1: ");
            nota1[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            nota2[i] = Convert.ToDouble(Console.ReadLine());

            medias[i] = (nota1[i] + nota2[i]) / 2;
        }

        Console.WriteLine("\nListagem de Alunos:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nomes[i] + " - Notas: " + nota1[i] + ", " + nota2[i] + " - Média: " + medias[i]);
        }
        Console.ReadKey();
    }
}
