namespace Truco;

// Clase para representar el mazo de cartas
public class Mazo

{
    // necesito un diccionario con valores para cada carta, para poder compararlas
    public Dictionary<string, int> cardsDict = new Dictionary<string, int>()
    {
        {"1 de Espada", 14},
        {"1 de Basto", 13},
        {"7 de Espada", 12},
        {"7 de Oro", 11 },
        {"3 de Oro", 10},
        {"3 de Espada", 10},
        {"3 de Basto", 10},
        {"3 de Copa", 10},
        {"2 de Oro", 9},
        {"2 de Espada", 9},
        {"2 de Basto", 9},
        {"2 de Copa", 9},
        {"1 de Oro", 8},
        {"1 de Copa", 8},
        {"12 de Oro", 7},
        {"12 de Espada", 7},
        {"12 de Basto", 7},
        {"12 de Copa", 7},
        {"11 de Basto", 6},
        {"11 de Espada", 6},
        {"11 de Oro", 6},
        {"11 de Copa", 6},
        {"10 de Copa", 5},
        {"10 de Espada", 5},
        {"10 de Oro", 5},
        {"10 de Basto", 5},
        {"7 de Copa", 4},
        {"7 de Basto", 4},
        {"6 de Oro", 3},
        {"6 de Copa", 3},
        {"6 de Espada", 3},
        {"6 de Basto", 3},
        {"5 de Oro", 2},
        {"5 de Espada", 2},
        {"5 de Copa", 2},
        {"5 de Basto", 2},
        {"4 de Oro", 1},
        {"4 de Espada", 1},
        {"4 de Copa", 1},
        {"4 de Basto", 1},
    };

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