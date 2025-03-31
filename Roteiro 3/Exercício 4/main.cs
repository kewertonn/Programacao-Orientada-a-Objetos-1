/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 03
                                Exercicio 4
                                                                                
*******************************************************************************/

using System;

public interface IVoar {
    void Voar();
}

public interface INadar {
    void Nadar();
}

public class Pato : IVoar, INadar {
    public void Voar() {
        Console.WriteLine("Pato está voando");
    }
    public void Nadar() {
        Console.WriteLine("Pato está nadando");
    }
}

public class Aguia : IVoar {
    public void Voar() {
        Console.WriteLine("Aguia está voando");
    }
}

public class Peixe : INadar {
    public void Nadar() {
        Console.WriteLine("Peixe está nadando");
    }
}

class Program {
    static void Main() {
    
   /* IVoar animal1 = new Pato();
    INadar animal2 = new Pato();
    IVoar animal3 = new Aguia();
    INadar animal4 = new Peixe();
    
    animal1.Voar(); // Saída: Pato está voando
    animal2.Nadar(); // Saída: Pato está nadando
    animal3.Voar(); // Saída: Aguia está voando
    animal4.Nadar(); // Saída: Peixe está nadando */
    
    Pato pato = new Pato();
    Aguia aguia = new Aguia();
    Peixe peixe = new Peixe();

    pato.Voar();  // Saída: Pato está voando
    pato.Nadar(); // Saída: Pato está nadando
    
    aguia.Voar(); // Saída: Aguia está voando
    
    peixe.Nadar(); // Saída: Peixe está nadando
    }
}