using System;
using System.Globalization;

namespace Producao
{
    class InicioProductos
    {
        public static void Inicio()
        {
            Product produtos = new Product("Teclado", 150.00);
            Product produtos1 = new Product("Mouse", 80.00, 5);

            Console.WriteLine($"Nome: {produtos.Name} - Preco: {produtos.Preco.ToString("F2", CultureInfo.InvariantCulture)} - Quantidade: {produtos.Quantidade}");
            Console.WriteLine($"Nome: {produtos1.Name} - Preco: {produtos1.Preco.ToString("F2", CultureInfo.InvariantCulture)} - Quantidade: {produtos1.Quantidade}");

        }
    }
}