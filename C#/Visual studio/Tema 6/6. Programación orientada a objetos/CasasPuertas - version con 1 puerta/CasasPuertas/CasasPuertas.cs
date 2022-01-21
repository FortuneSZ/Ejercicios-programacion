Casa c;
Puerta p;
string nombre;
int ancho, alto;

Console.WriteLine("Ancho de la puerta: ");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Alto de la puerta: ");
alto = Convert.ToInt32(Console.ReadLine());

p = new Puerta(ancho, alto);

Console.WriteLine("Nombre de la casa:");
nombre = Console.ReadLine();
c = new Casa(nombre, p);

c.MostrarEstado();