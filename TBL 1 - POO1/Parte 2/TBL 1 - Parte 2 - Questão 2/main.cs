/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 2 - Questão 2
                                                                                
*******************************************************************************/

using System;

public class Pessoa {
    public string Nome;
}

class Questao2 {
  static void Main() {
    Pessoa p1 = new Pessoa();
    p1.Nome = "Kewerton";
    
    Pessoa p2 = p1;
    
    p2.Nome = "Caetano";
    
    Console.WriteLine($"Nome do primeiro objeto: {p1.Nome}");
    
  }
}