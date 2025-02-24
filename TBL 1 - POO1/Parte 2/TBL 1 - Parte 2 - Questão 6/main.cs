/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 2 - Questão 6

*******************************************************************************/

using System;

class Questao6 {
    static void Main() {
        int[] numeros1 = {1, 2, 3};
        int[] numeros2 = numeros1;
        
        numeros2[0] = 100;
        Console.WriteLine(numeros1[0]);
        
        
		/*
		-------------
		Saída:
		100
		-------------
		1. Explique por que numeros1[0] foi alterado.
        
        As variáveis "numeros1" e "numeros2" são arrays e ao realizar o procedimento 
        "numeros2 = numeros1" ambas passam a ser referências do mesmo array, dessa 
        forma, ao alterar algum valor no array "numeros2" o mesmo valor é alterado 
        em "numeros1".
		-------------
		2. Como evitar que numeros1 seja modificado ao alterar numeros2?
        
        Pode ser evitado criando uma cópia do array "numeros1" em "numeros2" ao 
        invés de referenciar/apontar (Utilizando "Array.Copy()" ou "ToArray()"),
        dessa forma será possível realizar a alteração de "numeros2" sem que 
        "numeros1" seja modificado. 
		*/
	}
}