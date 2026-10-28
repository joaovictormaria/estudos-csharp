using System;

namespace PersonagemRPGw
{
    class PersonagemRPGS
    {
        public static void PersonagemRPGs()
        {
            PersonagemRPG dados = new PersonagemRPG("Mago", 100.00, 5);

            dados.Nome = "";
            dados.Vida = -20;
            dados.Nivel = 0;

            System.Console.WriteLine($"Nome: {dados.Nome}");
            System.Console.WriteLine($"Vida: {dados.Vida}");
            System.Console.WriteLine($"Nível: {dados.Nivel}");

        }
    }
}