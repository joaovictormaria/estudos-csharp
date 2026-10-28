using System;
using System.Globalization;

namespace DadosBancario
{
    class DadoPoupanca
    {
        public static void DadosBancario()
        {
            Bancos dados;
            Console.Write("Entre com o Número da Conta: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine() ?? "0";

            Console.Write("Havrá depósito Inicial? s/n: ");
            char confirmacao = char.Parse(Console.ReadLine() ?? "0");



            if (confirmacao == 's' || confirmacao == 'S')
            {

                Console.Write("Entre um Valor para Depósito: ");
                double valor = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                dados = new Bancos(number, titular);
                dados.Deposito(valor);


            }
            else
            {
                dados = new Bancos(number, titular);
            }
            System.Console.WriteLine($"Dados da Conta: {dados}");

            System.Console.WriteLine("");

            System.Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            dados.Deposito(quantia);

            System.Console.WriteLine($"Dados da Conta Atualizados: {dados}");

            System.Console.Write("Entre um valor para sacar: ");
            quantia = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            dados.Saque(quantia);

            System.Console.WriteLine("Dados da Conta Atualizados: ");
            System.Console.WriteLine(dados);




        }
    }
}