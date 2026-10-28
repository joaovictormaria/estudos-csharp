class This
{
    public string Name = "";
    public double Preco;
    public int Quantidade;

    public This()
    {
        Quantidade = 0;
    }

    public This(string name, double preco) : this()
    {
        Name = name;
        Preco = preco;
    }  

    public This(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }


    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarThiss(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverThiss(int quantidade)
    {
        Quantidade -= quantidade;
    }
}