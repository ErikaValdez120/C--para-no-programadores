using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
           
            
            System.Console.WriteLine("Ejercicio 1");
           /*
            Dados n1 = true, n2 = false y n3 = true.
            Informar:
                    a.n1 ^ n2
                    b. (n1 & !n2) | n3
                    c. (n1 | n2) & !n3 
           */

            bool n1 = true, n2 = false, n3 = true; 

            System.Console.WriteLine("Dados n1 = true, n2 = false y n3 = true.\r\n           " +
            " Informar:\r\n                    " +
                "a.n1 ^ n2\r\n                    " +
                "b. (n1 & !n2) | n3\r\n                    " +
                "c. (n1 | n2) & !n3\n");

            
            bool resultA = n1 ^ n2;
            System.Console.WriteLine($" A . {resultA}");

            bool resultB = (n1 & !(n2)) | n3;
            System.Console.WriteLine($" B . {resultB}");

            bool resultC = (n1 | n2) & !n3;
            System.Console.WriteLine($" C . {resultC}");


            System.Console.WriteLine("");
            System.Console.WriteLine("Ejercicio 2\n");
            System.Console.WriteLine("\nDeclarar dos variables n1=5 y n2=10.\r\nUtilizando concatenación entre las variables \r\ny los literales, mostrar en pantalla la siguiente \r\nexpresión:");

            byte var1 = 5, var2 = 10;
            int suma = var1 + var2;

            System.Console.WriteLine($"\nn1 es igual a {var1} , n2 es igual a {var2} y n1 mas n2 es igual a {suma} ");
            

            System.Console.WriteLine("");
            System.Console.WriteLine("Ejercicio 3\n");

            System.Console.WriteLine("Haciendo uso de la constante IVA=21, calcular \r\nel precio con " +
                "IVA de los siguientes productos \r\ne informar: \r\na. Remera: 59.90$\r\nb. " +
                "Pantalón: 99.90$ \r\nc. Campera: 149.90$\r\n");

            const int IVA= 21; //(remera + remera * IVA / 100))
            //double remera = 59.90 * 1.21, pantalon = 99.90 * 1.21, campera = 149.90 * 1.21;
            double remera = 59.90, pantalon = 99.90, campera = 149.90;
            System.Console.WriteLine("Precio Remera con IVA : {0}$",remera +remera*IVA/100);
            System.Console.WriteLine("Precio Pantalon con IVA : {0}$",pantalon+pantalon*IVA/100);
            System.Console.WriteLine("Precio Campera con IVA: {0}$",campera + campera*IVA/100);

            System.Console.Read(); 
            
        }
    }
}
