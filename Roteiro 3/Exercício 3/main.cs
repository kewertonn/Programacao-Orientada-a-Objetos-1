/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 03
                                Exercicio 3
                                                                                
*******************************************************************************/

using System;

public interface IVeiculo {
    void Mover(); // Método sem implementação
}

public class Carro : IVeiculo { // Implementação do método Mover da interface
    public void Mover() {
        Console.WriteLine("O carro está se movendo");
    } // Implementação do método Mover da interface
}

public class Bicicleta : IVeiculo { // Implementação do método Mover da interface
    public void Mover() {
        Console.WriteLine("A bicicleta está se movendo");
    } // Implementação do método Mover da interface
}

class Program {
    static void Main() {
    
    IVeiculo veiculo1 = new Carro();
    IVeiculo veiculo2 = new Bicicleta();
    veiculo1.Mover(); // Saída: O carro está se movendo
    veiculo2.Mover(); // Saída: A bicicleta está se movendo
    }
}