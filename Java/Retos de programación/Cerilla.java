/* Programa que calcule cuantas cerillas necesitas por cada triangulo
 * (3 cerillas = 1 triangulo) */

 
 import java.util.Scanner;
 
 public class Cerilla
 {
     public static void main(String[] args)
     {
         Scanner sc = new Scanner(System.in);
         int triangulo = 0,altura, cerilla;
         do
         {
             altura = sc.nextInt();
             if (altura != 0)
             {
                 for (int i = 1; i <= altura; i++)
                 {
                     triangulo += i;
                 }
                 cerilla = 3 * triangulo;
                 System.out.println(cerilla);
             }
         }
         while (altura != 0);
     }
    
     
 }

