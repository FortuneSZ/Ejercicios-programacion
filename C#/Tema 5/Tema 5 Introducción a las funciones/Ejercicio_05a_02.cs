using System;


class Ejercicio_05a_01
{
    static void rectangulo(int Base, int Altura)
    {
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
        
        rectangulo(4,2);
    }
   
}
