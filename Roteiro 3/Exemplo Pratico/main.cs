/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 03
                            Exemplo Prático
                                                                                
*******************************************************************************/

using System;

public class Pessoa {
    public string nome;
    public string rg;
}

public class Vendedor : Pessoa {
    public double comissao;
}

public class Cliente : Pessoa {
    public string compra;
}

class HelloWorld {
    static void Main() {
        Vendedor vendedor = new Vendedor(); // Corrigido
        vendedor.nome = "Maria";
        vendedor.comissao = 1.1;
        Pessoa pessoa = new Pessoa(); // Corrigido
        pessoa.nome = "Joao";
        Console.WriteLine(pessoa.nome);
        Console.WriteLine(vendedor.nome);
        Console.WriteLine(vendedor.comissao);
    }
}