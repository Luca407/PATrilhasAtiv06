using System;

class Program
{
    struct Mercadoria
    {
        public string Nome;
        public int Quantidade;
        public decimal PrecoUnitario;
    }

    static void Main(string[] args)
    {
        Mercadoria[] mercadorias = new Mercadoria[40];
        int opcao;
        int contador = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Cadastrar mercadorias");
            Console.WriteLine("2. Exibir valor total em mercadorias da empresa");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (contador < 40)
                    {
                        Console.Write("Digite o nome da mercadoria: ");
                        mercadorias[contador].Nome = Console.ReadLine();

                        Console.Write("Digite a quantidade em estoque: ");
                        mercadorias[contador].Quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço unitário: ");
                        mercadorias[contador].PrecoUnitario = decimal.Parse(Console.ReadLine());

                        contador++;
                        Console.WriteLine("Mercadoria cadastrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Limite de mercadorias atingido.");
                    }
                    break;

                case 2:
                    decimal valorTotal = 0;
                    for (int i = 0; i < contador; i++)
                    {
                        valorTotal += mercadorias[i].Quantidade * mercadorias[i].PrecoUnitario;
                    }
                    Console.WriteLine("O valor total das mercadorias em estoque é: R$" +valorTotal);
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 3);
    }
}


