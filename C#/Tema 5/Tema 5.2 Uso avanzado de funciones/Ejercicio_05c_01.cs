/* Programa con funcion recursiva ContarDigitos que reciba como parametro 
 * un numero entero y devuelva cuantos digitos tiene */

using System;
class Ejercicio_05c_01
{
    static int AmountOfDigitsR(int num)
    {
        if(num < 10)
        {
            return 1;
        }
        return 1 + AmountOfDigitsR(num / 10);
    }


    public static void Main()
    {
        Console.WriteLine(AmountOfDigitsR(131248));
    }
}
