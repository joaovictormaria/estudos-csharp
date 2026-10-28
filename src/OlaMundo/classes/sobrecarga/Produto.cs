class Produto
{
    public string Name;
    public double Preco;
    public int Quantidade;

    public Produto(string name, double preco, int quantidade)
    {
        Name = name;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string name, double preco)
    {
        Name = name;
        Preco = preco;
        Quantidade = 0;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
}