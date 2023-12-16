namespace Producto;

public class Producto
{
    public string Nombre;
    public decimal Precio;
    public int Codigo;
     

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}