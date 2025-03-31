/******************************************************************************

                            Online C# Compiler.
                Kewerton Caetano - RA 123210 - Roteiro 04
                        Exercicio 1 - Polimorfismo
                                                                                
*******************************************************************************/

using System;

class Pagamento {
    public virtual void ProcessarPagamento() {
        Console.WriteLine("Processamento finalizado!");
    }
}

class CartaoCredito : Pagamento {
    public override void ProcessarPagamento() {
        Console.WriteLine("Pagamento via Cartão de Crédito finalizado!");
    }
}

class BoletoBancario : Pagamento {
    public override void ProcessarPagamento() {
        Console.WriteLine("Pagamento via Boleto Bancario finalizado!");
    }
}

class Pix : Pagamento {
    public override void ProcessarPagamento() {
        Console.WriteLine("Pagamento via Pix finalizado!");
    }
}

class Program {
    static void Main() {
        
    Pagamento pagamento1 = new CartaoCredito();
    Pagamento pagamento2 = new BoletoBancario();
    Pagamento pagamento3 = new Pix();
    
    pagamento1.ProcessarPagamento(); // Saída: Pagamento via Cartão de Crédito finalizado!
    pagamento2.ProcessarPagamento(); // Saída: Pagamento via Boleto Bancario finalizado!
    pagamento3.ProcessarPagamento(); // Saída: Pagamento via Pix finalizado!
    }
}