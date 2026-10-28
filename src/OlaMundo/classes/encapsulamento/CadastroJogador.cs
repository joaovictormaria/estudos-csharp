class Jogador
{
    private string _nome = "";
    private double _pontuacao;

    public Jogador(string _nome, double _pontuacao)
    {
        this._nome = _nome;
        this._pontuacao = _pontuacao;
    }

    public string Nome
    {
        get
        {return _nome;}
        set
        {
            if (value != "" && value != null)
            {
                _nome = value;
            }
        }
    }

    public double Pontuacao
    {
        get
        {return _pontuacao;}
        set
        {
            if (value >= 0)
            {
                _pontuacao = value;
            }
        }
    }
}