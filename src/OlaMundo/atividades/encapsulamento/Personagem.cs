using System;

namespace Personando
{
    class Nome
    {
        public static void Dado()
        {
            Persona dados = new Persona("Cavalheiro", 100);

            dados.Vida = -10;
            dados.Nome = "";
            System.Console.WriteLine($"Nome: {dados.Nome}");
            System.Console.WriteLine($"Vida: {dados.Vida}");
            





        }
    }
}