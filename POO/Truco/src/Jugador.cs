namespace Truco;

public class Jugador
{
    private Mano _cartas;
    public int Id { get; set; }
    public int Puntaje { get; set; }

    public void JugarCarta(int carta)
    {
        string cartaJugada = _cartas[carta - 1].ToString();

    }
    
    public void VerMano()
    {
        for(int i = 0; i < _cartas.size(); i++)
        {
            string carta = _cartas[i].ToString();
            Console.WriteLine($"{i + 1} - {carta} \n");
        }
    }
    public Jugador(int id, int puntaje)
    {
        Id = id;
        Puntaje = puntaje;
    }
}