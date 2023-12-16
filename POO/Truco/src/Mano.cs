namespace Truco;

public class Mano
{
    private Carta[] _cartas = new Carta[3];

    public Mano()
    {
        _cartas[0] = null;
        _cartas[1] = null;
        _cartas[2] = null;
    }

    public void ReponerMano(Carta carta1, Carta carta2, Carta carta3)
    {
        _cartas[0] = carta1;
        _cartas[1] = carta2;
        _cartas[2] = carta3;
    }   

    // operador para acceder a las cartas de la mano
    public Carta this[int index]
    {
        get
        {
            return _cartas[index];
        }
        set
        {
            _cartas[index] = value;
        }
    }

    public int size()
    {
        int size = 0;
        foreach (Carta carta in _cartas)
        {
            if (carta != null)
            {
                size++;
            }
        }
        return size;
    }
}