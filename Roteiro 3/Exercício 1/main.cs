/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 03
                                Exercicio 1
                                                                                
*******************************************************************************/

using System;

public class Animal {
    public string nome;
    public void EmitirSom(){
        Console.WriteLine($"Som genérico do animal {nome}!");
    }
}

public class Leao : Animal {
    public void Rugir(){
        Console.WriteLine("ROAR!");
    }
}

class HelloWorld {
    static void Main() {
        Leao leao1 = new Leao();
        
        leao1.nome = "Mufasa";
        leao1.EmitirSom();
        leao1.Rugir();
    }
}