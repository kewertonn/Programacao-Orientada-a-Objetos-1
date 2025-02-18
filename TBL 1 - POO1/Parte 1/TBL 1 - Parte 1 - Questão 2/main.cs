/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 1 - Questão 2
                                                                                
*******************************************************************************/

using System;
class Questao2 {
  static void Main() {
    /*Será necessário utilizar a conversão explicita para int, visto que não é 
    possível realizar uma conversão direta devido a diferença entre os tipos 
    string 'obj' (Tipo de Referência) e int 'x' (Tipo de Valor).*/
    
    object obj = "123";
    int x = int.Parse ((string)obj);
    
    Console.WriteLine($"Objeto = {obj}");  
    Console.WriteLine($"X = {x}"); 
  }
}