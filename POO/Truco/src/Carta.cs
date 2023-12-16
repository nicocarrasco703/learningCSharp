namespace Truco;

public class Carta
{
    public int Valor { get; set; }
    public string Palo { get; set; }

    public override string ToString()
    {
        return $"{Valor} de {Palo}";
    }
    public Carta(int valor, string palo)
    {
        Valor = valor;
        Palo = palo;
    }
}