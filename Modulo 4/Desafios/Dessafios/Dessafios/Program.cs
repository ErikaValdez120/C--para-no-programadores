// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------\nDesafíos\n---------\n");

Console.ReadKey();
Console.Clear();

//Ejercicio 1
//Copiar el contenido del vector origen al vector 
//destino, dejando en este último los valores 
//invertidos respecto del vector origen. Utilizar 
//estructura de control de flujo repetitiva, y luego 
//informar el índice y los valores del nuevo vector

Console.WriteLine("-----------\nEjercicio 1\n---------\n");

int[] vector1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] vector2 = new int[10];

Console.WriteLine("Vector 2: \n");
for (int i = 0; i < 10; i++)
{
    vector2[9 - i] = vector1[i];
}

for (int i = 0; i < 10; i++) {
    Console.WriteLine("Indice: {0}, Valor: {1}", i, vector2[i]); 

}

Console.ReadKey();
Console.Clear();

//Ejercicio 2
//Dado un vector del 0 al 11 con la facturación 
//correspondiente a todo un año, informar la 
//facturación por trimestre. Para esto, armar un 
//vector de 4 posiciones, donde cada posición 
//contenga la facturación de cada trimestre.

Console.WriteLine("-----------\nEjercicio 2\n---------\n");

double[] facturaciones = { 1000, 1200, 1522, 930, 3000, 1933, 1002, 1394, 2000, 790, 1990, 1300 };
double[] trimestres = new double[4];
double acum = 0;

for(int i = 0; i<4; i++)
{
    for(int j = i*3; j<(i+1)*3; j++)
    {
        acum += facturaciones[j];
        Console.WriteLine(j);
    }
    trimestres[i] = acum;
    Console.WriteLine(i);
    acum = 0;
}

for(int i = 0; i <4; i++)
{
    Console.WriteLine("La facturación total del trimestre {0} es de {1}", i+1, trimestres[i]);
}

Console.ReadKey();