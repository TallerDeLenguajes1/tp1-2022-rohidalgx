using System;


Console.WriteLine("\nHolis");
try
{
    Console.WriteLine("\n Ingrese un numero entero:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Resultado del cuadrado:" + num*num);
}
catch
{
    Console.WriteLine("\n No se aceptan letras");
}
