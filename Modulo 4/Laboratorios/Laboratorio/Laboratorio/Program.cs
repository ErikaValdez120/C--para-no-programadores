// See https://aka.ms/new-console-template for more information
using System;

//Laboratorio1
//Ejercicio1
//Uso de vector con ingreso de datos por teclado. 
//Ingrese por teclado la facturación de los últimos 
//6 meses. Solo se pueden ingresar números.
//Informar
//1. La facturación total.
//2. El promedio de facturación.
//3. La máxima facturación.
//4. La máxima facturación.

Console.WriteLine("-----------------\nLaboratorio 1\n-----------------\n\n");
Console.ReadKey();
Console.Clear();

Console.WriteLine("-----------------\nEjercicio 1\n-----------------\n\n");
double[] facturaciones = new double[6];
double acum = 0;
double max = -1000000;
double min = 1000000;
Console.WriteLine("Ingrese la facturación de un mes: ");
for(int i = 0; i <6; i++)
{
    while (!double.TryParse(Console.ReadLine(), out facturaciones[i])) {
        Console.WriteLine("Ingrese un valor numérico: ");
            };
    acum += facturaciones[i];
    if (facturaciones[i] > max) max = facturaciones[i];
    if (facturaciones[i] < min) min = facturaciones[i];
    if(i<facturaciones.Length-1)Console.WriteLine("Ingrese la facturación del siguiente mes: ");
}

Console.WriteLine("La facturacion total en los 6 meses es: {0}\n", acum);
Console.WriteLine("El primedio de facturacion total en los 6 mes es de: {0}\n", Math.Round(acum / facturaciones.Length));
Console.WriteLine("La facturación minima fue de: {0}", min);
Console.WriteLine("La facturación máxima fue de: {0}", max);

Console.ReadKey();
Console.Clear();

//Ejercicio2
//Copiar el contenido del vector origen al vector 
//destino utilizando estructura de control de flujo 
//repetitiva y, luego, informar el índice y los valores 
//del nuevo vector.

Console.WriteLine("-----------------\nEjercicio 2\n-----------------\n\n");

int[] vectorOrigen = { 2, 3, 4, 5, 22, 193, 555, 32, 77, 23 };
int[] vectorDestino = new int[10];
for(int i = 0; i<vectorOrigen.Length; i++)
{
    vectorDestino[i] = vectorOrigen[i];
    Console.WriteLine("En el indice: {0} el vector destino vale: {1}", i, vectorDestino[i]);
}

Console.ReadKey();
Console.Clear();

//Laboratorio2
//Implementando funciones y procedimientos
//Ejercicio1
//Realizar un programa que permita ingresar un 
//número entero positivo e informe si es par o impar

Console.WriteLine("-----------------\nLaboratorio 2\n-----------------\n\n");
Console.ReadKey();
Console.Clear();


Console.WriteLine("-----------------\nEjercicio 1\n-----------------\n\n");
Console.WriteLine("Ingrese un numero: ");
esPar(Convert.ToInt32(Console.ReadLine()));

static void esPar(int numero)
{
    if (numero % 2 == 0) Console.WriteLine("Es par");
    else Console.WriteLine("Es impar");
}

Console.ReadKey();
Console.Clear();

//Ejercicio 2
//Realizar un programa con dos funciones que 
//sean capaz de realizar una suma y una resta.

Console.WriteLine("-----------------\nEjercicio 2\n-----------------\n\n");
Console.WriteLine("Ingrese el primer numero: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Su suma es: {0}", sumar(num1, num2));
Console.WriteLine("Su resta es: {0}", restar(num1, num2));

static double sumar(double numero1, double numero2)
{
    return numero1 + numero2;
}

static double restar(double numero1, double numero2)
{
    return numero1 - numero2;
}

Console.ReadKey();
Console.Clear();

//Ejercicio 3
//Realizar un programa con un menú de opciones
//para llamar a funciones que realizan operaciones 
//matemáticas.

Console.WriteLine("-----------------\nEjercicio 2\n-----------------\n\n");
Console.WriteLine("Ingrese el primer numero: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());
int op = 0;

while (op != 5) {
    Console.WriteLine("Ingrese la operación a realizar:\n 1. Suma\n 2. Resta\n 3. Multiplicacion\n 4. Division" +
        "\n 5. Salir");
    op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 1: Console.WriteLine("Su suma es: {0}", sumar(num1, num2));
            break;
        case 2: Console.WriteLine("Su resta es: {0}", restar(num1, num2));
            break;
        case 3: Console.WriteLine("Su producto es: {0}", multiplicar(num1, num2));
            break;
        case 4: Console.WriteLine("Su cociente es: {0}", dividir(num1, num2));
            break;
        case 5: Console.WriteLine("Finalizando programa...");
            break;
        default: Console.WriteLine("Ingrese un valor correcto");
            break;
    }
}

Console.ReadKey();
Console.Clear();
static double multiplicar(double numero1, double numero2) { return numero1 * numero2; }
static double dividir(double numero1, double numero2) { return numero1 / numero2; }