using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace desafio_2___modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2
            Realizar un programa que lea por teclado dos
            números, si el primero es mayor al segundo
            informar su suma y diferencia, en caso contrario
            informar el producto y la división del primero
            respecto al segundo*/


            Console.WriteLine("Ejercicio 2\n");
            Console.WriteLine("Realizar un programa que lea por teclado dos\r\nnúmeros, si el primero es mayor al segundo\r\ninformar su suma y diferencia, en caso contrario\r\ninformar el producto y la división del primero\r\nrespecto al segundo");

            int result = 0, num1 = 0, num2 = 0;
           
           
                System.Console.WriteLine("\nIngrese el primer numero");
                 num1= Convert.ToInt32(Console.ReadLine());
                
                System.Console.WriteLine("\nIngrese el segundo numero");
                 num2 = Convert.ToInt32(Console.ReadLine());
              
            if (num1 > num2)
                {
                    int suma = num1 + num2;
                    int diferencia = num1 - num2;
                    System.Console.WriteLine("\nEl primer numero es mayor\n");
                    System.Console.WriteLine($"la suma de los 2 numeros es : {suma}");
                    System.Console.WriteLine($"la diferencia de los 2 numeros es : {diferencia}");
                    System.Console.ReadKey();
                }
                else
                {
                    int producto = num1 * num2;
                    int division = num1 / num2;
                    System.Console.WriteLine("El primer numero es menor\n");
                    System.Console.WriteLine($"el producto de los 2 numeros es : {producto}");
                    System.Console.WriteLine($"la division de los 2 numeros es : {division}");
                    System.Console.ReadKey();
                }
                

            
                
        }
    }
}
