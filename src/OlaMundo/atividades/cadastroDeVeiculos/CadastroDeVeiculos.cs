using System;

namespace Atvv
{
    class CadastroVeiculo
    {
        public static void Cadastro()
        {
            CadastroVeiculos dadosCar = new CadastroVeiculos("Toyota", "Corolla", 2022);
            CadastroVeiculos dadosCar1 = new CadastroVeiculos("Chevrolet", "Onix", 2023);
            CadastroVeiculos dadosCar2 = new CadastroVeiculos("Volkswagen", "Gol", 2021);

            Console.WriteLine($"Marca: {dadosCar.Marca}");
            Console.WriteLine($"Modelo: {dadosCar.Modelo}");
            Console.WriteLine($"Ano: {dadosCar.AnoFabricacao}");
            Console.WriteLine("");
            Console.WriteLine($"Marca: {dadosCar1.Marca}");
            Console.WriteLine($"Modelo: {dadosCar1.Modelo}");
            Console.WriteLine($"Ano: {dadosCar1.AnoFabricacao}");
            Console.WriteLine("");
            Console.WriteLine($"Marca: {dadosCar2.Marca}");
            Console.WriteLine($"Modelo: {dadosCar2.Modelo}");
            Console.WriteLine($"Ano: {dadosCar2.AnoFabricacao}");
        }
    }
}