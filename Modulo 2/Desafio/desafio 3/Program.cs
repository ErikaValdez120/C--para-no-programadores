using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Ejercicio 3\r\nIngresar 2 notas de parciales de un alumno,\r\ne informar si está aprobado, desaprobado o si\r\ndebe recuperar el primer parcial o el segundo,\r\nsabiendo que la nota de aprobación es 4 y se\r\ndeben aprobar los 2 parciales.");

            int nota1 = 0 , nota2 = 0 ;
            do
            {
                System.Console.WriteLine("\nIngrese la nota del primer parcial del alumno");
                nota1 = System.Convert.ToInt16(System.Console.ReadLine());

                System.Console.WriteLine("\nIngrese la nota del segundo parcial del alumno");
                nota2 = System.Convert.ToInt16(System.Console.ReadLine());

                if (nota1 >= 4 && nota2 >=4 )
                {
                    System.Console.WriteLine(" Felicitaciones está Aprobado");
                    System.Console.ReadKey();

                }

                if (nota1 >= 4 && nota2 <4)
                {
                    System.Console.WriteLine("Debe recuperar el segundo parcial para aprobar");
                    System.Console.ReadKey();
                }
                if (nota1 < 4 && nota2 >= 4)
                {
                    System.Console.WriteLine("Debe recuperar el primer parcial para aprobar");
                    System.Console.ReadKey();
                }
                else { System.Console.WriteLine("Ingresar un valor entre 1 - 10"); }

            } while (nota1 <= 0 || nota2 <= 0);
        }
    }
}
