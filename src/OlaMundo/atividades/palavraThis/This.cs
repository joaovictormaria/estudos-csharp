using System;
using System.Globalization;

namespace ThisAtv
{
    class ThisAtv
    {
        public static void Exercicios()
        {
            Console.Write("Entre com os dados do produto: ");

            Console.Write("Nome do produto: ");
            string name = Console.ReadLine() ?? "0";

            Console.Write("Valor do Produto: ");
            double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Produto produto = new Produto(name, preco);

            Console.WriteLine("");
            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine($"Nome do produto: {produto.Name ?? "0"}");
            Console.Write($"Valor do Produto: {produto.Preco.ToString("F3")}");
            Console.Write($"Valor do Produto: {produto.Quantidade}");
        }
    }
}