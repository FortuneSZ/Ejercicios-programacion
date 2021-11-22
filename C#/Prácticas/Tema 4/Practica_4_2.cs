/*Este programa es un menú que permite añadir alumnos a la base de datos,
eliminarlos,ver todos los alumnos,ver solo los que hayan aprobado o
buscar aquellos que tengan un nombre concreto*/
using System;

class Practica_4_2
{
	enum menu{SALIR, NUEVO, BORRAR, VER, APROBADOS, PORNOMBRE}
	struct calificacion
	{
		public float notasteoria;
		public float notaspractica;
	}
	struct alumno
	{
		public string nombre;
		public string email;
		public calificacion calificaciones;
	}	
	static void Main()
	{
		string eleccionborrar,nombrebuscar;
		int option,numalum=0,seleccion;
		alumno [] alumnos = new alumno[50];
		
		do
		{
			Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
			Console.WriteLine("^ base de datos de alumnos");
			Console.WriteLine(("* ")+(int)menu.NUEVO + ". NUEVO ALUMNO");
			Console.WriteLine(("^ ")+(int)menu.BORRAR + ". BORRAR ALUMNO");
			Console.WriteLine(("* ")+(int)menu.VER + ". VER ALUMNOS");
			Console.WriteLine(("^ ")+(int)menu.APROBADOS +
			". ALUMNOS APROBADOS");
			Console.WriteLine(("* ")+(int)menu.PORNOMBRE +
			". ALUMNOS POR NOMBRE");
			Console.WriteLine(("^ ")+(int)menu.SALIR + ". SALIR");
			Console.WriteLine("* ELIJA LA OPCIÓN QUE DESEA");
			Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^");
			option = Convert.ToInt32(Console.ReadLine());
			
			switch (option)
			{
				case 0:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*");
					Console.WriteLine("^ "+"HA SELECCIONADO SALIR");
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*");
					break;
				
				case 1:

					Console.Clear();
					if (numalum < alumnos.Length)
					{
						try
						{
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*^");
							Console.WriteLine("^ "+
							"INTRODUCE EL NOMBRE DEL ALUMNO");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*^");
							alumnos[numalum+1].nombre = Console.ReadLine();
							Console.Clear();
							
							
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*");
							Console.WriteLine("^ "+"INTRODUCE EL EMAIL"+
							" DEL ALUMNO");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
							+"^*");
							alumnos[numalum+1].email = Console.ReadLine();
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^"
							+"*^");
							Console.WriteLine("^ "+
							"INTRODUCE SUS CALIFICACIONES");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^"
							+"*^");
							Console.WriteLine("Pulse enter para continuar");
							Console.ReadLine();
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^*^");
							Console.WriteLine("^ "+"PRACTICA");
							Console.WriteLine("*^*^*^*^*^");
							alumnos[numalum+1].calificaciones.notaspractica
							=Convert.ToSingle(Console.ReadLine());
							Console.Clear();
							
							Console.WriteLine("*^*^*^*^");
							Console.WriteLine("^ "+"TEORIA");
							Console.WriteLine("*^*^*^*^");
							alumnos[numalum+1].calificaciones.notasteoria
							=Convert.ToSingle(Console.ReadLine());
							if(alumnos[numalum+1].calificaciones.notaspractica<0
							|| alumnos[numalum+1].calificaciones.
							notaspractica>10
							|| alumnos[numalum+1].calificaciones.notasteoria<0
							|| alumnos[numalum+1].calificaciones.notasteoria>10)
							{
								Console.WriteLine("");
								Console.WriteLine("Valores de calificaciones"+
								 " no válidos");
								 alumnos[numalum+1].nombre ="";
								 alumnos[numalum+1].email ="";
								 alumnos[numalum+1].calificaciones.notaspractica
								 =0;
								 alumnos[numalum+1].calificaciones.
								 notasteoria=0;
								 Console.ReadLine(); 
							}
							else
							{
								numalum++;
							}
						}
						catch (Exception e)
						{
							Console.WriteLine("");
							Console.WriteLine("Error:valores no validos");
							Console.WriteLine(e.Message);
							Console.ReadLine();
						}
					}
					else
					{
						Console.WriteLine("La base de datos está llena");
					}
					Console.Clear();
					break;
					
