/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 02
                                Exemplo 4
                                                                                
*******************************************************************************/

using System;
class ContaBancaria {
	public decimal saldo; // Atributo privado
	public ContaBancaria(decimal saldoInicial) {
		saldo = saldoInicial;
	}
	public void Depositar(decimal valor) {
		if (valor > 0) {
			saldo += valor;
		} else {
			Console.WriteLine("Depósito inválido");
		}
	}
	public void Sacar(decimal valor) {
		if (valor > 0 && valor <= saldo) {
			saldo -= valor;
		} else {
		    Console.WriteLine("Saldo insuficiente");
		}
	}
	public decimal GetSaldo() {
		return saldo; // Retorna o saldo sem expor o atributo diretamente
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