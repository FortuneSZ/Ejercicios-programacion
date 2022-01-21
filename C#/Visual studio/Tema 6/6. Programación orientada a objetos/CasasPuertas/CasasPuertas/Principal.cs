Casa c;
Puerta[] p = new Puerta[3];
string nombre;
int ancho, alto;

for (int i = 0; i < p.Length; i++)
{
    Console.WriteLine("Ancho de la puerta");
    ancho = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Alto de la puerta");
    alto = Convert.ToInt32(Console.ReadLine());

    p[i] = new Puerta(ancho, alto);
}

Console.WriteLine("Nombre de la casa:");
nombre = Console.ReadLine();

c = new Casa(nombre, p);
c.MostrarEstado();