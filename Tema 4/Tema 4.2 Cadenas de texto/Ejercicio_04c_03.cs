
using System;
class Ejercicio_04b_02
{
	static void Main()
	{
		string nombre;
		Console.WriteLine("escriba su nombre");
		nombre = Console.ReadLine();
		for (int i=0;i<nombre.Length;i++)
		{
			
				Console.Write(nombre[i]);
			if (i<nombre.Length-1)
			{
				Console.Write("-");
			}
		}
		
	}
    
}	
