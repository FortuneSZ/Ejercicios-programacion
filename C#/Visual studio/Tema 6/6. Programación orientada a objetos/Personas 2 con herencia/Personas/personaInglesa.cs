using System;
/*sUBTIPO DE PERSONA PARA PERSONAS INGLESAS*/
class PersonaInglesa : Persona
{
    public PersonaInglesa(string nombre)
    {
        this.Nombre = nombre;
    }
    public void TomarTe()
    {
        Console.WriteLine("Estoy tomando té");
    }
    public new void Saludar()
    {
        Console.WriteLine("Hi, I am " + nombre);
    }
}

