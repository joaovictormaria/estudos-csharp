 using System;
using System.Globalization;


namespace Funcionario
{
    class Funcionario
    {
        public static void Exercicio()
        {
           Dados funcionario = new Dados("Carlos", 2500, 28);

           Console.WriteLine($"Nome: {funcionario.Name}");
           Console.WriteLine($"Salário: {funcionario.Wage.ToString("F2", CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Idade: {funcionario.Age}");
        }
    }
}