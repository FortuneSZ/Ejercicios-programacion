/**/
using System;
using System.Text;
class Ejercicio_04c_15
{	
	static void Main()
	{

		int suma=0;
		string numeros;
		Console.WriteLine("introduzca números separados por espacios");
		numeros = Console.ReadLine();
		string[] numero = numeros.Split(' ');
		
		foreach(string p in numero)
		{
			int numero2= Convert.ToInt32(p);
			suma+= numero2;
		}
		Console.WriteLine("la suma es {0}",suma);
		
		
	}
}

