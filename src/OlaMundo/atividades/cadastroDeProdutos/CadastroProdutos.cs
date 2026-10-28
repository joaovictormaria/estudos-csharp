using System;
using System.Globalization;

namespace CadastroProdutos
{
    class FormCadastro
    {
        public static void CadastrandoProdutos()
        {
            CadastroLogica dados;

            System.Console.WriteLine("Nome do Produto: ");
            string nomeProduto = Console.ReadLine() ?? "0";

            System.Console.WriteLine("Código do Produto: ");
            int codigoProduto = int.Parse(Console.ReadLine() ?? "0");

            System.Console.WriteLine("Deseja Informar um Preco Inicial? s/n: ");
            char confirmacao = char.Parse(Console.ReadLine() ?? "0");

            if (confirmacao == 's' || confirmacao == 'S')
            {
                System.Console.WriteLine("Preco Inicial: ");
                double precoInicial = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                dados = new CadastroLogica(nomeProduto, codigoProduto, precoInicial);
            }
            else if (confirmacao == 'n' || confirmacao == 'N')
            {
                dados = new CadastroLogica(nomeProduto, codigoProduto);
                
            }
            else
            {
                System.Console.WriteLine("Caractere INVÁLIDO! Encerrando");
                return;
            }

            System.Console.WriteLine(dados);

            System.Console.WriteLine("Quer aumentar o preco do produto? s/n: ");
            char aumentarpreco = char.Parse(Console.ReadLine() ?? "0");

            if (aumentarpreco == 's' || aumentarpreco == 'S')
            {
                System.Console.WriteLine("Digite o valor a ser aumentado a mais: ");
                double acrescimoValor = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
                dados.AumentarPreco(acrescimoValor);
            }
            System.Console.WriteLine("Dados Atualizados: ");
            System.Console.WriteLine(dados);


        }
    }
}