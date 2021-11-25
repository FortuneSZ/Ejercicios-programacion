/**/
using System;


class Ejercicio_05b_01
{

    static void Main()
	{
        int edad;
        
        do
        {
            Console.WriteLine("dime tu edad");
        }
        while(!Int32.TryParse(Console.ReadLine(),out edad) ||
        edad<0 || edad>120);
      
    }
   
}
