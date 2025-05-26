using System;

public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            VerificarIdade(idade);
            Console.WriteLine("Acesso permitido.");
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }

    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }
    }
}
