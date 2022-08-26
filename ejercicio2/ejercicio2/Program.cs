
using System;


Console.WriteLine("\nHolis");
try
{
    Console.WriteLine("\n Ingrese un numero entero:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Ingrese otro numero entero:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Resultado de la division:" + num1/num2);
}
catch
{
    Console.WriteLine("\n No se puede dividir en 0");
}