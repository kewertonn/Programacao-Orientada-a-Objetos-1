/**************************************************
                 14/04/2025
    Kewerton Caetano - RA 123210 - Roteiro 06
                Exercicio 1 
**************************************************/

using System;

class Program {
static void Main() {
    
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();
    if(nome == ""){
        throw new ArgumentException("Erro: Nome do produto NÃO pode ficar EM BRANCO!");
    }

    Console.Write("Digite o preço do produto: ");
    int preco = int.Parse(Console.ReadLine());
    if(preco <= 0){
        throw new ArgumentException("Erro: O valor do produto deve ser maior que ZERO!");
    }
    
    Console.WriteLine($"Nome: {nome}\n");
    Console.WriteLine($"Preço: {preco}");
}
}