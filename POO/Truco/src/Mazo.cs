namespace Truco;

public class Mazo
{
    private List<Carta> Baraja;

    public Mazo()
    {
        Baraja = new List<Carta>();
        InitMazo();
    }

    private static Random rnd = new Random();
    
    public Carta TomarCarta()
    {
        int index = rnd.Next(Baraja.Count);
        Carta carta = Baraja[index];
        Baraja.RemoveAt(index);
        return carta;
    }

    public void DevolverCarta(Carta carta)
    {
        Baraja.Add(carta);
    }
    private void InitMazo()
    {
        for (int i = 1; i < 13; i++)
        {
            if (i != 8 && i != 9) // el truco no usa ni 8s ni 9s
            {
                Baraja.Add(new Carta(i, "Oro"));
            }
        }
        for (int i = 1; i < 13; i++)
        {
            if (i != 8 && i != 9) // el truco no usa ni 8s ni 9s
            {
                Baraja.Add(new Carta(i, "Copa"));
            }
        }
        for (int i = 1; i < 13; i++)
        {
            if (i != 8 && i != 9) // el truco no usa ni 8s ni 9s
            {
                Baraja.Add(new Carta(i, "Espada"));
            }
        }
        for (int i = 1; i < 13; i++)
        {
            if (i != 8 && i != 9) // el truco no usa ni 8s ni 9s
            {
                Baraja.Add(new Carta(i, "Basto"));
            }
        }
    }
    
}