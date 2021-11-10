/**/
using System;
class ejercicio
{	
	static void Main()
	{
		string secuencia;
		int total=0;
		Console.WriteLine("Introduce numeros separados por espacios: ");
		secuencia=Console.ReadLine();
		string[] numero = secuencia.Split(' ');
		for(int i=numero.Length;i>0;i--)
		{
			total=total+Convert.ToInt32(numero[i-1]);
		}
		Console.WriteLine("Resultado : {0}",total);
	}
}

