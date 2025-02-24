/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 2 - Questão 4
                                                                                
*******************************************************************************/

using System;

class Questao4 {
  static void Main() {
    Console.WriteLine("Insira um dado:");
    string texto = Console.ReadLine();
    int num;
    
    bool converte = int.TryParse(texto, out num);
    
    if (converte){
        Console.WriteLine($"Conversão para 'int' bem sucedida. \nNumero convertido: {num}");
    }else{
        Console.WriteLine("Entrada inválida. Digite um número válido.");
    }
  }
}