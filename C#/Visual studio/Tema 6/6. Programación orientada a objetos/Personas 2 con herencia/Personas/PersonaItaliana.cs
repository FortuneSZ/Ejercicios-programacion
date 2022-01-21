using System;

class PersonaItaliana : Persona
{
    public PersonaItaliana(string nombre)
    {
        this.Nombre = nombre;
    }
    public new void Saludar()
    {
        Console.WriteLine("Ciao");
    }
}