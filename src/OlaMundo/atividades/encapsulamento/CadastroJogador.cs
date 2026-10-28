using System;
using System.Globalization;

namespace Jogadores
{
    class Jogar
    {
        public static void Jogadores()
        {
            Jogador dados = new Jogador("Carlos", 100.00);

            dados.Nome = "Josué";
            dados.Pontuacao = 50.87;

            System.Console.WriteLine($"Nome: {dados.Nome}");
            System.Console.WriteLine($"Pontuacao: {dados.Pontuacao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}