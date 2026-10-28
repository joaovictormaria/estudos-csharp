using System;
using System.Globalization;

namespace Course
{
    class Course
    {
        public static void Exercicio()
        {
            Console.Write("Entre com os dados do produto: ");

            Console.Write("Nome do produto: ");
            string name = Console.ReadLine() ?? "0";

            Console.Write("Valor do Produto: ");
            double preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine() ?? "0");

            Produtos produto = new Produtos(name, preco, quantidade);

            Console.WriteLine($"Nome do produto: {produto.Name}");
            Console.Write($"Valor do Produto: {produto.Preco.ToString("F3")}");
            Console.Write($"Valor do Produto: {produto.Quantidade}");
        }
    }
}