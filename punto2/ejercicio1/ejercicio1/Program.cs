using System;


Console.WriteLine("\nHolis");
try
{
    Console.WriteLine("\n Ingrese un numero entero:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Resultado del cuadrado:" + num*num);
}
catch (FormatException)
{
    Console.WriteLine("¡Ingrese un número válido (formato incorrecto)!");
}
catch (OverflowException)
{
    Console.WriteLine("¡Ingrese un número válido (error de overflow)!");
}
catch (Exception e)
{
    Console.WriteLine("Error, ingrese un número válido." + e);
}
