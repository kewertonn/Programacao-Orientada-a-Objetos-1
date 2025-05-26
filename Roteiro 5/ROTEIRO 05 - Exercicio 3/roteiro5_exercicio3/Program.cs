﻿using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        
        Console.Write("Digite a data e hora do compromisso (formato dd/MM/yyyy HH:mm): ");
        string dataCompromisso = Console.ReadLine();

        DateTime compromisso;
        bool sucesso = DateTime.TryParseExact(
            dataCompromisso,
            "dd/MM/yyyy HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out compromisso
        );

        if (!sucesso)
        {
            Console.WriteLine("Data e hora inválidas. Execute o programa novamente.");
            return;
        }

        DateTime agora = DateTime.Now;
        TimeSpan diferenca = compromisso.Date - agora.Date;
        int diasFaltando = diferenca.Days;

        
        string diaSemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3} às {4}",
            nome,
            diasFaltando >= 0 ? diasFaltando : 0,
            diaSemana,
            compromisso.ToString("dd/MM/yyyy"),
            compromisso.ToString("HH:mm")
        );

        Console.WriteLine("\n" + mensagem);
    }
}
