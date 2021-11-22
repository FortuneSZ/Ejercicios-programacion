using System;


class Ejercicio_05a_01
{
    static void rectangulo(int Base, int Altura)
    {
        Console.WriteLine("Escribe la base");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la altura");
        Altura = Convert.ToInt32(Console.ReadLine());
        for (int i=1;i<=Altura;i++)
        {
            for(int j=1;j<=Base;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    
    
    static void Main()
	{
        
        rectangulo(0,0);
    }
   
}
