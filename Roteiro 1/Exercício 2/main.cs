/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 01
                                Exercicio 2
                                                                                
*******************************************************************************/
using System;
public class Fantasminha {
    public string Nick;
    public string Habilidade;
    public string Cor;
    
    public void GerarFantasma(){
        Console.WriteLine($"Fantasma {Nick}, Poder {Habilidade} e Cor {Cor}.");
    }
    
    public void Mover(string Direcao){
        Console.WriteLine($"O fantasma {Nick} se moveu para {Direcao}.\n");
    }
    
}

public class Program
{
    public static void Main()
    {
        Fantasminha f1 = new Fantasminha();
        f1.Nick = "Bargon";
        f1.Habilidade = "Venenoso";
        f1.Cor = "Roxo";
        f1.GerarFantasma();
        f1.Mover("Esquerda");
        
        Fantasminha f2 = new Fantasminha();
        f2.Nick = "Taggan";
        f2.Habilidade = "Fogo";
        f2.Cor = "Vermelho";
        f2.GerarFantasma();
        f2.Mover("Cima");
        
        Fantasminha f3 = new Fantasminha();
        f3.Nick = "Xogthuth";
        f3.Habilidade = "Invisibilidade";
        f3.Cor = "Azul";
        f3.GerarFantasma();
        f3.Mover("Direita");
        
        Fantasminha f4 = new Fantasminha();
        f4.Nick = "Tangroruth";
        f4.Habilidade = "Radioativo";
        f4.Cor = "Verde";
        f4.GerarFantasma();
        f4.Mover("Baixo");
        
    }
}