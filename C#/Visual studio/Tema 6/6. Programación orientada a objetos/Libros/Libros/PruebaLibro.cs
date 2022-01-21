/* Libro l = new Libro();
l.SetAutor("Miguel de Cervantes");
l.SetTitulo("El Quijote");
l.SetUbicacion("Narrativa-3-4");
l.MostrarInformacion();

Console.WriteLine("Autor: " + l.GetAutor());
Console.WriteLine("Título: " + l.GetTitulo());
Console.WriteLine("Ubicación: " + l.GetUbicacion());

Libro l2 = new Libro("Perez Reverte", "Cabo Trafalgar", "Narrativa-1-2");
l.MostrarInformacion()
*/

Libro[] l = new Libro[3];

l[0] = new Libro("El juego de Ender", "SeeS", "Escalera 3");
l[1] = new Libro("La historia interminable", "SooS", "Escalera 5");
l[2] = new Libro("BLM", "Watermelonio", "California");

int count = 0;
for (int i = 0; i < l.Length; i++)
{
    l[i].MostrarInformacion();
    count++;
}

Libro[] l2 = new Libro[3];
string autor, titulo, ubicacion;
for (int i = 0; i < l2.Length; i++)
{
    Console.WriteLine("Autor del libro {0}:", i + 1);
    autor=Console.ReadLine();
    Console.WriteLine("Título del libro {0}:", i + 1);
    titulo = Console.ReadLine();
    Console.WriteLine("Ubicación del libro {0}:", i + 1);
    ubicacion = Console.ReadLine();

    l2[i] = new Libro(autor, titulo, ubicacion);
}

foreach(Libro l1 in l2)
{
    l1.MostrarInformacion();
}