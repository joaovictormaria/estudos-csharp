class Sintaxee
{
    public string Name;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public Sintaxee(string name, double preco, int quantidade)
    {
        Name = name;
        Preco = preco;
        Quantidade = quantidade;
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