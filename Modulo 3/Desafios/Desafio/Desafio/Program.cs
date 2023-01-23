// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------\nDesafios\n-----------\n");
Console.ReadLine();
Console.Clear();

//Ejercicio 1
//Una persona desea invertir $1000 en un banco, el 
//cual le otorga un 2% de interés mensual. 
//¿Cuál será la cantidad de dinero que esta 
//persona tendrá al cabo de un año?. 
//En el primer mes tendrá acumulado $1000 más 
//$20 de interés ( 2% de 1000 ). En el segundo mes 
//se le sumará un 2% a la base de $1020 del mes 
//anterior y así sucesivamente. 

Console.WriteLine("-----------\nEjercicio 1\n-----------\n");

const double INTERES1 = 0.02;
//Se inicializa la variable con la inversión inicial
double dineroTotal = 1000;

for (int i = 1; i <= 12; i++)
{
    dineroTotal += INTERES1 * dineroTotal;
}

Console.WriteLine("Dinero acumulado en un año: {0}", dineroTotal);

Console.ReadLine();
Console.Clear();

//Ejercicio 2
//Una persona desea invertir $1000 en un banco, el 
//cual le otorga un 3% de interés mensual. 
//¿En cuantos meses conseguirá $1200, si 
//reinvierte cada mes todo su dinero?.

Console.WriteLine("-----------\nEjercicio 2\n-----------\n");

const double INTERES2 = 0.03;
dineroTotal= 1000;
int mes = 0;

for (int i = 1; dineroTotal<=1200; i++)
{
    dineroTotal += INTERES2 * dineroTotal;
    mes = i;
}

Console.WriteLine("El cliente consigué $1200 en {0} meses", mes);

Console.ReadLine();
Console.Clear();

//Ejercicio 3
//Desarrollar el código que permita a una persona 
//ingresar como máximo tres veces su contraseña.
//● En caso de ingreso correcto deberá exhibirse 
//la leyenda “Bienvenido!!”, caso contrario se 
//mostrará “tres veces fallidas”. 
//● Indicar cuantas posibilidades de ingresar el 
//código le queda. Por ejemplo, si tiene 2 
//posibilidades, informar "Tiene dos chances 
//!" y si le queda una última oportunidad 
//"Atención!! Ultima oportunidad!"

Console.WriteLine("-----------\nEjercicio 3\n-----------\n");

const string CONTRASEÑAVALIDA = "contraseña123";
const int MAXIMOSINTENTOS = 3;
Console.WriteLine("Bienvenidx");

for(int i= 1; i<=MAXIMOSINTENTOS; i++)
{
    Console.WriteLine("Por favor, Ingrese su contraseña: \n");
    string contraseña = Console.ReadLine();
    if (contraseña == CONTRASEÑAVALIDA)
    {
        Console.WriteLine("Bienvenido!!");
        break;
    }
    else if (i < MAXIMOSINTENTOS-1)
    {
        Console.WriteLine("Tiene {0} chances!", MAXIMOSINTENTOS-i);
    }else if (i == MAXIMOSINTENTOS-1)
    {
        Console.WriteLine("Atencion!! Ultima oportunidad");
    }
    else
    {
        Console.WriteLine("Tres veces fallidas.");
    }
}

Console.ReadLine();
Console.Clear();