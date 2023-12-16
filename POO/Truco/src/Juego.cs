namespace Truco;

public class Juego
{
    public List<Jugador> Jugadores;
    public int PuntajeMax;
    public int Turno { get; set; }
    private Mazo _mazo { get; set; }

    public void Jugada(Jugador jugador, Carta carta)
    {

    }
    
    public void RepartirCartas()
    {
        
    }

    public Juego(int puntajeMaximo)
    {
        var jugador1 = new Jugador(1, 0);
        var jugador2 = new Jugador(2, 0);
        Jugadores = new List<Jugador>();
        Jugadores.Add(jugador1);
        Jugadores.Add(jugador2);
        PuntajeMax = puntajeMaximo;
        _mazo = new Mazo();

    }

}
