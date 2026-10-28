using System;
using System.Globalization;

namespace Business
{
    class DataEmployee
    {
        public static void Data()
        {
            Employee dadosAna = new Employee("Ana", 2500);
            Employee dadosCarlos = new Employee("Carlos", 3200, 40);

            Console.WriteLine($"Nome: {dadosAna.Name} - Salário: {dadosAna.Wage.ToString("F2", CultureInfo.InvariantCulture)} - Horas Trabalhadas: {dadosAna.HourWorked}");
            Console.WriteLine($"Nome: {dadosCarlos.Name} - Salário: {dadosCarlos.Wage.ToString("F2", CultureInfo.InvariantCulture)} - Horas Trabalhadas: {dadosCarlos.HourWorked}");

        }
    }
}