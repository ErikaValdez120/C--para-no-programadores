//Laboratorio 1
//Ejercicio 1
//Imprimir los numeros del 1 al 10 uno abajo del otro

Console.WriteLine("\n---------\n Laboratorio 1\n---------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("---------\n Ejercicio 1\n---------\n");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} \n", i);
}

Console.ReadLine();
Console.Clear();

//Ejercicio 2
//Imprimir los números del 1 al 10 salteando de a 2 
//uno abajo del otro.

Console.WriteLine("---------\n Ejercicio 2\n---------\n");

for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine("{0} \n", i);
}

Console.ReadLine();
Console.Clear();

//Ejercicio 3
//Imprimir los números del 10 al 1 uno abajo del otro

Console.WriteLine("---------\n Ejercicio 3\n---------\n");

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine("{0} \n", i);
}

Console.ReadLine();
Console.Clear();

//Ejercicio 4
//Imprimir la suma de los números impares del 1 al 10

Console.WriteLine("---------\n Ejercicio 4\n---------\n");

for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine("{0} \n", i);
}

Console.ReadLine();
Console.Clear();

//Ejercicio 5
//Mostrar la resta de la multiplicación de los 
//números del 1 al 5 con la suma de los números 
//del 1 al 5. 
//Por ejemplo, sería (1 * 2 * 3 * 4 * 5) - (1+2+3+4+5).

Console.WriteLine("---------\n Ejercicio 5\n---------\n");

int mult = 1;
int sum = 0;

for (int i = 1; i <= 5; i++)
{
    mult *= i;
    sum += i;
}

Console.WriteLine("{0} \n", mult - sum);

Console.ReadLine();
Console.Clear();

//Ejercicio 6
//Imprimir la siguiente figura:
//@
//@
//@
//@

Console.WriteLine("---------\n Ejercicio 6\n---------\n");

for (int i = 1; i < 5; i++)
{
    Console.WriteLine("@");
}

Console.ReadLine();
Console.Clear();

//Ejercicio 7
//Imprimir la siguiente figura:
//@
//@@
//@
//@@
//@

Console.WriteLine("---------\n Ejercicio 7\n---------\n");

for (double i = 1; i < 6; i++)
{
    if ((i % 2).Equals(0d)) Console.WriteLine("@@");
    else Console.WriteLine("@");
}

Console.ReadLine();
Console.Clear();

//Ejecicio 8
//Imprimir la siguiente figura:
//@
//@@
//@@@
//@@@@
//@@@@@

Console.WriteLine("---------\n Ejercicio 8\n---------\n");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("@");
    }
    Console.Write("\n");
}

Console.ReadLine();
Console.Clear();

//Ejercicio 9
//Imprimir la siguiente figura:
//@@@@@
//@@@@
//@@@
//@@
//@

Console.WriteLine("---------\n Ejercicio 9\n---------\n");

for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("@");
    }
    Console.Write("\n");
}

Console.ReadLine();
Console.Clear();

//Ejercicio 10
//Imprimir la siguiente figura:
//@
//@@
//@@@
//@@@@
//@@@
//@@
//@


Console.WriteLine("---------\n Ejercicio 10\n---------\n");

int acum = 1;
for (int i = 1; i <= 6; i++)
{
    for (int j = 1; j <= i && i <= 4; j++)
    {
        Console.Write("@");
    }
    Console.Write("\n");
    for (int k = (i - acum); k >= 1 && i >= 4; k--)
    {
        Console.Write("@");
    }
    if (i >= 4) acum += 2;
}

Console.ReadLine();
Console.Clear();

//Laboratorio 2
//Imprimir la siguiente figura:
//@@@@@
//@@@
//@
//@@@
//@@@@@

