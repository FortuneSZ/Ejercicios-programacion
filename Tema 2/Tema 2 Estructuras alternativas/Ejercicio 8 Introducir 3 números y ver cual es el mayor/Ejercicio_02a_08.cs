/* vamos a crear un programa que nos diga cual de los 3 numeros introducidos
es el mayor */
using System;
class ejercicio_02a_08
{
	
	static void Main()
	{	
		int numero1,numero2,numero3;
		
		Console.WriteLine("dime 3 numeros");
		numero1=Convert.ToInt32(System.Console.ReadLine());
		numero2=Convert.ToInt32(System.Console.ReadLine());
		numero3=Convert.ToInt32(System.Console.ReadLine());
		
		if (numero1>numero2 && numero1>numero3)
		{	
			Console.WriteLine("{0} es el mayor numero",numero1);
		}
		
		if (numero2>numero1 &&numero2>numero3)
		{	
			Console.WriteLine(" {0} es el mayor numero",numero2);
		}
		
		if (numero3>numero1 &&numero3>numero2)
		{	
			Console.WriteLine(" {0} es el mayor numero",numero3);
		}	
	}	
}
