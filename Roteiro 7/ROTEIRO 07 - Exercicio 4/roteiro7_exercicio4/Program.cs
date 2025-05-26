using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        string opcao;

        do
        {
            Console.WriteLine("\n--- Fila de Atendimento ---");
            Console.WriteLine("1 - Adicionar cliente");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver quantidade na fila");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------\n");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string cliente = Console.ReadLine();
                    fila.Enqueue(cliente);
                    Console.WriteLine("Cliente adicionado à fila.");
                    break;
                case "2":
                    if (fila.Count > 0)
                    {
                        string atendido = fila.Dequeue();
                        Console.WriteLine($"Atendendo {atendido}");
                    }
                    else
                    {
                        Console.WriteLine("Fila vazia.");
                    }
                    break;
                case "3":
                    Console.WriteLine($"Clientes na fila: {fila.Count}");
                    break;
                case "0":
                    Console.WriteLine("Saindo da Fila.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "0");
    }
}
