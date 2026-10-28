class Product
{
    public string Name = "";
    public double Preco;
    public int Quantidade;

    public Product()
    {
        Quantidade = 0;
    }
    public Product(string nome, double preco) : this()
    {
        Name = nome;
        Preco = preco;
    }
    public Product(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
}