using System.Globalization;

class CadastroLogica
{
    public string NameProduto { get; set; } = "";
    public int CodigoProduto { get; private set; }
    public double PrecoProduto { get; private set; }


    public CadastroLogica(string NameProduto, int CodigoProduto)
    {
        this.NameProduto = NameProduto;
        this.CodigoProduto = CodigoProduto;
    }

    public CadastroLogica(string NameProduto, int CodigoProduto, double precoProduto) : this(NameProduto, CodigoProduto)
    {
        this.PrecoProduto = precoProduto;
    }


    public void AumentarPreco(double aumentar_preco)
    {
        PrecoProduto += aumentar_preco;
    }

    public override string ToString()
    {
        return $"Nome do Produto: {NameProduto}\nCódigo do Produto: {CodigoProduto}\nPreco do Produto: {PrecoProduto.ToString("F2", CultureInfo.InvariantCulture)}";

    }

}