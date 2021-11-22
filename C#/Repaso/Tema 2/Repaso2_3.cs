/* Programa struct donde registre, la rutina concreta (string), 
 * los km hechos(float) y el tiempo en minutos (int). Se podrá almacenar 
 * hasta en 50 rutinas , y se mostrara el menu: dar alta nueva rutina 
 * (añadir ruta), media de km (media entre todos los km), tiempo mas corto
 * (mostrara la rutina con menos tiempo) y salir */

using System;
class Repaso2_3
{
	struct rutina
	{
		public string nombreRutina ;
		public float km;
		public int minutos;
	}
	enum opciones {DARALTA=1, MEDIAKM, TIEMPOCORTO, SALIR }
	
	static void Main()
	{
        string[] mes = {"Enero", "Febrero", "Marzo","Abril","Mayo","Junio",
           "Julio", "Agosto", "Septiembre", "Octubre","Noviembre", "Diciembre"};
		rutina[] rutinas = new rutina[50];
		rutina nuevaRutina;
        float mediaKm;
		int cantidad = 0, opcion;
		bool correcto;
		
		do
		{
			Console.WriteLine("Menu de opciones");
			Console.WriteLine((int)opciones.DARALTA
			 + "Dar de alta una ruta");
			Console.WriteLine((int)opciones.MEDIAKM
			 + "Mostrar media de kilómetros");
			Console.WriteLine((int)opciones.TIEMPOCORTO
			 + "Mostrar recorrido mas corto");
			Console.WriteLine((int)opciones.SALIR
			 + "Salir del menú");
			 
			opcion = Convert.ToInt32(Console.ReadLine());
		
			switch((opciones)opcion)
			{
				case opciones.DARALTA:
				
				if(cantidad < rutinas.Length)
				{
					Console.WriteLine("Dime el nombre de la rutina");
					nuevaRutina.nombreRutina = Console.ReadLine();
                    
                    Console.WriteLine("Dime el mes de la rutina:");
                    nuevaRutina.mes = Console.ReadLine();
                    
                    correcto = false;
                    foreach(string mes in meses)
                    {
                        if(nuevaRutina.mes.To.Upper() == mes.ToUpper())
                        {
                            correcto = true;
                        }
                    }
                    if (correcto && nuevaRutina.distancia > 0
                        && nuevaRutina.tiempo > 0)
                    {
                        rutinas[cantidad] = nuevaRutina;
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Escribe la distancia:");
                        nuevaRutina.distancia =
                            Convert.ToSingle(Console.ReadLine());
                            
                        if(nuevaRutina.distancia < 0)
                        {
                            Console.WriteLine("Distancia incorrecta");
                        }
                    }
		
					Console.WriteLine("Dime cuantos Km has recorrido");
					nuevaRutina.km = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Dime cuanto dura el recorrido" +
					" (en minutos)");
					nuevaRutina.minutos= Convert.ToInt32(Console.ReadLine());	
		
					rutinas[cantidad] = nuevaRutina;
					cantidad++;
					
				}
                    break;
		
				case opciones.MEDIAKM:
                    mediaKm = 0;
                    for(int i = 0; i <cantidad; i++)
                    {
                        media += rutinas[i].distancia;
                    } 
                    mediaKm /= cantidad;
                    Console.WriteLine("Media Km = {0}". media.ToString("N2"));
                    break;
				
				case opciones.TIEMPOCORTO:
					break;
				case opciones.SALIR:
					Console.WriteLine("Fin del programa");
					break;
				default:
			}
		}
			while(opcion != (int)opciones.SALIR);
	
	}
}
		

