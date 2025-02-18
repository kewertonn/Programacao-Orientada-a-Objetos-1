/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 1 - Questão 3
                                                                                
*******************************************************************************/

using System;
class Questao3 {
  static void Main() {
    string numStr = "99"; 
    // declarada e atribuida a string numStr;
    
    int num = int.Parse(numStr); 
    // string numStr convertida explicitamente para int, na variável num;
    
    Console.WriteLine(num); // Saída = 99 (em formato int);
  }
}