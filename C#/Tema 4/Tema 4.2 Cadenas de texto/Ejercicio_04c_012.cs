/**/
using System;
class ejercicio
{	
	static void Main()
	{
		string [] frases = new string [5];
		Console.WriteLine("Introduce 5 frases");
		for (int i=0;i<frases.Length;i++)
		{
			frases[i]=Console.ReadLine();
		}
		string mayor=frases[0];
		for (int i=1;i<frases.Length;i++)
		{
			if (mayor.CompareTo(frases[i]) < 0)
			{
				mayor=frases[i];
			}
		}
		Console.WriteLine("el mayor es {0}",mayor);			
	}
}

