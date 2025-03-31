/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 03
                            Exemplo Composição
                                                                                
*******************************************************************************/

using System;

public class Motor {
    public int Potencia { 
        get; 
        set; 
    }
    
    public void Ligar() {
        Console.WriteLine("Motor ligado!");
    }
}

public class Carro { // Composição: Um carro "tem um" motor
    private Motor motor;
    
    public Carro() {
        motor = new Motor(); // Criando um motor dentro do carro
    }
    
    public void LigarCarro() {
        Console.WriteLine("Carro ligado!");
        motor.Ligar();
    }
}

class Program {
    static void Main() {
        Carro carro = new Carro();
        carro.LigarCarro();
    }
}