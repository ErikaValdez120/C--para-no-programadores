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
            
            int edad = 0, codCarrera = 0;
            bool validacion = false, validacion2 = false, seguir = true;
            string nombre = "", apellido = "", email = "", opcion = "", carrera = "";
            char continuar = 'S';
            string[] cursosAlumno = new string[5];
            string[] cursos = new string[6];
            cursos[0] = "";
            cursos[1] = "HTML5 DESARROLLO WEB";
            cursos[2] = "Programacion orientada a objetos";
            cursos[3] = "C# para no programadores";
            cursos[4] = "Bases de datos SQL";
            cursos[5] = "Git";
            



            do
            {
                Console.Clear();
                System.Console.WriteLine("\nIngresar nombre del alumno");
                nombre = System.Console.ReadLine();

                System.Console.WriteLine("\nIngresar apellido del alumno");
                apellido = System.Console.ReadLine();

                System.Console.WriteLine("\nIngrese la edad del alumno");
                edad = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("\nIngrese correo electronico del alumno");
                email = System.Console.ReadLine();
                System.Console.Clear();

                System.Console.WriteLine("<<<<<<<<<Datos del alumno>>>>>>>:\n");
                System.Console.WriteLine($"Nombre: {nombre} \nApellido: {apellido} \nEdad: {edad}\nCorreo: {email}\n");
                System.Console.WriteLine("\n¿Los datos son correctos? 'YES' para confirmar, 'NO' para cancelar");
                opcion = System.Console.ReadLine();

                //  System.Console.ReadKey();
                if (opcion == "YES")
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
                            if (codCarrera == 3)
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


            } while (validacion == false);

            // ------------------------------------ MODULO 5 -------------------------------
            do
            {
                System.Console.Clear();
                Console.WriteLine("<<<<<<< Cursos de la carrera >>>>>>");
                Console.WriteLine("\nIngrese el codigo del curso que desea inscribirse");
                Console.WriteLine("\n1. HTML5 : Fundamentos web");
                Console.WriteLine("\n2. C# .NET : Para no programadores");
                Console.WriteLine("\n3. Programacion Orientada a objetos");
                Console.WriteLine("\n4. Introduccion a las bases de datos y SQL");
                Console.WriteLine("\n5. GIT ");

                for (int i = 0; i < cursos.Length; i++)
                {
                    Console.WriteLine("\nIngrese el codigo del curso :");
                    string codCurso = Console.ReadLine();


                    switch (codCurso) 
                    {
                        case "1":
                            cursosAlumno[i] = "1. HTML5 : Fundamentos web";
                            break;
                        case "2":
                            cursosAlumno[i]= "2. C# .NET : Para no programadores";
                            break;
                        case "3":
                            cursosAlumno[i] = "3.Programacion orientada a objetos";
                            break;
                        case "4":
                            cursosAlumno[i] = "4.Introduccion a las bases de datos y SQL";
                            break;
                        case "5":
                            cursosAlumno[i] = "5.GIT";
                            break;
                        default:
                            Console.WriteLine("ERROR ingrese nuevamente");
                            break;
                    }

                    
                    Console.WriteLine("\n¿Desea seguir agregando cursos? S/N");
                    continuar = Convert.ToChar(Console.ReadLine());
                    if (continuar == 'N')
                    {
                        Console.WriteLine("\nDatos guardados correctamente. Presione una tecla para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }


                }

                Console.WriteLine("<<< Constancia de cursos >>>>");

                System.Console.WriteLine($"Nombre: {nombre} \nApellido: {apellido} \nEdad: {edad}\nCorreo: {email}\nCarrera: {carrera}\n");
                Console.WriteLine("Cursos inscripto:\n");
                for (int i = 0; i <cursosAlumno.Length; i++)
                {
          
                   Console.WriteLine(cursosAlumno[i]);                       
                    
                }
                 
                Console.ReadKey();

                seguir = false;

            } while (seguir == false);

             
        }//main

    }
}
