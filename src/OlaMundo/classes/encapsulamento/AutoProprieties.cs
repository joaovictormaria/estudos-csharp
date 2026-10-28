class Livro
{
    public string Titulo {get; set;} = "";
    public double Preco {get; private set;}
    /* atalho: digitar prop*/

    public Livro (string Titulo, double Preco)
    {
        this.Titulo = Titulo;
        this.Preco = Preco;
    }
}