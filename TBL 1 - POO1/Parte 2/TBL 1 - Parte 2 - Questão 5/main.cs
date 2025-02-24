/******************************************************************************

                            Online C# Compiler.
                        Kewerton Caetano - RA 123210
                         TBL 1 - Parte 2 - Questão 5

*******************************************************************************/

using System;

class Questao5 {
	static void Main() {
		string s1 = "Olá!";
		string s2 = "Olá!";
		string s3 = new string("Olá!");
        
		Console.WriteLine(s1 == s2);
		Console.WriteLine(s1 == s3);
		Console.WriteLine(object.ReferenceEquals(s1, s2));
		Console.WriteLine(object.ReferenceEquals(s1, s3));
        
		/*
		-------------
		Saídas:
		True
		True
		True
		False
		-------------
		1. Explique por que s1 == s2 é true.
        
		s1 == s2 é 'true', pois ambas são strings internadas (apontam/referenciam 
		para o mesmo objeto na memória) que, consequentemente, posuem o mesmo 
		valor. Ao utilizar '==' para comparar, é realizada a comparação do valor 
		da string e não de suas referencias. (Por isso s1 == s3 também é 'true')
		-------------
		2. Explique por que object.ReferenceEquals(s1, s3) pode ser false.
        
        object.ReferenceEquals(s1, s3) pode ser 'false', pois o comandado/função
        em questão verifica se duas variáveis possuem a mesma referencia/apontamento
        na memória. Nesse caso, s3 foi criado utilizando o operador 'new', 
        ou seja, uma nova instancia de string foi alocada na memória, ocasionando
        o retorno 'false' ao realizar a comparação pela função "ReferenceEquals".
		*/
	}
}