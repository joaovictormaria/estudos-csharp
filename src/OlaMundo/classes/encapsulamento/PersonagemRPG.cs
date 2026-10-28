

class PersonagemRPG
{
    private string _nome = "";
    private double _vida;
    private int _nivel;

    public PersonagemRPG(string _nome, double _vida, int _nivel)
    {
        this._nome = _nome;
        this._vida = _vida;
        this._nivel = _nivel;
    }

    public string Nome
    {
        get { return _nome;}
        set{ if (value != "" && value != null) {_nome = value;}}
    }

    public double Vida {
        get{return _vida;}
        set{ if(value >= 0) {_vida = value;}}
    }
    
    public int Nivel
    {
        get {return _nivel;}
        set{if(value >= 1) {_nivel = value;}}
    }
}