using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> compras = new List<string>();
        string opcao = "";

        do
        {
            Console.WriteLine("\n--- Lista de Compras ---");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Listar itens");
            Console.WriteLine("4 - Mostrar quantidade total de itens");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------------------\n");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o item a adicionar: ");
                    string item = Console.ReadLine();
                    compras.Add(item);
                    Console.WriteLine("Item adicionado!");
                    break;
                case "2":
                    Console.Write("Digite o item a remover: ");
                    string remover = Console.ReadLine();
                    if (compras.Remove(remover))
                        Console.WriteLine("Item removido.");
                    else
                        Console.WriteLine("Item não encontrado.");
                    break;
                case "3":
                    Console.WriteLine("\nItens na lista:");
                    foreach (var c in compras)
                        Console.WriteLine($"- {c}");
                    break;
                case "4":
                    Console.WriteLine($"Total de itens: {compras.Count}");
                    break;
                case "0":
                    Console.WriteLine("Saindo da Lista.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != "0");
    }
}
