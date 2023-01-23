// See https://aka.ms/new-console-template for more information

//Laboratorio 1
//Ejercicio 1
//Crear una estructura para almacenar los datos 
//pertenecientes a los productos de una tienda. 
//Codificar una aplicación de consola que permita 
//cargar todos los datos de un producto y 
//mostrarlos por pantalla.

using System;

Console.WriteLine("--------------\nLaboratorio 1\n--------------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("--------------\nEjercicio 1\n--------------\n");

Producto[] productos = new Producto[3];
for(int i = 0; i < productos.Length; i++)
{
    Console.WriteLine("Ingrese el nombre del producto: ");
    productos[i].nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el descripción del producto: ");
    productos[i].descripcion = Console.ReadLine();
    productos[i].id = i+1;
    Console.WriteLine("Ingrese la cantidad del producto: ");
    productos[i].cantidad = Convert.ToInt32(Console.ReadLine());
    if (productos[i].cantidad < 10) productos[i].reponerStock = true;
    else productos[i].reponerStock = false;
    Console.Clear();
}

for (int i = 0; i < productos.Length; i++)
{
    Console.WriteLine("ID del producto: {0}", productos[i].id);
    Console.WriteLine("Nombre del producto: {0}", productos[i].nombre);
    Console.WriteLine("Descripción del producto: {0}", productos[i].descripcion);
    Console.WriteLine("Cantidad del producto: {0}", productos[i].cantidad);
    if (productos[i].reponerStock) Console.WriteLine("Hay que reponer el stock del producto.");
}

Console.ReadKey();
Console.Clear();

//Laboratorio 2
//Ejercicio 1
//En base al ejercicio realizado en el Laboratorio 1:
//1.Crear un arreglo de productos.
//2. Codificar una aplicación de consola que 
//permita cargar todos los datos de 3 productos 
//en el arreglo y mostrarlos por pantalla.

//Ya realizado

//Ejercicio 2
//Crear una enumeración que liste los diferentes 
//tipos de IVA. 
//Codificar una aplicación de consola que muestre 
//todos los valores posibles de la enumeración.

Console.WriteLine("--------------\nLaboratorio 2\n--------------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("--------------\nEjercicio 2\n--------------\n");

Console.WriteLine((int)ivas.tipo1);
Console.WriteLine((int)ivas.tipo2);
Console.WriteLine((int)ivas.tipo3);

public struct Producto{
    public string nombre;
    public string descripcion;
    public int id;
    public int cantidad;
    public bool reponerStock;
}

public enum ivas
{
    tipo1 = 1,
    tipo2 = 5,
    tipo3 = 18
}