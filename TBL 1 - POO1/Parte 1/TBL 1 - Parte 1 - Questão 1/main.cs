/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 1 - Questão 1
                                                                                
*******************************************************************************/

/*
Tipos primitivos (ou tipos de valor) armazenam o valor diretamente, ou seja, as 
variáveis contém o dado armazenado e quando copiadas o valor que é passado. 
Exemplos: int, double, char, boolean.

Já os tipos de referência são tipos que armazenam a referência (endereço) para o 
objeto na memória , que são armazenados na heap,ou seja, quando se copia uma 
variável de referência, o que é copiado é o endereço armazenado e não o valor em
si, podendo compartilhar o endereço de memória com outras variáveis. 
Exemplos: String, Array, Classes. 
*/

using System;
class Questao1 {
  static void Main() {
    // Tipo de Referência
    String nome1 = "Jorge";
    String nome2 = nome1;

    nome1 = "Pedro";  
    Console.WriteLine($"Nome 1 = {nome1}");  // Saída - Nome 1: Pedro
    Console.WriteLine($"Nome 2 = {nome2}\n");  // Saída - Nome 2: Jorge
    
    // Tipo Primitivo (de Valor)
    int preco1 = 150;
    int preco2 = preco1;

    preco1 = 500; 
    Console.WriteLine($"Preço 1 = {preco1}");  // Saída - Preço 1: 500
    Console.WriteLine($"Preço 2 = {preco2}");  // Saída - Preço 2: 150
  }
}