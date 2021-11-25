/**/
using System;


class Ejercicio_05b_01b
{

    static void Main()
	{
        int edad;
        bool correcto=false;
        
        do
        {
            Console.WriteLine("dime tu edad");
            if (Int32.TryParse(Console.ReadLine(),out edad) &&
            edad>0 && edad<120)
            {
                correcto=true;
            }
        }
        while(correcto!=true);
      
    }
   
}
