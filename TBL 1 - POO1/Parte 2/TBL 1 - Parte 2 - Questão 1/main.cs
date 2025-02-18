/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 2 - Questão 1
                                                                                
*******************************************************************************/

using System;
class Questao1 {
  static void Main() {
    int x = 100; // x declarada inicialmente com o valor 100
    int y = x; // y declarada recebendo x (100)
    
    y = 999; // segunda variável modificada (999)
    
    Console.WriteLine($"X (1ª Variável) = {x}");
    // saída da 1ª Variável, não alterada pois foi utilizado Tipo de Valor
    
    Console.WriteLine($"Y (2ª Variável) = {y}"); 
    // saída da 2ª Variável que foi alterada para 999
  }
}