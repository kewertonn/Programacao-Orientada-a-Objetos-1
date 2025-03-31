/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 02
                                Exemplo 5
                                                                                
*******************************************************************************/

using System;
class ContaBancaria {
    public decimal saldo;
    public decimal Saldo {
        get { return saldo; } // Retorna o saldo
        private set { // Define um setter privado 
            if (value >= 0) saldo = value; 
        }
    }
    public ContaBancaria(decimal saldoInicial) {
        Saldo = saldoInicial;
    }
    public void Depositar(decimal valor) {
        if (valor > 0) {
            Saldo += valor;
        }
    }
    public void Sacar(decimal valor) {
        if (valor > 0 && valor <= Saldo) {
            Saldo -= valor;
        } else {
            Console.WriteLine("Saldo insuficiente");
        }
    }
}
class Program {
    static void Main() {
        ContaBancaria conta = new ContaBancaria(100);
        conta.Depositar(50);
        conta.Sacar(30);
        Console.WriteLine($"Saldo atual: {conta.saldo}"); // Saída: Saldo atual: 120
    }
}