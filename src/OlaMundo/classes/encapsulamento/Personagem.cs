
class Persona
{
    private string _nome = "";
    private int _vida;



    public Persona(string nome, int vida)
    {
        _nome = nome;
        _vida = vida;
    }

    public string Nome
    {
        get { return _nome; }

        set { if (value != null && value != "") { _nome = value; } }
    }

    public int Vida
    {
        get { return _vida; }
        set
        {
            if (value >= 0) { _vida = value; }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("//////////// A Vida nao pode ser menor que zero!/////////////");
            }
        }
    }
}