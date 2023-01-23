using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validacion = false, validacion2 = false;
            string nombre = "", apellido = "", email = "", opcion = "", carrera = "";
          
            int edad = 0, codCarrera=0;
            do
            {
                Console.Clear();
                System.Console.WriteLine("\nIngresar nombre del alumno");
                nombre= System.Console.ReadLine();

                System.Console.WriteLine("\nIngresar apellido del alumno");
                apellido= System.Console.ReadLine();

                System.Console.WriteLine("\nIngrese la edad del alumno");
                edad = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("\nIngrese correo electronico del alumno");
                email = System.Console.ReadLine();

                System.Console.WriteLine("<<<<<<<<<Datos del alumno>>>>>>>:\n");
                System.Console.WriteLine($"Nombre: {nombre} \nApellido: {apellido} \nEdad: {edad}\nCorreo: {email}\n");
                System.Console.WriteLine("\n¿Los datos son correctos? 'YES' para confirmar, 'NO' para cancelar");
                opcion= System.Console.ReadLine();

              //  System.Console.ReadKey();
                if(opcion == "YES")
                {
                    //validacion= true;
                    do
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("\nDatos guardados.");
                        System.Console.WriteLine("\n<<<< Selecciona el codigo de la carrera elegida>>>>>");
                        System.Console.WriteLine("\n1.Programacion .NET");
                        System.Console.WriteLine("\n2.Programacion JAVA");
                        System.Console.WriteLine("\n3.Programacion PHP");
                        
                        codCarrera = Convert.ToInt32(Console.ReadLine());
                        if (codCarrera == 1 || codCarrera == 2 || codCarrera == 3)
                        {
                            if (codCarrera == 1) {
                                carrera = "Programacion .NET";
                            }
                            if (codCarrera == 2)
                            {
                                carrera = "Programacion JAVA";
                            }
                            if(codCarrera == 3) 
                            {
                                carrera = "Programacion PHP";
                            }
                            System.Console.WriteLine("\nDatos guardados. Presione una tecla para salir");
                            System.Console.WriteLine("\n<<<< Constancia de datos >>>>>");
                            System.Console.WriteLine($"Alumno:{nombre},\nCorreo:{email}\nCarrera:{carrera}");

                            System.Console.WriteLine("\nPresione una tecla para salir");
                            System.Console.ReadKey();

                            validacion2 = true;
                        }
                        else { 
                            System.Console.WriteLine("\nCarrera inexistente ,ingrese nuevamente");
                            System.Console.ReadKey();
                            validacion2 = false;
                        }

                       
                    } while (validacion2 == false);
                    validacion = true;
                }
                else { System.Console.WriteLine("\nDatos erroneos ingrese nuevamente"); }
                

            } while(validacion == false);
        }
    }
}
