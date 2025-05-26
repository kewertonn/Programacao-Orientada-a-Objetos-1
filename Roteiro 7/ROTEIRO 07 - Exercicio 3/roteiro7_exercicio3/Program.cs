using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numeros = new HashSet<int>();
        int numero;

        Console.WriteLine("--- Digite números inteiros (0 para parar) ---");

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                if (numeros.Add(numero))
                    Console.WriteLine("Número adicionado.\n");
                else
                    Console.WriteLine("Número duplicado. (Ignorado)\n");
            }

        } while (numero != 0);

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (var n in numeros)
            Console.WriteLine($"- {n}");
    }
}
