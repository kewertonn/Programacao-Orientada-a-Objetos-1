/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 01
                                Exercicio 1
                                                                                
*******************************************************************************/

using System;
public class Pessoa {
    public string Nome;
    public int Idade;
    public string Cargo; 
    
    public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
    
    
    public void Salario(){
        if (Cargo == "Gerente"){
            Console.WriteLine($"Eu sou {Cargo} e meu salario é de R$ 10.000,00.\n");
        }else if(Cargo == "Desenvolvedor"){
            Console.WriteLine($"Eu sou {Cargo} e meu salario é de R$ 5.000,00.\n");
        } else{
            Console.WriteLine($"Eu sou {Cargo} e meu salario é de R$ 100,00.\n");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 30;
        p1.Nome = "Joao";
        p1.Cargo = "Gerente";
        p1.Apresentar();
        p1.Salario();
        
        Pessoa p2 = new Pessoa();
        p2.Idade = 25;
        p2.Nome = "Jorge";
        p2.Cargo = "Desenvolvedor";
        p2.Apresentar();
        p2.Salario();
        
        Pessoa p3 = new Pessoa();
        p3.Idade = 24;
        p3.Nome = "Ana Paula";
        p3.Cargo = "Desenvolvedor";
        p3.Apresentar();
        p3.Salario();
        
        Pessoa p4 = new Pessoa();
        p4.Idade = 19;
        p4.Nome = "Mario";
        p4.Cargo = "Estagiario";
        p4.Apresentar();
        p4.Salario();
        
    }
}