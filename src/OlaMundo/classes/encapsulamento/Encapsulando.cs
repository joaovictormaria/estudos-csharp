using System.Runtime.InteropServices;

class Encapsulamento
{
    private string _name = "";
    private double _preco;
    private int _quantidade;

    public Encapsulamento(string name, double preco, int quantidade)
    {
        _name = name;
        _preco = preco;
        _quantidade = quantidade;
    }

    public Encapsulamento(string name, double preco)
    {
        _name = name;
        _preco = preco;
        _quantidade = 0;
    }




    public void SetName(string name)
    {
        if (name != null && name.Length > 1)
        {
            _name = name;
        }
    }

    

    public string GetName()
    {
        return _name;
    }
    public double GetPreco()
    {
        return _preco;
    }
    public int GetQuantidade()
    {
        return _quantidade;
    }






    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdicionarEncapsulamentos(int quantidade)
    {
        _quantidade += quantidade;
    }

    public void RemoverEncapsulamentos(int quantidade)
    {
        _quantidade -= quantidade;
    }
}