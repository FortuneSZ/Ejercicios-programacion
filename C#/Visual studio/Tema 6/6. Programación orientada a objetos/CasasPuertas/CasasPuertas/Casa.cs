using System;

class Casa
{
    private string nombre;
    private Puerta[] puertas;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public Casa()
    {
        nombre = "";
        puertas = null;
    }
    public Casa(string n, Puerta[] p)
    {
        nombre = n;
        puertas = p;
    }
    public void MostrarEstado()
    {
        Console.WriteLine(nombre);
        foreach(Puerta p in puertas)
        {
            p.Mostrar();
        }
    }
}
