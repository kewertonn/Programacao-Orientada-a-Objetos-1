using System;

class Program
{
    static void Main()
    {
        float temperatura = LerTemperatura();
        Console.WriteLine($"Temperatura digitada: {temperatura} ºC");
    }

    static float LerTemperatura()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine();
                return float.Parse(entrada);
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido! Por favor, digite um número válido.");
            }
        }
    }
}
