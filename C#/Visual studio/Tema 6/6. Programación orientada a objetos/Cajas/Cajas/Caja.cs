using System;


class Caja
{
    private int capacidad;

    public int Capacidad
    {
        get {
            return capacidad; 
        }
        set {
            if(value > 0 && value <= 250)
                capacidad = value;
        }
    }

    public Caja()
    {
        capacidad = 0;
    } 
    public Caja(int c)
    {
        Capacidad = c;
    }


    public void Mostrar()
    {
        Console.WriteLine("Esta caja tiene {0} L",capacidad);
    }
}
