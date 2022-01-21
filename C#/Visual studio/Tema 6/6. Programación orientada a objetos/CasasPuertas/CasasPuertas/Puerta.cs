using System;


class Puerta
{
    private int ancho;
    private int alto;


    public int Ancho
    {
        get{return ancho;}
        set
        {   if(value > 0)
            { 
                ancho = value; 
            }
       
        }
    }
    public int Alto
    {
        get{return alto;}
        set
        {
            if(value > 0)
            { 
                alto = value;
            }
       
        }
    }
    public Puerta(int an,int al)
    {
        Ancho = an;
        Alto = al;
    }
    public void Mostrar()
    {
        Console.WriteLine("{0} x {1}", ancho,alto);
    }
}