Console.WriteLine("\n---------\n Laboratorio 2\n---------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("---------\n Ejercicio 1\n---------\n");

int acu1 = 1;
for (int i = 8; i >= 1; i -= 2)
{
    for (int j = i - 3; j >= 1 && i >= 4; j--)
    {
        Console.Write("@");
    }
    Console.WriteLine();
    for (int k = i - acu1; k >= 1 && i <= 4; k--)
    {
        acu1 += 2;
        acu1 *= (-1);
        Console.Write("@");
    }
}

Console.ReadKey();
Console.Clear();

//Ejercicio 2 
//Mostrar la suma de los números pares mayores 
//a 9 y menores a 20.

Console.WriteLine("---------\n Ejercicio 2\n---------\n");

int acu = 0;

for (int i = 10; i <= 20; i += 2)
{
    acu += i;
}

Console.WriteLine(acu);
Console.ReadKey();
Console.Clear();

////Ejercicio 3
//Implementar un código que imprima el mayor y el 
//menor de una serie de cinco números que vamos 
//introduciendo por teclado.


Console.WriteLine("---------\n Ejercicio 3\n---------\n");

int n1;
int menor = 100000000;
int mayor = -10000000;

for(int i = 0; i<=5; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    n1 = int.Parse(Console.ReadLine());
    if (n1 > mayor) mayor = n1;
    if (n1 < menor) menor = n1;
}

Console.WriteLine("El mayor es {0}", mayor);
Console.WriteLine("El menor es {0}", menor);

Console.ReadKey();
Console.Clear();

//Ejercicio 4
//Mostrar la conversión de 1 hasta 10 euros en 
//pesos, euro tras euro, suponiendo que el tipo de 
//cambio es 5.80 pesos por euro.

Console.WriteLine("---------\n Ejercicio 4\n---------\n");

const double precioEuro = 5.80;

for(double i=1; i<=10; i++)
{
    Console.WriteLine("El precio de {0} euros en pesos es: {1}", i, Math.Round(i * precioEuro, 4));
}

Console.ReadKey();
Console.Clear();

//Laboratorio 2
//Ejercicio 1
//Dado el vector {10,20,5,15,30,20}
//1.Informar el vector de la forma: "Indice: X, Valor: Y"
//2.Totalizar el vector e informar el total.
//3. Informar el contenido de las posiciones impares (por 
//ejemplo, las posiciones 1, 2, 5, etc).
//4.Informar el mayor número.
//5. Informar cuántas veces aparece el número 20

Console.WriteLine("\n---------\n Laboratorio 3\n---------\n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("---------\n Ejercicio 1\n---------\n");

double[] valores = { 10, 20, 5, 15, 30, 20 };

Console.WriteLine("1. \n");

for(int i = 0; i<valores.Length; i++)
{
    Console.WriteLine("Indice: {0}, Valor: {1}", i, valores[i]);
}

Console.WriteLine("\n2. \n");

double acuV = 0;
for (int i = 0; i < valores.Length; i++)
{
    acuV += valores[i];
}

Console.WriteLine("La suma de todos los valores del vector es: {0}", acuV);

Console.WriteLine("\n3. \n");

Console.WriteLine("Valores del vector en indices impares: ");
for (int i = 1; i < valores.Length; i+=2)
{
    Console.WriteLine(valores[i]);
}

Console.WriteLine("\n4. \n");

double mayorV = -1000000;
for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > mayorV) mayorV = valores[0];
}
Console.WriteLine("El mayor elemento del vector es: {0}", mayorV);

Console.WriteLine("\n5. \n");

int contador = 0;
for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] == 20) contador++;
}
Console.WriteLine("El numero 20 aparece {0} veces", contador);

Console.ReadKey();
Console.Clear();

//Ejercicio 2
////Dado el vector inflación {0.8, 0.1, 0.3, 0.4, 0.3, 
//0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9}
//Cada ítem del vector representa la inflación de un 
//mes de tal manera que el primer ítem del vector 
//que es 0.8 representa la inflación de Enero, y el 
//último ítem del vector que es 0.9 representa la 
//inflación de diciembre.
//Se pide:
//1.Informar la inflación anual.
//2. Informar la inflación más baja, junto con el 
//número de mes. Por ejemplo: Mes 2 = 0.1
//3.Informar la inflación más alta, junto con el 
//número de mes. Por ejemplo: Mes 12 = 0.9
//4.Informar el promedio de inflación (inflación 
//total / 2)

Console.WriteLine("---------\n Ejercicio 2\n---------\n");

double[] inflaciones = {0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9};

Console.WriteLine("1. \n");

acuV = 0;
for (int i = 0; i < valores.Length; i++)
{
    acuV += inflaciones[i];
}
Console.WriteLine("Inflacion anual: {0}", acuV);

Console.WriteLine("\n2. \n");

double menorV = 10000000;
int mes = 0;
for (int i = 0; i < valores.Length; i++)
{
    if (menorV > inflaciones[i]) {
        menorV = inflaciones[i];
        mes = i+1;
    }
}
Console.WriteLine("En el mes {0} se observo la menor inflacion de: {1}", mes ,menorV);

Console.WriteLine("\n3. \n");

mayorV = -10000000;
mes = 0;
for (int i = 0; i < valores.Length; i++)
{
    if (mayorV < inflaciones[i])
    {
        mayorV = inflaciones[i];
        mes = i+1;
    }
}
Console.WriteLine("\nEn el mes {0} se observo la mayor inflacion de: {1}", mes, mayorV);

Console.WriteLine("\n4. \n");

acuV = 0;
for (int i = 0; i < valores.Length; i++)
{
    acuV += inflaciones[i];
}
Console.WriteLine("La inflacion promedio anual es de: {0}", Math.Round(acuV/inflaciones.Length,4));

//Ejercicio 3

//Agregar los cambios que resulten necesarios al 
//ejercicio anterior para que en los puntos 2 y 3 se 
//informe la inflación junto con el nombre del mes. 

Console.WriteLine("---------\n Ejercicio 3\n---------\n");

string[] meses = {"Enero", "Febrero", "Marzo", "Abril","Mayo", "Junio", "Julio",
 "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

Console.WriteLine("2. \n");

menorV = 10000000;
mes = 0;
for (int i = 0; i < valores.Length; i++)
{
    if (menorV > inflaciones[i])
    {
        menorV = inflaciones[i];
        mes = i;
    }
}
Console.WriteLine("En {0} se observo la menor inflacion de: {1}", meses[mes], menorV);

Console.WriteLine("3. \n");

mayorV = -10000000;
mes = 0;
for (int i = 0; i < valores.Length; i++)
{
    if (mayorV < inflaciones[i])
    {
        mayorV = inflaciones[i];
        mes = i;
    }
}
Console.WriteLine("En {0} se observo la mayor inflacion de: {1}", meses[mes], mayorV);