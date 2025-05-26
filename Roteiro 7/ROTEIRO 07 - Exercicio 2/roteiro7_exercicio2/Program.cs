using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();
        string opcao;

        do
        {
            Console.WriteLine("\n--- Catálogo de Produtos ---");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Buscar produto por código");
            Console.WriteLine("3 - Listar todos os produtos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------------\n");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    if (produtos.ContainsKey(codigo))
                    {
                        Console.WriteLine("Código já existe.");
                    }
                    else
                    {
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        produtos.Add(codigo, nome);
                        Console.WriteLine("Produto adicionado.");
                    }
                    break;
                case "2":
                    Console.Write("Digite o código para busca: ");
                    codigo = int.Parse(Console.ReadLine());
                    if (produtos.TryGetValue(codigo, out string nomeProduto))
                    {
                        Console.WriteLine($"Produto: {nomeProduto}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;
                case "3":
                    Console.WriteLine("\nProdutos cadastrados:");
                    foreach (var p in produtos)
                        Console.WriteLine($"- Código: {p.Key}, Nome: {p.Value}");
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
