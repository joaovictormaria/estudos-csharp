using System.Globalization;
class Bancos
{
    public int NumeroConta { get; private set; }
    public string TitularConta { get; set; } = "";
    public double Saldo { get; private set; }

    public Bancos(int numero, string titular)
    {
        NumeroConta = numero;
        TitularConta = titular;
    }
    public Bancos(int numero, string titular, double depositonicial) : this(numero, titular)
    {
        Deposito(depositonicial);
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }
    public void Saque(double sacar)
    {
        Saldo -= sacar;
    }

    public override string ToString()
    {
        return $"Conta: {NumeroConta}\nTitular: {TitularConta}\nSaldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}