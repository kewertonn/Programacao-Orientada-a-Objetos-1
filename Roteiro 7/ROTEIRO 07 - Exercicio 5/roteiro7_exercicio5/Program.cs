using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();

        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        Console.Write("Palavra invertida: ");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop());
        }
        Console.WriteLine();
    }
}
