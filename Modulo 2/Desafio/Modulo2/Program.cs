using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ejercicio 1 

            Ingresar una nota de un alumno, e informar 
            si está aprobado, si recupera o si promociona 
            la materia. 
            Datos
            Se aprueba con 4 y se promociona con 7 */

            System.Console.WriteLine("Ejercicio 1\n");

            System.Console.WriteLine("Ingresar una nota de un alumno, e informar \r\n            si está aprobado, si recupera o si promociona \r\n            la materia. \r\n            Datos\r\n            Se aprueba con 4 y se promociona con 7");

            int nota = 0;
            do
            {
                System.Console.WriteLine("Ingrese nota del alumno");
                nota = System.Convert.ToInt16(System.Console.ReadLine());

                if (nota == 4)
                {
                    System.Console.WriteLine("Aprobado");
                    System.Console.ReadKey();
                    
                }

                if (nota >= 7)
                {
                    System.Console.WriteLine("Promociona");
                    System.Console.ReadKey();
                }
                if (nota < 4 && nota >1){
                    System.Console.WriteLine("Desaprobado");
                    System.Console.ReadKey();
                }
                else { System.Console.WriteLine("Ingresar un valor entre 1 - 10"); }

            } while (nota <=0 && nota >= 10);

        }
    }
}

