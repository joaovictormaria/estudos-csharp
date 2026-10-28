using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        public static void Conta()
        {
            Banco dados = new Banco("Carlos", 1, 1200);
            Banco informacoes = new Banco("Eduardo", 2, 1300);

            Console.WriteLine($"Nome: {dados.Name}");
            Console.WriteLine($"Número da Conta: {dados.NumberCount}");
            Console.WriteLine($"Saldo Inicial: {dados.StartingBalance.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");
            Console.WriteLine($"Nome: {informacoes.Name}");
            Console.WriteLine($"Número da Conta: {informacoes.NumberCount}");
            Console.WriteLine($"Saldo Inicial: {informacoes.StartingBalance.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}