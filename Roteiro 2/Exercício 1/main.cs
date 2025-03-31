/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 02
                                Exercício 1
                                                                                
*******************************************************************************/

using System;
class Produto {
    private string nome;
    private decimal preco;
    
    public string Nome { // acessa o nome
        get { return nome; }
    }
    
    public decimal Preco { // acessa o preço e garante que não é negativo
        get { return preco; }
        set {
            if (value >= 0) {
                preco = value;
            }else {
                Console.WriteLine("Preço do produto não pode ser negativo");
            }
        }
    }
    
    public Produto(string nome, decimal preco){ // inicializa nome e preço
        this.nome = nome; // utilizando "this" pois é da mesma classe
        Preco = preco; // utilizando "Preco" para garantir valor positivo
    }
    
    
    public void ExibirDetalhes() { // Método que imprime nome e preço do produto
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}"); // ":C" exibe o preço em forma monetária
    }
    
}

class main {
    static void Main() {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes(); // Deve exibir produto corretamente
        
        p.Preco = -200; // Deve exibir mensagem de erro
        p.ExibirDetalhes();
    }
}