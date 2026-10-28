namespace Livros
{
    class Biblioteca
    {
        public static void Livros()
        {
            Livro dados = new Livro("C# para Iniciantes", 59.90);

            System.Console.WriteLine($"Dados: {dados.Titulo}");
            System.Console.WriteLine($"Dados: {dados.Preco}");
        }
    }
}