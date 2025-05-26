using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com espaços no início e no fim, e com palavras separadas por vírgulas: ");
        string frase = Console.ReadLine();

        //Trim
        string semespacos = frase.Trim();
        Console.WriteLine($"\nFrase sem espaços extras: {semespacos}");

        //Split
        string[] palavras = semespacos.Split(',');
        Console.WriteLine("\nPalavras na frase:");
        foreach (var palavra in palavras)
        {
            Console.WriteLine(palavra.Trim());
        }
        
        //Replace
        Console.Write("\nDigite a palavra que deseja substituir: ");
        string antiga = Console.ReadLine();
        Console.Write("Digite a nova palavra: ");
        string nova = Console.ReadLine();
        string substituida = semespacos.Replace(antiga, nova);
        Console.WriteLine($"\nFrase substituida: {substituida}");

        
        //StartsWith
        Console.Write("\nDigite a palavra para verificar se esta no começo da frase: ");
        string inicio = Console.ReadLine();
        bool comeca = semespacos.StartsWith(inicio);
        Console.WriteLine($"A frase começa com '{inicio}'? {comeca}");

        //EndsWith
        Console.Write("\nDigite a palavra para verificar se esta no final da frase: ");
        string fim = Console.ReadLine();
        bool termina = semespacos.EndsWith(fim);
        Console.WriteLine($"A frase termina com '{fim}'? {termina}");
    }
}
