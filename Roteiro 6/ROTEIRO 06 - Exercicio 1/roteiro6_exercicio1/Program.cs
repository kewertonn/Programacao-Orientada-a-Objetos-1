using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do produto não pode estar em branco.");
            }

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            if (preco <= 0)
            {
                throw new ArgumentException("O preço não pode ser igual ou menor que zero.");
            }

            Console.WriteLine($"Produto cadastrado: {nome} - R$ {preco:F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: O preço deve ser um número válido.");
        }
        finally
        {
            Console.WriteLine("Processo finalizado.");
        }
    }
}
