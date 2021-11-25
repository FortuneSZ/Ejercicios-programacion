/**/
using System;


class Ejercicio_05b_02
{

    static void Main()
	{
        int numero,numeroadivin,contador=5;
        Random r = new Random();
        numeroadivin=r.Next(1,101);
        do
        {
            Console.WriteLine("escribe tu intento de adivinar el número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero!=numeroadivin)
            {
                contador--;
                if (numero>numeroadivin)
                {
                    Console.WriteLine("El número introducido es mayor");
                }
                else
                {
                     Console.WriteLine("El número introducido es menor");
                }
            }
        }
        while (contador!=0);
         Console.WriteLine("te quedaste sin intentos");
        
        
      
    }
   
}
