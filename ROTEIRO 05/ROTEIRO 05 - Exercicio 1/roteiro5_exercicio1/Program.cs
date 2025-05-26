using System;
class Program
{
    static void Main()
    {
        decimal[] numeros = new decimal[5];

        Console.WriteLine("Digite 5 números decimais:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º Número Decimal: ");
            numeros[i] = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"Número original: {numeros[i]}");
            Console.WriteLine($"Arredondamento padrão (Math.Round): {Math.Round(numeros[i])}");
            Console.WriteLine($"Arredondamento para baixo (Math.Floor): {Math.Floor(numeros[i])}");
            Console.WriteLine($"Arredondamento para cima (Math.Ceiling): {Math.Ceiling(numeros[i])}");
            Console.WriteLine($"Truncamento (Math.Truncate): {Math.Truncate(numeros[i])} \n");
        }

    }
}
