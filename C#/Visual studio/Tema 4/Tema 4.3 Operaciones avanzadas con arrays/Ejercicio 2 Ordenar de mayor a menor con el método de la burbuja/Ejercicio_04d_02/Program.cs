/*Este porgrama le pedirá al usuario que introduzca 10 números y los ordenará
de mayor a menor*/
class Ejercicio_04d_02
{
    static void Main()
    {
        int contador = 1;
        float[] numeros = new float[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("escriba el {0} numero", contador);
            numeros[i] = Convert.ToSingle(Console.ReadLine());
            contador++;
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = 0; j < numeros.Length - i - 1; j++)
            {
                if (numeros[j] < numeros[j + 1])
                {
                    float auxiliar = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = auxiliar;
                }
            }
        }
        Console.Clear();
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}
