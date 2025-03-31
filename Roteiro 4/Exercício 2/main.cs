/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 04
                     Exercicio 2 - Classes Abstratas
                                                                                
*******************************************************************************/

using System;

abstract class Funcionario {
    public string Nome { get; set; }
    public decimal ValorHora { get; set; }
    public int HorasTrabalhadas { get; set; }
    
    public abstract decimal CalcularSalario();
}


class Gerente : Funcionario {
    public override decimal CalcularSalario() {
        return ValorHora * HorasTrabalhadas * 1.75m;
    }
}

class Programador : Funcionario {
    public override decimal CalcularSalario() {
        return ValorHora * HorasTrabalhadas * 1.2m;
    }
}

class Program {
    static void Main() {
        Funcionario funcionario1 = new Gerente { Nome = "Ana", ValorHora = 60, HorasTrabalhadas = 160 };
        Funcionario funcionario2 = new Programador { Nome = "Jorge", ValorHora = 40, HorasTrabalhadas = 160 };
        
        Console.WriteLine($"Salário do(a) Gerente {funcionario1.Nome}: R${funcionario1.CalcularSalario()}");
        Console.WriteLine($"Salário do(a) Programador {funcionario2.Nome}: R${funcionario2.CalcularSalario()}");
    }
}
