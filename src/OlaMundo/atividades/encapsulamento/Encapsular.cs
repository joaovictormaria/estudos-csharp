using System;
using System.Globalization;

namespace Encapsulando
{
    class Encapsulando
    {
        public static void Exercicios()
        {
            Encapsulamento dados = new Encapsulamento("Tv", 2000, 40);

            
            dados.SetName("TV 4K");
            System.Console.WriteLine(dados.GetName());
        }
    }
}