				case 2:
				Console.Clear();
				Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*^*^*");
					Console.WriteLine("^ "+
					"Seleccione el número que desea borrar");
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*^*^*");
					seleccion = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					
					if (seleccion <=0 || seleccion > numalum)
					{
						Console.WriteLine("");
						Console.WriteLine("número no válido");
						Console.ReadLine();
						Console.Clear();
					}
					else
					{
						Console.WriteLine("*^*^*^*^*^*^*^*");
						Console.WriteLine("^ "+"Estás seguro?");
						Console.WriteLine("*^*^*^*^*^*^*^*");
						Console.WriteLine("S/N");
						Console.WriteLine("*^*^*^*^*^*^*^*");
						eleccionborrar = Console.ReadLine();
						Console.Clear();
						if (eleccionborrar == "S")
						{
							for (int i=seleccion;i<=numalum;i++)
							{
								alumnos[i] = alumnos[i+1];
							}
							numalum--;
							Console.Clear();
						}
						else if (eleccionborrar == "N")
						{
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
							Console.WriteLine("Ha denegado la eliminacion");
							Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^");
							Console.ReadLine();
							Console.Clear();
						
						}
						else
						{
							Console.WriteLine("Seleccion no valida");
						}
					}
				break;
				
				case 3:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					 Console.WriteLine("alumnos - email - teoría -"+
					" práctica");
					Console.WriteLine("");
					for (int i=0;i<numalum;i++)
					 {
						 Console.Write(alumnos[i+1].nombre + " - ");
						 Console.Write(alumnos[i+1].email + " - ");
						 Console.Write(alumnos[i+1].calificaciones.
						 notasteoria+ " - ");
						 Console.WriteLine(alumnos[i+1].calificaciones.
						 notaspractica);
					 }
					 Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					Console.WriteLine("Pulse enter para continuar");
					Console.ReadLine();
					Console.Clear();
				break;
				
				case 4:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					 Console.WriteLine("alumnos - email - teoría -"+
					" práctica");
					Console.WriteLine("");
					
					for (int i=1;i<=numalum;i++)
					{
						if (alumnos[i].calificaciones.notasteoria *7/10 +
						alumnos[i].calificaciones.notaspractica *3/10 >=5 &&
						alumnos[i].calificaciones.notasteoria>=4 &&
						alumnos[i].calificaciones.notaspractica>=4)
						{
							Console.Write(alumnos[i].nombre + " - ");
							Console.Write(alumnos[i].email + " - ");
							Console.Write(alumnos[i].calificaciones.
							notasteoria+ " - ");
							Console.WriteLine(alumnos[i].calificaciones.
							notaspractica);
						}
					}
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					Console.WriteLine("^ "+"Pulse enter para continuar");
					Console.ReadLine();
					Console.Clear();
				break;
				
				case 5:
					Console.Clear();
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^");
					Console.WriteLine("^ "+"introduzaca el nombre a buscar");
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^");
					nombrebuscar = Console.ReadLine();
					Console.Clear();
					
					Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					 Console.WriteLine("alumnos - email - teoría -"+
					" práctica");
					Console.WriteLine("");
					for (int i=0;i<numalum;i++)
					 {
						if (alumnos[i+1].nombre.ToUpper().Contains(nombrebuscar.
						ToUpper()))
						{
							Console.Write(alumnos[i+1].nombre + " - ");
							Console.Write(alumnos[i+1].email + " - ");
							Console.Write(alumnos[i+1].calificaciones.
							notasteoria+ " - ");
							Console.WriteLine(alumnos[i+1].calificaciones.
							notaspractica);
						}
					 }
					 Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*"
					+"^*^*^*");
					Console.WriteLine("Pulse enter para continuar");
					Console.ReadLine();
					Console.Clear();
				break;	
			}
		}
		while(option!=0);	
	}
}

