using System;
class Casa
{
    private string nombre;
    private Puerta puerta;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public Casa()
    {
        nombre = "";
        puerta = null;
    }

    public Casa(string n,Puerta p)
    {
        nombre = n;
        puerta = p;
    }
    public void MostrarEstado()
    {
        Console.WriteLine(nombre);
        puerta.Mostrar();
    }

}
