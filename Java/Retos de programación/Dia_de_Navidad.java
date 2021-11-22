/* */

import java.util.Scanner;

public class Dia_de_Navidad
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int numCasos, dia, mes;
        
        numCasos = sc.nextInt();
        
        for(int i = 0; i < numCasos; i++)
        {
            dia = sc.nextInt();
            mes = sc.nextInt();
            if (dia == 25 && mes == 12)
            {
                System.out.println("SI");
            }
            else
            {
                System.out.println("NO");
            }
        }
    }
}
